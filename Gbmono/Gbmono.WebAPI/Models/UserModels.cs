using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Gbmono.Models;

namespace Gbmono.WebAPI.Models
{
    // this class can be deleted
    public class UserProfileViewModel
    {
        public List<Product> FollowProducts { set; get; }
        public List<Product> ProductCollections { set; get; }
        public List<Brand> FollowBrands { set; get; }
    }

    /// <summary>
    /// user register binding model
    /// </summary>
    public class UserBindingModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Email { get; set; }
    }

    /// <summary>
    /// current gbmonu user
    /// </summary>
    public class CurrentUser
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
    }
}