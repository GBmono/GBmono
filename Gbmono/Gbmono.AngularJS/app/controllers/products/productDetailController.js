/*
    商品详细页 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', '$routeParams', 'productDataFactory'];
    
    // create controller
    module.controller('productDetailController', ctrl);

    // controller body
    function ctrl($scope, $routeParams, productDataFactory) {

        var id = $routeParams.id ? parseInt($routeParams.id) : 0;

        init();

        function init() {
            GetProduct(id);
        }
        // get route param id from url
        
        function GetProduct(id) {
            productDataFactory.getById(id).success(function (data) {
                $scope.product = data;
            });
        }
        

    }
})(angular.module('gbmono'));