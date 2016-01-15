/*
   商品列表页 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', '$routeParams', 'productDataFactory'];

    module.controller('productListController', ctrl);

    // create controller
    // controller body
    function ctrl($scope, $routeParams, productDataFactory) {
        init();

        
        function init() {
            loadProducts();
        }

        // get products
        function loadProducts() {
            var categoryId = $routeParams.id ? parseInt($routeParams.id) : 0;
            // call web api
            if (categoryId == 0 ) {
                productDataFactory.getAll()
                    .success(function(data) {
                        // success callback
                        // retreive the data into local array
                        // $scope.products can be accessed from the view
                        $scope.products = data;
                    });
            } else {
                productDataFactory.getByCategory(categoryId)
                    .success(function (data) {
                        // success callback
                        // retreive the data into local array
                        // $scope.products can be accessed from the view
                        $scope.products = data;
                    });
            }
        }


    }
})(angular.module('gbmono'));