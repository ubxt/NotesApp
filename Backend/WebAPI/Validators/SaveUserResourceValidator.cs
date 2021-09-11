using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DTOs;

namespace WebAPI.Validators
{
    public class SaveUserResourceValidator : AbstractValidator<SaveUserDTO>
    {
        public SaveUserResourceValidator()
        {
            RuleFor(u => u.FirstName)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(u => u.LastName)
                .NotEmpty()
                .MaximumLength(50);
            RuleFor(u => u.Email)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}
