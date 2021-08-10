using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators.FluentValidation
{
    public class BranchValidator:AbstractValidator<Branch>
    {
        public BranchValidator()
        {
            RuleFor(b => b.BranchName).NotEmpty().WithMessage("please enter branch name").NotNull();
        }
    }
}
