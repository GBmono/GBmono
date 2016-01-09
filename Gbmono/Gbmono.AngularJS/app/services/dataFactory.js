﻿/*
    category data factory
*/
(function (module) {
    // inject params
    factory.$inject = ['$http'];

    // create instance
    module.factory('categoryDataFactory', factory);

    // factory implement
    function factory($http) {
        function getCategories() {
            return $http.get(gbmono.api_site_prefix.category_api_url + '/GetAllCategory');
        }

        // return data factory with CRUD calls
        return {
            getCategories: getCategories
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
        // api url prefix
        var url = gbmono.api_site_prefix.product_api_url + '/';

        // return data factory with CRUD calls
        return {
            getProductList: getProductList,
            getProductDetails: getProductDetails
        };

        function getProductList() {
            return $http.get(url + 'GetProductList');
        }

        function getProductDetails(id) {
            return $http.get(url + "GetProduct/" + id);
            // more elegant call
            // return $http.get(gbmono.api_site_prefix.product_api_url + '/GetProduct/' + id);
        }
    }

})(angular.module('gbmono'));




