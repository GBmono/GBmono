/*
   品牌商默认页 controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', '$routeParams'];

    // create controller
    module.controller('manufacturerController', ctrl);

    // controller body
    function ctrl($scope, $routeParams) {
        // get route param id from url
        var id = $routeParams.id ? parseInt($routeParams.id) : 0;
    }
})(angular.module('gbmono'));