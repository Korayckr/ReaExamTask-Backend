using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class TweetsController : BaseCRUDController<Tweets, int, CreateTweetsDto, UpdateTweetsDto, TweetsInfoDto>
    {
        public TweetsController(ITweetsService service) : base(service)
        {
        }
    }
}
