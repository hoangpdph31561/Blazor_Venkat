using EmployeeManagerment.API.ViewModel;
using FluentValidation;

namespace EmployeeManagerment.API.Fluent_Validation
{
    public class EmployeeViewModelValidation : AbstractValidator<EmployeeViewModel>
    {
        public EmployeeViewModelValidation()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName is needed to be fill").MinimumLength(2).WithMessage("Too short").MaximumLength(200).WithMessage("too long").Matches(@"^[\w\s\D]+$").WithMessage("FirstNamr regex wrong");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName is needed to be fill").MinimumLength(2).WithMessage("Too short").MaximumLength(200).WithMessage("too long").Matches(@"^[\w\D]+$").WithMessage("LastName regex wrong");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                .WithMessage("Email format not match");
            RuleFor(x => x.DateOfBirth).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Birthday cannot greater than 100 years");
        }
    }
}
