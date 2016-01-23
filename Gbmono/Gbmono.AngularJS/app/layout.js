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

        $scope.loginStatus = {
           loginFlag : false
        };
        // call page init function
        init();

        // page init method
        // 当该view被初始化时 需要执行的功能
        function init() {
            loadloginStatus();
            loadCategories();
            loadBrands();
        }

        function loadloginStatus() {
            var token = localStorageService.get(gbmono.LOCAL_STORAGE_TOKEN_KEY);
            var displayName = localStorageService.get(gbmono.LOCAL_STORAGE_USER_KEY);
            if (token != null && displayName!=null) {
                $scope.loginStatus.loginFlag = true;
                $scope.loginStatus.token = token;
                $scope.loginStatus.displayName = displayName;
            }
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
                     localStorageService.set(gbmono.LOCAL_STORAGE_USER_KEY, data.displayName);
                     alert(data.displayName);
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
            register($scope.registerData);
        }


        $scope.login = function () {
            login($scope.loginData);
        }

        $scope.logout = function () {
            localStorageService.remove(gbmono.LOCAL_STORAGE_TOKEN_KEY, gbmono.LOCAL_STORAGE_USER_KEY);
            loadloginStatus();
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

        // get all categories data
        function loadCategories() {
            categoryDataFactory.getAll()
             .success(function (data) {
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


