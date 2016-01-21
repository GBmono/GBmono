using Gbmono.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gbmono.WebAPI.Security.Identities;

namespace Gbmono.WebAPI.Models
{
    //public class UserProfileViewModel
    //{
    //    public int UserProfileId { get; set; }
    //    public string DisplayName { get; set; }
    //    public List<FollowOption> FollowProducts { get; set; }
    //    public List<FollowOption> FollowBrands { get; set; }
    //    public List<FollowOption> ProductCollections { get; set; }
    //}


    public class UserProfileViewModel
    {
        public UserProfile UserProfie { set; get; }
        public List<Product> FollowProducts { set; get; }
        public List<Product> ProductCollections { set; get; }
        public List<Brand> FollowBrands { set; get; }
    }
}