(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'retailDataFactory'];

    // create controller
    module.controller('retailsController', ctrl);

    // controller body
    function ctrl($scope, retailDataFactory) {
        $scope.allRetails = [];

        // call page init function
        init();
        // page init method
        function init() {
            loadRetails();
        }

        function loadRetails() {
            retailDataFactory.getAll().success(function (data) {
                $scope.allRetails = data;
            });
        }

       
    }

})(angular.module('gbmono'));