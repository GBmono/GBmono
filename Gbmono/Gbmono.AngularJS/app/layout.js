/*
    layout controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope'];

    // create controller
    module.controller('layoutController', ctrl);

    // controller body
    function ctrl($scope) {

    }
})(angular.module('gbmono'));


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
        // define scope variable here
        // login model
        $scope.loginData = {};
        // register model
        $scope.registerData = {};

        // call page init function
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

        // put web api in seperate function
        // login function
        function login(userName, password) {
            accountDataFactory.login(userName, password)
                 .success(function (data) {
                     //todo store in localstorage
                 });
        }

        // register function
        function register(model) {
            accountDataFactory.register(model)
                 .success(function (data) {
                     //todo store in localstorage
                 });
        }

        // event handlers
        $scope.register = function () {
            // use email as userName
            $scope.registerData.userName = $scope.registerData.email;
            // show model
            console.log($scope.registerData)
        }


        $scope.login = function () {
            console.log($scope.loginData);
        }
    }

})(angular.module('gbmono'));

/*
   left menubar controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope'];

    // create controller
    module.controller('leftMenuBarController', ctrl);

    // controller body
    function ctrl($scope) {


    }

})(angular.module('gbmono'));


/*
   footer block controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope'];

    // create controller
    module.controller('footerController', ctrl);

    // controller body
    function ctrl($scope) {

    }
})(angular.module('gbmono'));


/*
   newsletter block controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope'];

    // create controller
    module.controller('newsletterController', ctrl);

    // controller body
    function ctrl($scope) {

    }
})(angular.module('gbmono'));


