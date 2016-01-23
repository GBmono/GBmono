/*
    商品详细页 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', '$routeParams', 'productDataFactory', 'bannerDataFactory'];
    
    // create controller
    module.controller('productDetailController', ctrl);

    // controller body
    function ctrl($scope, $routeParams, productDataFactory, bannerDataFactory) {

        var id = $routeParams.id ? parseInt($routeParams.id) : 0;

        init();

        function init() {
            GetProduct(id);
            GetProductBanner(id);
        }
        // get route param id from url
        
        function GetProduct(id) {
            productDataFactory.getById(id).success(function (data) {
                $scope.product = data;
            });
        }

        function GetProductBanner(id) {
            bannerDataFactory.getByProductId(id).success(function (data) {
                $scope.productBanner = data;
            });
        }
        

    }
})(angular.module('gbmono'));