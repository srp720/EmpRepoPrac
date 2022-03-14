using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using EmployeeBE.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBE.Controllers
{
  
    public class BaseController : ControllerBase
    {
        #region ' Variable Declaration '

        private UserManager<AppUser> _userManager;
        private IHttpContextAccessor _accessor;
        #endregion ' Variable Declaration '

        #region ' Properties '
        public Microsoft.AspNetCore.Identity.UserManager<AppUser> UserManager
        {
            get
            {
                return _userManager;
            }
        }
        public string CurrentUserName
        {
            get
            {
                return this.User == null ? null : this.User.Identity.Name;
            }
        }
        public bool IsAuthenticated
        {
            get
            {
                return User.Identity.IsAuthenticated;
            }
        }
        public string EmpId
        {
            get
            {
                if (User == null) return null;
                var user = User.Identity.Name;
                return user;
            }
        }

        public string IpAddress
        {
            get
            {
                var ip = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
                return ip;
            }
        }
        #endregion ' Properties '
    }
}
