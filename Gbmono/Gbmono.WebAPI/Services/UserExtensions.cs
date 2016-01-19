using Gbmono.Models;
using Gbmono.Models.Infrastructure;
using Gbmono.WebAPI.Models;
using Gbmono.WebAPI.Security.Identities;
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

        public static IEnumerable<FollowOption> GetUserFollows(int userProfileId)
        {
            return RepositoryManager.FollowOptionRepository.Fetch(m => m.UserProfileId == userProfileId).ToList();
        }

        //TODO: get user profile view model
        
        public static UserProfileViewModel GetUserProfile(UserProfile userProfile)
        {
            var viewModel = new UserProfileViewModel();
            viewModel.UserProfileId = userProfile.UserProfileId;
            viewModel.DisplayName = userProfile.DisplayName;
            var followOptions = GetUserFollows(userProfile.UserProfileId);
            viewModel.FollowProducts = followOptions.Where(m => m.FollowTypeId == (int)FollowOptionType.FollowProduct).ToList();
            viewModel.FollowBrands = followOptions.Where(m => m.FollowTypeId == (int)FollowOptionType.FollowBrand).ToList();
            viewModel.ProductCollections = followOptions.Where(m => m.FollowTypeId == (int)FollowOptionType.ProductCollection).ToList();
            return viewModel;
        }
    }
}