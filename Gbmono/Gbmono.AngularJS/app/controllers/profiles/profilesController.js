/*
   home page controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'profileDataFactory'];

    // create controller
    module.controller('profilesController', ctrl);

    // controller body
    function ctrl($scope, profileDataFactory) {
        // product list
        $scope.userInfo = [];
        $scope.followProducts = [];
        $scope.followBrands = [];
        $scope.favoriteProducts = [];

        // call page init function
        init();
        // page init method
        // 当该view被初始化时 需要执行的功能
        function init() {
            loadUserInfo();
            loadFollowProducts();
            loadFollowBrands();
            loadFavoriteProducts();
        }

        // loadUserInfo
        function loadUserInfo() {
            profileDataFactory.get().success(function (data) {
                $scope.userInfo = data;
            });
        }

        // loadFollowProducts
        function loadFollowProducts() {
            profileDataFactory.getFollowProducts().success(function (data) {
                $scope.followProducts = data;
            });
        }
        // loadFollowBrands
        function loadFollowBrands() {
            profileDataFactory.getFollowBrands().success(function (data) {
                $scope.followBrands = data;
            });
        }
        // loadFavoriteProducts
        function loadFavoriteProducts() {
            profileDataFactory.getFavoriteProducts().success(function (data) {
                $scope.favoriteProducts = data;
            });
        }


        // update userInfo
        $scope.updateUserInfo = function () {
            profileDataFactory.update($scope.userInfo).success(function (data) {
                alert("success");
            });
        }


    }
})(angular.module('gbmono'));