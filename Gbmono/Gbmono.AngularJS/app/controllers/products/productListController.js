/*
   商品列表页 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'productListFactory'];

    module.controller('productListController', ctrl);

    // create controller
   // controller body
    function ctrl($scope, productListFactory) {
        init();

        function init() {
            loadProducts();
        }

        // get products
        function loadProducts() {
            debugger;
            // call web api
            productListFactory.getProductList()
                .success(function (data) {
                    // success callback
                    // retreive the data into local array
                    // $scope.products can be accessed from the view
                    debugger;
                    $scope.products = data;
                });
        }



        $scope.test = function () {
            alert("Test Allen");
        }


    }
})(angular.module('gbmono'));