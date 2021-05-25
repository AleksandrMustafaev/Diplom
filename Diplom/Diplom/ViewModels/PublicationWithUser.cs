using Diplom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplom.ViewModels
{
    public class PublicationWithUser
    {
        public PublicationModels Publication { get; set; }
        public ApplicationUser User { get; set; }
    }
}