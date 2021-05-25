using Diplom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplom.ViewModels
{
    public class PublicationWithUser
    {
        public virtual IEnumerable<PublicationModels> publications { get; set; }
        public List<ApplicationUser> Users { get; set; }
    }
}