/*
   profile page controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', '$location', 'profileDataFactory', 'accountDataFactory', 'uiService', 'localStorageService'];

    // create controller
    module.controller('profilesController', ctrl);

    // controller body
    function ctrl($scope, $location, profileDataFactory, accountDataFactory, uiService, localStorageService) {
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
            // validate if current user is authenticated
            isAuthenticated();

            // enable tab
            tab();
        }

        function isAuthenticated() {
            // get the token from local storage
            var token = localStorageService.get(gbmono.LOCAL_STORAGE_TOKEN_KEY);

            // when user is not authenticated
            var returnUrl = getReturnUrl();

            // if token is null or empty
            if (!token || token === '') {                
                // redirect into login page with returnUrl
                $location.path('/login').search('returnUrl', returnUrl);
            }

            // call web method with token 
            accountDataFactory.isAuthenticated(token)
                .success(function (data) {
                    // user is authenticated
                    // show user name or display name 

                    // then show followed brands and products
                    
                })
                .error(function (error) {
                    // 401
                    // redirect into login page
                    $location.path('/login').search('returnUrl', returnUrl);
                });
        }

        function getReturnUrl() {
            // current url
            var url = window.location.href;
            // if current url contains any angularJs route
            if (url.indexOf('#') === -1) {
                // home page
                return '';
            } else {
                // extract the route if exists
                var index = url.indexOf('#') + 2;
                // failed to extract the route
                if (index >= url.length) {
                    return '';
                } else {
                    var returnUrl = url.substring(index);
                    console.log()
                    return returnUrl;
                }
            }
        }

        // enable tab
        function tab() {
            // prevent the default action
            uiService.tab();
        }
        // loadFollowProducts
        $scope.loadFollowProducts = function () {
            profileDataFactory.getFollowProducts().success(function (data) {
                $scope.followProducts = data;
            });
        }

        // loadFollowBrands
        $scope.loadFollowBrands = function () {
            profileDataFactory.getFollowBrands().success(function (data) {
                $scope.followBrands = data;
            });
        }

        // loadFavoriteProducts
        $scope.loadFavoriteProducts = function () {
            profileDataFactory.getFavoriteProducts().success(function (data) {
                $scope.favoriteProducts = data;
            });
        }

        

    }
})(angular.module('gbmono'));


/*
  login page controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope'];

    // create controller
    module.controller('loginController', ctrl);

    // controller body
    function ctrl($scope) {

        // call page init function
        init();

        // page init method
        function init() {
          
        }

    }
})(angular.module('gbmono'));

/*
  register page controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope'];

    // create controller
    module.controller('registerController', ctrl);

    // controller body
    function ctrl($scope) {

        // call page init function
        init();

        // page init method
        function init() {

        }

    }
})(angular.module('gbmono'));