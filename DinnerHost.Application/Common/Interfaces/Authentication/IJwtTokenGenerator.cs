using DinnerHost.Domain.Entities;

namespace DinnerHost.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}