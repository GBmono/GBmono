/*
   header block controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'categoryDataFactory', 'accountDataFactory'];

    // create controller
    module.controller('headerController', ctrl);
    // controller body
    function ctrl($scope, categoryDataFactory, accountDataFactory) {
        init();
        // page init method
        // 当该view被初始化时 需要执行的功能
        function init() {
            loadCategory();
        }

        // get products
        function loadCategory() {
            categoryDataFactory.getAll()
             .success(function (data) {
                 // success callback
                 // retreive the data into local array
                 // $scope.products can be accessed from the view
                 $scope.categories = data;
             });
        }


        $scope.register = function () {
            var userName = $scope.registerEmail;
            var password = $scope.registerPwd;
            var model = { userName: userName, password: password }
            accountDataFactory.register(model)
             .success(function (data) {
                 //todo store in localstorage
             });
        }


        $scope.login = function () {
            var userName = $scope.loginEmail;
            var password = $scope.loginPwd;
            accountDataFactory.login(userName, password)
             .success(function (data) {
                 //todo store in localstorage
             });
        }
      
    }

})(angular.module('gbmono'));
