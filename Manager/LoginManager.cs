using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gateway;
using Model;

namespace Manager
{
    public class LoginManager
    {
        LoginGateway loginGateway = new LoginGateway();
        public bool GetLogInfo(LoginModel loginModel)
        {
            return loginGateway.LoginInfo(loginModel);
        }
    }
}
