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
    ctrl.$inject = ['$scope', 'categoryDataFactory', 'accountDataFactory', 'localStorageService'];

    // create controller
    module.controller('headerController', ctrl);
    // controller body
    function ctrl($scope, categoryDataFactory, accountDataFactory, localStorageService) {
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
        function login(model) {
            accountDataFactory.login(model.email, model.password)
                 .success(function (data) {
                     localStorageService.set(gbmono.LOCAL_STORAGE_TOKEN_KEY, data.access_token);
                 });
        }

        // register function
        function register(model) {
            accountDataFactory.register(model)
                 .success(function (data) {
                     login(model);
                 });
        }

        // event handlers
        $scope.register = function () {
            // use email as userName
            $scope.registerData.userName = $scope.registerData.email;
            // show model
            console.log($scope.registerData);
            register($scope.registerData);
        }


        $scope.login = function () {
            console.log($scope.loginData);
            login($scope.loginData);
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


