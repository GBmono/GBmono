/*
    商品详细页 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', '$routeParams'];
    init();
    function init() {
        alert('details');
    }
    // create controller
    module.controller('productDetailController', ctrl);

    // controller body
    function ctrl($scope, $routeParams) {
        // get route param id from url
        var id = $routeParams.id ? parseInt($routeParams.id) : 0;
    }
})(angular.module('gbmono'));