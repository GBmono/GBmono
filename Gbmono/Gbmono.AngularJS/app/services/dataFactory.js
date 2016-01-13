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
        function getCategories() {
            return $http.get(gbmono.api_site_prefix.category_api_url + '/All');
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

        // return data factory with CRUD calls
        return {
            getProductList: getProductList,
            getProductDetails: getProductDetails
        };

        function getProductList() {
            return $http.get(gbmono.api_site_prefix.product_api_url + '/GetProductList');
        }

        function getProductDetails(id) {
            return $http.get(gbmono.api_site_prefix.product_api_url + "/GetProduct/" + id);
        }
    }

})(angular.module('gbmono'));




