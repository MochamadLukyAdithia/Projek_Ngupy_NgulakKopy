using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Ngupy_NgulakKopy.Tools;
using Npgsql;
using Ngupy_NgulakKopy.Views.Petani;

namespace Ngupy_NgulakKopy.Models
{
    internal class UserContext
    {
        private User user;
        private List<TransaksiModel> listtransaksi;
        public UserContext()
        {
            user = new User();
        }

        public List<User> ReadUser()
        {
            return user.ReadUser();
        }

        public int Getid(string username)
        {
            return user.GetIdbyUsername(username);
        }

        public string Getnama(string username)
        {
            return user.GetnamaByusername(username);
        }
        
    }
}
