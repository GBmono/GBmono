/*
    货架详细 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', '$routeParams', 'productDataFactory'];

    // create controller
    module.controller('shelfListController', ctrl);

    // controller body
    function ctrl($scope, $routeParams, productDataFactory) {

        $scope.initBxslider = function () {
            $('.bxslider').bxSlider();
        }
        
        $scope.shelfDisplay = true;

        $scope.displayToggle = function () {
            $scope.shelfDisplay = !$scope.shelfDisplay;
        }

        $scope.loadProducts = function () {
            var categoryId = $routeParams.id ? parseInt($routeParams.id) : 0;
            
            productDataFactory.getAll()
                    .success(function (data) {
                        // success callback
                        // retreive the data into local array
                        // $scope.products can be accessed from the view
                        $scope.products = data;
                    });

            //// call web api
            //if (categoryId == 0) {
            //    productDataFactory.getAll()
            //        .success(function (data) {
            //            // success callback
            //            // retreive the data into local array
            //            // $scope.products can be accessed from the view
            //            $scope.products = data;
            //        });
            //} else {
            //    productDataFactory.getByCategory(categoryId)
            //        .success(function (data) {
            //            // success callback
            //            // retreive the data into local array
            //            // $scope.products can be accessed from the view
            //            $scope.products = data;
            //        });
            //}
        }
    }
})(angular.module('gbmono'));