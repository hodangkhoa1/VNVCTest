using FluentValidation;
using VNVC_BAL.Models;

namespace VNVC_BAL.Validators
{
    public class AccountRequestValidator : AbstractValidator<AccountRequest>
    {
        public AccountRequestValidator()
        {
            RuleFor(u => u.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Bắt buộc nhập email!")
                .NotNull().WithMessage("Bắt buộc nhập email!")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Địa chỉ email không hợp lệ!");

            RuleFor(u => u.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Bắt buộc nhập tên riêng!")
                .NotNull().WithMessage("Bắt buộc nhập tên riêng!");

            RuleFor(u => u.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Bắt buộc nhập tên họ!")
                .NotNull().WithMessage("Bắt buộc nhập tên họ!");

            RuleFor(u => u.FullName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Bắt buộc nhập họ và tên!")
                .NotNull().WithMessage("Bắt buộc nhập họ và tên!");

            RuleFor(u => u.Birthday)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Bắt buộc nhập năm sinh!")
                .NotNull().WithMessage("Bắt buộc nhập năm sinh!");

            RuleFor(u => u.PhoneNumber)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Bắt buộc nhập số điện thoại!")
                .NotNull().WithMessage("Bắt buộc nhập số điện thoại!");

            RuleFor(u => u.Address)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Bắt buộc nhập địa chỉ!")
                .NotNull().WithMessage("Bắt buộc nhập địa chỉ!");
        }
    }
}
