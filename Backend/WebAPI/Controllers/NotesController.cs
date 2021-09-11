using AutoMapper;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;
using WebAPI.Validators;

namespace WebAPI.Controllers
{
    [EnableCors("CustomPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INoteService _noteService;
        private readonly IMapper _mapper;
        public NotesController(INoteService noteService, IMapper mapper)
        {
            _noteService = noteService;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<NoteDTO>>> GetAllNotes()
        {
            var notes = await _noteService.GetAllWithUsers();
            var noteResources = _mapper.Map<IEnumerable<Note>, IEnumerable<NoteDTO>>(notes);

            return Ok(noteResources);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<NoteDTO>>> GetNoteById(int id)
        {
            var note = await _noteService.GetByUserId(id);
            var noteResource = _mapper.Map<IEnumerable<Note>, IEnumerable<NoteDTO>>(note);
            return Ok(noteResource);
        }

        [HttpGet("byuser/{id}")]
        public async Task<ActionResult<NoteDTO>> GetNoteByUserId(int id) {
            var note = await _noteService.GetById(id);
            var noteResource = _mapper.Map<Note, NoteDTO>(note);
            return Ok(noteResource);
        }

        [HttpPost("")]
        public async Task<ActionResult<NoteDTO>> CreateNote([FromBody] SaveNoteDTO saveNoteResource)
        {
            var validator = new SaveNoteResourceValidator();
            var validationResult = await validator.ValidateAsync(saveNoteResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var noteToCreate = _mapper.Map<SaveNoteDTO, Note>(saveNoteResource);
            var newNote = await _noteService.Create(noteToCreate);

            var note = await _noteService.GetById(newNote.Id);
            var noteResource = _mapper.Map<Note, NoteDTO>(note);

            return Ok(noteResource);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<NoteDTO>> UpdateNote(int id, [FromBody] SaveNoteDTO saveNoteResource)
        {
            var validator = new SaveNoteResourceValidator();
            var validationResult = await validator.ValidateAsync(saveNoteResource);

            if (id == 0 || !validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var noteToUpdate = await _noteService.GetById(id);
            if (noteToUpdate == null)
                return NotFound();

            var note = _mapper.Map<SaveNoteDTO, Note>(saveNoteResource);
            await _noteService.Update(noteToUpdate, note);
            var updatedNote = await _noteService.GetById(id);
            var updatedNoteResource = _mapper.Map<Note, NoteDTO>(updatedNote);

            return Ok(updatedNoteResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote(int id)
        {
            if (id == 0) return BadRequest();
            
            var note = await _noteService.GetById(id);
            if (note == null) return NotFound();

            await _noteService.Delete(note);
            return NoContent();
        }
    }
}
