using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplom.ViewModels
{
    public class LoginViewModel
    {
        public string UserName {get;set;}
        public string Password { get; set; }
        public string grant_type { get; set; }
    }
}