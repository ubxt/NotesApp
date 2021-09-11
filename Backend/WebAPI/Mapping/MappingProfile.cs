using AutoMapper;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;

namespace WebAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<Note, NoteDTO>();
         
            CreateMap<SaveUserDTO, User>();
            CreateMap<SaveNoteDTO, Note>();
        }
    }
}
