using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public int FollowingId { get; set; } = default!;
    public UserType UserType { get; set; }

    public ICollection<Tweets> Tweets { get; set; }
    public ICollection<Followers> Followers { get; set; }
    public ICollection<Followings> Followings { get; set; }



}


public enum UserType
{
    Admin,
    User,
}