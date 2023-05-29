using ErrorOr;

namespace DinnerHost.Domain.Common.Errors;

public partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Validation(
            code: "Auth.InvalidCredentials",
            description: "Invalid Credentials");
    }
}