/*
   商品列表页 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'productDataFactory'];

    module.controller('productListController', ctrl);

    // create controller
   // controller body
    function ctrl($scope, productDataFactory) {
        init();

        function init() {
            loadProducts();
        }

        // get products
        function loadProducts() {
            // call web api
            productDataFactory.getProductList()
                .success(function (data) {
                    // success callback
                    // retreive the data into local array
                    // $scope.products can be accessed from the view
                    $scope.products = data;
                });
        }



        $scope.test = function () {
            alert("Test Allen");
        }


    }
})(angular.module('gbmono'));