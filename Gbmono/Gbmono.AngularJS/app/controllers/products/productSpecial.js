/*
  product special controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'uiService'];

    // create controller
    module.controller('productSpecialController', ctrl);

    // controller body
    function ctrl($scope, uiService) {

        // call page init function
        init();

        // page init method
        function init() {
            uiService.carousel();
        }

    }
})(angular.module('gbmono'));