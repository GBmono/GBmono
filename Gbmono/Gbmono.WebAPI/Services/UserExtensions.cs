using Gbmono.Models;
using Gbmono.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gbmono.WebAPI.Services
{
    public static class UserExtensions
    {
        private static RepositoryManager _repositoryManager;
        public static RepositoryManager RepositoryManager
        {
            get
            {
                if (_repositoryManager == null)
                {
                    _repositoryManager= new RepositoryManager();
                    
                }
                return _repositoryManager;
            }
        }

        public static IEnumerable<FollowOption> GetUserFollows(Guid userId)
        {
            return RepositoryManager.FollowOptionRepository.Fetch(m => m.UserId == userId).ToList();
        }

        //TODO: get user profile view model
        //public static UserProfileViewModel GetUserProfile(Guid userId){}
    }
}