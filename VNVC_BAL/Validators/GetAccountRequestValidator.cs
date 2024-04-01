using FluentValidation;
using VNVC_BAL.Models;

namespace VNVC_BAL.Validators
{
    public class GetAccountRequestValidator : AbstractValidator<GetAccountRequest>
    {
        public GetAccountRequestValidator()
        {
            RuleFor(u => u.PhoneNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Bắt buộc nhập số điện thoại!")
                .NotNull().WithMessage("Bắt buộc nhập số điện thoại!");
        }
    }
}
