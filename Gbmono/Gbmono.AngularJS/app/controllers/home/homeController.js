/*
   home page controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'productDataFactory'];

    // create controller
    module.controller('homeController', ctrl);

    // controller body
    function ctrl($scope, productDataFactory) {
        // product list
        $scope.products = [];

        // call page init function
        init();
        // page init method
        // 当该view被初始化时 需要执行的功能
        function init() {
            loadProducts();
        }

        // get products
        function loadProducts() {
            // call web api
            //productDataFactory.getProductList()
            //    .success(function (data) {
            //        // success callback
            //        // retreive the data into local array
            //        // $scope.products can be accessed from the view
            //        $scope.products = data;
            //    });
        }
    }
})(angular.module('gbmono'));