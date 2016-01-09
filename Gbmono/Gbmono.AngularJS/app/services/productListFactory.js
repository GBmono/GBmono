/*
    category data factory
*/
(function (module) {

    // inject params
    factory.$inject = ['$http'];

    // create instance
    module.factory('productListFactory', factory);


    // factory implement
    function factory($http) {

        function getProductList() {
            return $http.get(gbmono.api_site_prefix.product_api_url + '/GetProductList');
        }

        // return data factory with CRUD calls
        return {
            getProductList: getProductList
        }


    }

})(angular.module('gbmono'));
