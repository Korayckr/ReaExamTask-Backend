using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Request.Update;

public class UpdateUserDto
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public int FollowingId { get; set; } = default!;
}