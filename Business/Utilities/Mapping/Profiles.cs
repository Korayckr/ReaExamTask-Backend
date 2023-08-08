using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        //Users
        CreateMap<RegisterDto, User>();
        CreateMap<User, UserProfileDto>();
        CreateMap<UpdateUserDto, User>();
        

        //Tweets
        CreateMap<CreateTweetsDto, Tweets>();
        CreateMap<UpdateTweetsDto, Tweets>();
        CreateMap<Tweets, TweetsInfoDto>();

        //Followings
        CreateMap<CreateFollowingsDto, Followings>();
        CreateMap<UpdateFollowingsDto, Followings>();
        CreateMap<Followings, FollowingsInfoDto>();

        //Followers
        CreateMap<CreateFollowersDto, Followers>();
        CreateMap<UpdateFollowersDto, Followers>();
        CreateMap<Followers, FollowersInfoDto>();



    }
}