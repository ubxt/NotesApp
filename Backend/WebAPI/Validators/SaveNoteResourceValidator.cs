using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;

namespace WebAPI.Validators
{
    public class SaveNoteResourceValidator : AbstractValidator<SaveNoteDTO>
    {
        public SaveNoteResourceValidator()
        {
            RuleFor(n => n.Title)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}
