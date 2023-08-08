using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }

    ITweetsRepository Tweets { get; }

    IFollowersRepository Followers { get; }

    IFollowingsRepository Followings { get; }

    Task<int> CommitAsync();
}