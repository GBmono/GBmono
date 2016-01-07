/*
   商品列表页 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope'];

    // create controller
    module.controller('commodityListController', ctrl);

    // controller body
    function ctrl($scope) {

        $scope.test= function() {
            alert("Test Allen");
        }


    }
})(angular.module('gbmono'));


/*
   商品详细页 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', '$routeParams'];

    // create controller
    module.controller('commodityDetailController', ctrl);

    // controller body
    function ctrl($scope, $routeParams) {
        // get route param id from url
        var id = $routeParams.id ? parseInt($routeParams.id) : 0;
    }
})(angular.module('gbmono'));