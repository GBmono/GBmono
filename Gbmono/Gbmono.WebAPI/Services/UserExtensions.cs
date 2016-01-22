using Gbmono.Models;
using Gbmono.Models.Infrastructure;
using Gbmono.WebAPI.Models;
using Gbmono.WebAPI.Security.Identities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                    _repositoryManager = new RepositoryManager();

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
            viewModel.UserProfie = userProfile;
            var followOptions = GetUserFollows(userProfile.UserProfileId);
            viewModel.FollowBrands = new List<Brand>();
            viewModel.FollowProducts = new List<Product>();
            viewModel.ProductCollections = new List<Product>();

            //var brandIdList = new int[] {1, 2, 3};
            //_repositoryManager.BrandRepository.Table.Where(m => brandIdList.Contains(m.BrandId));

            foreach (var follow in followOptions)
            {
                switch (follow.FollowTypeId)
                {
                    case (int)FollowOptionType.FollowBrand:
                        var brand = _repositoryManager.BrandRepository.Get(m => m.BrandId == follow.OptionId);
                        viewModel.FollowBrands.Add(brand);
                        break;
                    case (int)FollowOptionType.FollowProduct:
                        var followProduct = _repositoryManager.ProductRepository.Table.Include(m => m.Retailers).Single(m => m.ProductId == follow.OptionId);
                        //Todo Temp
                        if (followProduct.Images == null)
                        {
                            followProduct.Images = new List<ProductImage>();
                            followProduct.Images.Add(new ProductImage() { IsPrimary = true, IsThumbnail = false, Name = "PicTemp", Url = "/content/images/demo/merries2_f.jpg" });
                            followProduct.Images.Add(new ProductImage()
                            {
                                IsPrimary = false,
                                IsThumbnail = false,
                                Name = "PicTemp2",
                                Url = "/content/images/demo/merries2_b.jpg"
                            });
                        }
                        viewModel.FollowProducts.Add(followProduct);
                        break;
                    case (int)FollowOptionType.FavoriteProduct:
                        var productCollection = _repositoryManager.ProductRepository.Table.Include(m => m.Retailers).Single(m => m.ProductId == follow.OptionId);
                        //Todo Temp
                        if (productCollection.Images == null)
                        {
                            productCollection.Images = new List<ProductImage>();
                            productCollection.Images.Add(new ProductImage() { IsPrimary = true, IsThumbnail = false, Name = "PicTemp", Url = "/content/images/demo/merries2_f.jpg" });
                            productCollection.Images.Add(new ProductImage()
                            {
                                IsPrimary = false,
                                IsThumbnail = false,
                                Name = "PicTemp2",
                                Url = "/content/images/demo/merries2_b.jpg"
                            });
                        }
                        viewModel.ProductCollections.Add(productCollection);
                        break;
                }
            }
            return viewModel;
        }
    }
}