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
        $scope.profiles = [];

        // call page init function
        init();
        // page init method
        // 当该view被初始化时 需要执行的功能
        function init() {
            loadProfiles();
        }

        // get products
        function loadProfiles() {
            var model = "";

            profileDataFactory.getMy(model).success(function (data) {
                $scope.profiles = data;
            });
       
        }

      
    }
})(angular.module('gbmono'));