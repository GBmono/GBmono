/*
    货架详细 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', '$routeParams', '$timeout', 'productDataFactory'];

    // create controller
    module.controller('shelfListController', ctrl);

    // controller body
    function ctrl($scope, $routeParams, $timeout, productDataFactory) {

        $scope.shelfDisplay = true;

        $scope.changeClass = function (shelf) {
            shelf.removeClass("flipInY").addClass("flipOutY");
        }

        $scope.changeDisplay = function () {
            $scope.shelfDisplay = !$scope.shelfDisplay;
        }

        $scope.displayToggle = function () {
            var shelf = angular.element(".shelf-bounce");
            if (shelf && shelf.length > 0) {
                $scope.changeClass(shelf);
                $timeout(function () { $scope.changeDisplay(); }, 1000);
            } else {
                $scope.changeDisplay();
            }            
        }

        

        $scope.loadProducts = function () {
            var categoryId = $routeParams.id;
            switch (categoryId) {
                case "weekly":
                    $scope.shelfTitle = "本周推荐货架";
                    break;
                case "season":
                    $scope.shelfTitle = "本季推荐货架";
                    break;
                case "brand":
                    $scope.shelfTitle = "品牌特设货架";
                    break;
                default:
                    break;
            }
            if (categoryId)
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