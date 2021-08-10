using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotEmpty().WithMessage("Please enter mail");
            RuleFor(u => u.Name).NotEmpty().WithMessage("Please enter name");
            RuleFor(u => u.Surname).NotEmpty().WithMessage("Please enter surname").NotNull();
            RuleFor(u => u.Phone).NotEmpty().WithMessage("Please enter phone number");
            RuleFor(u => u.BranchId).NotEmpty().WithMessage("Please select your branch");
        }
    }
}
