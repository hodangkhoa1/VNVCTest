using FluentValidation.Results;

namespace VNVC_BAL.Utils
{
    public class FunctionValidation
    {
        #region Get Error In Fluent Validation
        public static string GetErrorInFluentValidation(ValidationResult validationResult)
        {
            string errorMessage = "";

            if (!validationResult.IsValid)
            {
                if (validationResult.Errors.Count > 1)
                {
                    errorMessage = "Bắt buộc nhập tất cả các trường dữ liệu!";
                }
                else
                {
                    foreach (var failure in validationResult.Errors)
                    {
                        switch (failure.PropertyName)
                        {
                            case "ID":
                                errorMessage = failure.ErrorMessage;
                                break;
                            case "Email":
                                errorMessage = failure.ErrorMessage;
                                break;
                            case "FullName":
                                errorMessage = failure.ErrorMessage;
                                break;
                            case "PhoneNumber":
                                errorMessage = failure.ErrorMessage;
                                break;
                        }
                    }
                }
            }

            return errorMessage;
        }
        #endregion
    }
}
