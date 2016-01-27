// factory class that handles CURD calls to the REST service
// factories are singletons by default so the object returned by the factory can be re-used over and over by different controllers in the application. 
// While AngularJS services can also be used to perform this type of functionality, a service returns an instance of itself (it’s also a singleton) and uses the “this” keyword as a result. 
// Factories on the other hand are free to create their own objects inside of the factory function and return them. 

/* sample data factory */
// create root level app module
// it seems it changes since the version 1.2.3
// it has to reference the angular-route.js file and define the controllers parameter
// define angularJs module
(function () {
    // inject the parameters
    config.$inject = ['$routeProvider', '$httpProvider', '$sceDelegateProvider'];


    // config
    // ng-route, ng-animate, kendo-ui modules
    angular.module('gbmono', ['ngRoute', 'ngAnimate', 'LocalStorageModule']).config(config);

    // module config
    // config route & http
    function config($routeProvider, $httpProvider, $sceDelegateProvider) {
        // inject authentication interceptor
        // bearer token authentication
        // $httpProvider
        // $httpProvider.interceptors.push('authInterceptor');

        // configure routes
        $routeProvider
                .when('/', { // home page
                    templateUrl: gbmono.app_view_path + '/home/home.html',
                    controller: 'homeController',
                    caseInsensitiveMatch: true
                })
                .when('/products', { // 商品列表页
                    templateUrl: gbmono.app_view_path + '/products/list.html',
                    controller: 'productListController',
                    caseInsensitiveMatch: true
                })
                .when('/categories/:id/products/', { // 商品列表页
                    templateUrl: gbmono.app_view_path + '/products/list.html',
                    controller: 'productListController',
                    caseInsensitiveMatch: true
                })                
                .when('/categories', { // 所有品类
                    templateUrl: gbmono.app_view_path + '/categories/allcategories.html',
                    controller: 'categoriesController',
                    caseInsensitiveMatch: true
                })
                .when('/shelves', { //所有品类货架
                    templateUrl: gbmono.app_view_path + '/shelves/all.html',
                    controller: 'shelfListController',
                    caseInsensitiveMatch: true
                })
                .when('/shelves/:id', { //单个品类货架
                    templateUrl: gbmono.app_view_path + '/shelves/single.html',
                    controller: 'shelfListController',
                    caseInsensitiveMatch: true
                })
                .when('/shelves/weekly', { //本周推荐货架页
                    templateUrl: gbmono.app_view_path + '/shelves/single.html',
                    controller: 'shelfListController',
                    caseInsensitiveMatch: true
                })
                .when('/shelves/season', { //当季推荐货架页
                    templateUrl: gbmono.app_view_path + '/shelves/single.html',
                    controller: 'shelfListController',
                    caseInsensitiveMatch: true
                })
                .when('/shelves/brand', { //品牌特设货架页
                    templateUrl: gbmono.app_view_path + '/shelves/single.html',
                    controller: 'shelfListController',
                    caseInsensitiveMatch: true
                })
                .when('/products/:id', { // 商品详细页
                    templateUrl: gbmono.app_view_path + '/products/detail.html',
                    controller: 'productDetailController',
                    caseInsensitiveMatch: true
                })
                .when('/special', { // 特色货架
                    templateUrl: gbmono.app_view_path + '/products/special.html',
                    controller: 'productSpecialController',
                    caseInsensitiveMatch: true
                })
                .when('/brands', { // 所有品牌
                    templateUrl: gbmono.app_view_path + '/brands/allbrands.html',
                    controller: 'brandsController',
                    caseInsensitiveMatch: true
                })                
                .when('/profiles', { // 个人中心
                    templateUrl: gbmono.app_view_path + '/accounts/profile.html',
                    controller: 'profilesController',
                    caseInsensitiveMatch: true
                })
                .when('/login', { // 登陆
                    templateUrl: gbmono.app_view_path + '/accounts/login.html',
                    controller: 'loginController',
                    caseInsensitiveMatch: true
                })
                .when('/register', { // 注册
                    templateUrl: gbmono.app_view_path + '/accounts/register.html',
                    controller: 'registerController',
                    caseInsensitiveMatch: true
                })
               .when('/retailers', { // 注册
                   templateUrl: gbmono.app_view_path + '/retailers/allretailers.html',
                   controller: 'retailersController',
                   caseInsensitiveMatch: true
               })
                .otherwise({
                    templateUrl: gbmono.app_view_path + '/home/home.html',
                    controller: 'homeController',
                    caseInsensitiveMatch: true
                });

        $sceDelegateProvider.resourceUrlWhitelist([
       // Allow same origin resource loads.
       'self',
       // Allow loading from our assets domain.  Notice the difference between * and **.
       'http://player.youku.com/**']);


    }


})();

