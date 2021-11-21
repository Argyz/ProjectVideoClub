using Data;
using Entity.secondary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceLogin
{
    public class LoginService
    {
        private string _username;
        private string _password;
        private bool _isLoggedIn;
        public bool Acceder(string usuario,string pass) 
        {
            _username = usuario;
            _password = Encrypt.GetSHA256(pass); 
            using (var ctx=new VideoContext())
            {
                var user = ctx.Users.Where(x => x.UserName == _username && x.Password == _password).FirstOrDefault();

                if (user != null)
                {
                    _isLoggedIn = true;
                }
                else
                {
                    _isLoggedIn = false;
                }
            }

            return _isLoggedIn;
        }
    }
}
