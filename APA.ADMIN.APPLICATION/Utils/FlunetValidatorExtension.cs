using FluentValidation;

namespace APA.ADMIN.APPLICATION.Utils
{
    public static class FlunetValidatorExtension
    {
        public static IRuleBuilder<T, string> PasswordForAdmin<T>(this IRuleBuilder<T, string> ruleBuilder,
            int minimumLength = 14)
        {
            var options = ruleBuilder
                .NotEmpty().NotNull().WithMessage("password must not empty")
                .MinimumLength(minimumLength)
                .Matches("[A-Z]").WithMessage("At least One uppercase latter")
                .Matches("[a-z]").WithMessage("At least One lowercase latter")
                .Matches("[0-9]").WithMessage("At least One digit")
                .Matches("[^a-zA-Z0-9]").WithMessage("At least one special character");
            return options;
        }
    }
}