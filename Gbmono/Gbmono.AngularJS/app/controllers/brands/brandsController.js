
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'brandDataFactory', 'userActionFactory'];

    // create controller
    module.controller('brandsController', ctrl);

    // controller body
    function ctrl($scope, brandDataFactory, userActionFactory) {
        $scope.allBrands = [];

        // call page init function
        init();
        // page init method
        function init() {
            loadBrands();
        }

        function loadBrands() {
            brandDataFactory.getAll().success(function(data) {
                $scope.allBrands = data;
            });
        }

        $scope.followbrand = function (optionId) {
            var followOption = {
                optionId: optionId,
                followTypeId: gbmono.follow_type.followBrand
            };
            userActionFactory.follow(followOption)
                .success(function (data) {
                    alert("Follow Successed");
                });
        };
    }

})(angular.module('gbmono'));