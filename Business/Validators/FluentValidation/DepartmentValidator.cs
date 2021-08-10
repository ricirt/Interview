using Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators.FluentValidation
{
    public class DepartmentValidator:AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(d => d.DepartmentName).NotEmpty().WithMessage("Please enter department name");
            RuleFor(d => d.BranchId).NotEmpty().WithMessage("Please select your branch name");

        }
    }
}
