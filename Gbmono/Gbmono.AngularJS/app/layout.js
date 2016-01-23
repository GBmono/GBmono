﻿/*
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
    ctrl.$inject = ['$scope', 'categoryDataFactory', 'accountDataFactory', 'brandDataFactory', 'localStorageService', 'userActionFactory'];

    // create controller
    module.controller('headerController', ctrl);
    // controller body
    function ctrl($scope, categoryDataFactory, accountDataFactory, brandDataFactory, localStorageService, userActionFactory) {
        // define scope variable here
        // login model
        $scope.loginData = {};
        // register model
        $scope.registerData = {};

        $scope.categories = [];
        $scope.brands = [];
        // call page init function
        init();

        // page init method
        // 当该view被初始化时 需要执行的功能
        function init() {
            loadCategories();
            loadBrands();
        }

        // get cateogry
        function loadCategories() {
            categoryDataFactory.getAll()
             .success(function (data) {
                 // success callback
                 // retreive the data into local array
                 // $scope.products can be accessed from the view
                 $scope.categories = data;
             });
        }

        function loadBrands() {
            brandDataFactory.getAll()
             .success(function (data) {
                 $scope.brands = data;
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

        $scope.follow = function (optionId, followTypeId) {
            var followOption = {
                optionId: optionId,
                followTypeId: followTypeId
            };
            userActionFactory.follow(followOption)
                .success(function (data) {
                    alert("Success");
                });
        };
    }

})(angular.module('gbmono'));

/*
   left menubar controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'categoryDataFactory'];

    // create controller
    module.controller('leftMenuBarController', ctrl);

    // controller body
    function ctrl($scope, categoryDataFactory) {
        // categories
        $scope.leftBarCategories = [];

        init();

        function init() {
            loadCategories();
        }

        function loadCategories() {
            categoryDataFactory.getAll()
             .success(function (data) {
                 console.log(data);
                 $scope.leftBarCategories = data;
             });
        }
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


