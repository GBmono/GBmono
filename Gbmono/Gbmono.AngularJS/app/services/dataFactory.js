﻿/*
 account data factory
*/
(function (module) {
    // inject params
    factory.$inject = ['$http'];

    // create instance
    module.factory('accountDataFactory', factory);

    // factory implement
    function factory($http) {
        // return data factory with CRUD calls
        return {
            register: register,
            login: login
        }

        // register user
        function register(model) {
            return $http.post(gbmono.api_site_prefix.account_api_url + '/Register', model);
        }

        // login, get access bearer token
        function login(userName, password) {
            // user name and password is posted as 'application/x-www-form-urlencoded'
            return $http({
                url: gbmono.api_token_url,
                method: 'POST',
                data: "userName=" + userName + "&password=" + password + "&grant_type=password",
                headers: {
                    'content-type': 'application/x-www-form-urlencoded'
                }
            });
        }
    }
})(angular.module('gbmono'));

/*
 user action factory
*/
(function (module) {
    factory.$inject = ['$http'];
    module.factory('userActionFactory', factory);
    function factory($http) {
        return {
            follow: follow,
        }

        function follow(model) {
            return $http.post(gbmono.api_site_prefix.follow_options_url + '/follow', model);
        }
    }
})(angular.module('gbmono'));


/*
 profile data factory
*/
(function (module) {
    // inject params
    factory.$inject = ['$http'];

    // create instance
    module.factory('profileDataFactory', factory);

    // factory implement
    function factory($http) {
        // return data factory with CRUD calls
        return {
            get: get,
            update: update
        }

        //Get my profile 
        function get() {
            return $http.get(gbmono.api_site_prefix.profile_api_url);
        }
        //Update my profile 
        function update(model) {
            return $http.put(gbmono.api_site_prefix.profile_api_url, model);
        }
    }
})(angular.module('gbmono'));


/*
    category data factory
*/
(function (module) {
    // inject params
    factory.$inject = ['$http'];

    // create instance
    module.factory('categoryDataFactory', factory);

    // factory implement
    function factory($http) {
        // return data factory with CRUD calls
        return {
            getAll: getAll
        }

        function getAll() {
            return $http.get(gbmono.api_site_prefix.category_api_url);
        }


    }

})(angular.module('gbmono'));

/*
    product data factory
*/
(function (module) {
    // inject params
    factory.$inject = ['$http'];

    // create instance
    module.factory('productDataFactory', factory);

    // factory implement
    function factory($http) {

        // return data factory with CRUD calls
        return {
            getAll: getAll,
            getById: getById,
            getByCategory: getByCategory
        };

        function getAll() {
            return $http.get(gbmono.api_site_prefix.product_api_url);
        }
        function getById(id) {
            return $http.get(gbmono.api_site_prefix.product_api_url + "/" + id);
        }

        function getByCategory(categoryId) {
            return $http.get(gbmono.api_site_prefix.product_api_url + '/Categories/' + categoryId);
        }


    }

})(angular.module('gbmono'));


/*
    brand data factory
*/
(function (module) {
    // inject params
    factory.$inject = ['$http'];

    // create instance
    module.factory('brandDataFactory', factory);

    // factory implement
    function factory($http) {

        // return data factory with CRUD calls
        return {
            getAll: getAll,
            getById: getById,
            create: create,
            update: update,
            del: del
        };

        function getAll() {
            return $http.get(gbmono.api_site_prefix.brand_api_url);
        }

        function getById(id) {
            return $http.get(gbmono.api_site_prefix.brand_api_url + '/' + id);
        }

        function create(brand) {
            return $http.post(gbmono.api_site_prefix.brand_api_url, brand);
        }

        function update(brand) {
            return $http.put(gbmono.api_site_prefix.brand_api_url + '/' + brand.brandId, brand);
        }

        function del(id) {
            return $http.delete(gbmono.api_site_prefix.brand_api_url + '/' + id);
        }
    }

})(angular.module('gbmono'));




