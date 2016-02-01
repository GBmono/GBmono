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
    ctrl.$inject = ['$scope', 'categoryDataFactory', 'accountDataFactory', 'brandDataFactory', 'localStorageService'];

    // create controller
    module.controller('headerController', ctrl);
    // controller body
    function ctrl($scope, categoryDataFactory, accountDataFactory, brandDataFactory, localStorageService) {
        // define scope variable here
        // indicate if current user is authenticated
        $scope.currentUser = {
            isAuthenticated : false
        };

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
            // indicate if current user is authenticated
            isAuthenticated();

            // load data
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
                     // save user token
                     localStorageService.set(gbmono.LOCAL_STORAGE_TOKEN_KEY, data.access_token);
                     // console.log(data);
                     // current user object
                     $scope.currentUser = {
                         isAuthenticated: true,
                         userName: data.userName,
                         displayName: data.displayName
                     };
                 })
                 .error(function (error) {
                     alert('Login failed.');
                     //console.log(error);
                 });
        }

        // register function
        function register(model) {
            accountDataFactory.register(model)
                 .success(function (data) {
                     login(model);
                 });
        }

        // get user status
        function isAuthenticated() {
            // get the token from local storage
            var token = localStorageService.get(gbmono.LOCAL_STORAGE_TOKEN_KEY);

            // if token is null or empty
            if(!token || token === ''){
                return;
            }

            // call web method with token 
            accountDataFactory.isAuthenticated(token)
                .success(function (data) {
                    // user is authenticated
                    // save user name or display name 
                    $scope.currentUser = {
                        isAuthenticated: true,
                        userName: data.userName,
                        displayName: data.displayName,
                        email : data.email
                    };
                })
                .error(function (error) {
                    console.log(error);
                    $scope.currentUser = {
                        isAuthenticated: false,
                    };
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
            // clear token
            localStorageService.remove(gbmono.LOCAL_STORAGE_TOKEN_KEY);
            // reset current user
            $scope.currentUser = {
                isAuthenticated: false,
            };
        }

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
    product filter controller
*/
(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', '$routeParams', 'categoryDataFactory'];
    // create controller
    module.controller('productFilterController', ctrl);

    // controller body
    function ctrl($scope, $routeParams, categoryDataFactory) {

        init();

        function init() {
            getFilterCategories($routeParams.id);
        }
        
        // get filter categories
        function getFilterCategories(categoryId) {
            categoryDataFactory.getFilterCategories(categoryId)
                                .success(function (data) {
                                    $scope.filterCategories = data;
                                });

        };
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


