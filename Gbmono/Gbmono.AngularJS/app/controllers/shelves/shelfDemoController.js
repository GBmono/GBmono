/*
    货架 demo controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', '$timeout'];

    // create controller
    module.controller('shelfDemoController', ctrl);

    // controller body
    function ctrl($scope, $timeout) {

        // page init
        init();

        function init() {
            $("#mybook").booklet({
                width:  '95%',
                height: 650,
                pageNumbers: false
                //tabs:  true,
                //tabWidth:  180,            
                //tabHeight:  20
            });
        }
    }
})(angular.module('gbmono'));