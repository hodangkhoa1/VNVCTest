using FluentValidation;
using VNVC_BAL.Models;

namespace VNVC_BAL.Validators
{
    public class UserLotteryRequestValidator : AbstractValidator<UserLotteryRequest>
    {
        public UserLotteryRequestValidator()
        {
            RuleFor(u => u.Slot)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Bắt buộc chọn slot!")
                .NotNull().WithMessage("Bắt buộc chọn slot!");

            RuleFor(u => u.Result)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Bắt buộc nhập số đặt cược!")
                .NotNull().WithMessage("Bắt buộc nhập số đặt cược!");
        }
    }
}
