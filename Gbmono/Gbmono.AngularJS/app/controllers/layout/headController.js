/*
   header block controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'categoryDataFactory'];

    // create controller
    module.controller('headerController', ctrl);
    // controller body
    function ctrl($scope, categoryDataFactory) {
        init();
        // page init method
        // 当该view被初始化时 需要执行的功能
        function init() {
            loadCategory();
        }

        // get products
        function loadCategory() {
            categoryDataFactory.getCategories()
             .success(function (data) {
                 // success callback
                 // retreive the data into local array
                 // $scope.products can be accessed from the view
                 $scope.categories = data;
             });
        }
    }
})(angular.module('gbmono'));
