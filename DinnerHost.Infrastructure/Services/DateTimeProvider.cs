using DinnerHost.Application.Common.Interfaces.Services;

namespace DinnerHost.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
