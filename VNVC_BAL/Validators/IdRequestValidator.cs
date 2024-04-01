using FluentValidation;
using VNVC_BAL.Models;

namespace VNVC_BAL.Validators
{
    public class IdRequestValidator : AbstractValidator<IdRequest>
    {
        public IdRequestValidator()
        {
            RuleFor(u => u.ID)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("ID is required!")
                .NotNull().WithMessage("ID is required!");
        }
    }
}
