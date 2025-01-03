using Base.Interfaces;
using Base.Models;
using Base.Services;
using BaseApi.Extensions;
using BaseApi.Services;

namespace TplMvc.Services
{
    public class MyBaseUserSvc : IBaseUserSvc
    {
        //get base user info
        public BaseUserDto GetData()
        {
            return _Http.CookieToBr();
        }
    }
}
