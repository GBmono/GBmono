using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gbmono.EF;
using Gbmono.Models;

namespace Gbmono.WebAPI.Security.Identities
{
    public class IdentityRepositoryManager
    {
        public GBmonoUserDbContext Context { get; private set; }

        public IdentityRepositoryManager()
        {
            Context = new GBmonoUserDbContext(); // create new instance of sql context with default settings
        }


        private IRepository<UserProfile> _userProfileRepository;
        private IRepository<GbmonoUser> _gbmonoUserRepository;

        public IRepository<UserProfile> UserProfileRepository
        {
            get { return _userProfileRepository ?? (_userProfileRepository = new Repository<UserProfile>(Context)); }
        }

        public IRepository<GbmonoUser> GbmonoUserRepository
        {
            get { return _gbmonoUserRepository ?? (_gbmonoUserRepository = new Repository<GbmonoUser>(Context)); }
        }
    }
}