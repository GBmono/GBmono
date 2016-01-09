/*
   商品列表页 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope'];

    // create controller
    module.controller('productListController', ctrl);
    init();
    function init() {
        alert('list');
    }
    // controller body
    function ctrl($scope) {
        
        $scope.test = function () {
            alert("Test Allen");
        }


    }
})(angular.module('gbmono'));