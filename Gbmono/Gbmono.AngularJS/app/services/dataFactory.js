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
        // api url prefix
        var url = API_URL_ROOT + '/';

        // return data factory with CRUD calls
        return {
            get: get,
            create: create,
            update: update,
            del: del
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
        var action = {
            get_product: "GetProduct/"
        }
        // return data factory with CRUD calls
        return {
            getProductList: getProductList,
            getProductDetails: getProductDetails
        };

        // sample
        function getProductList() {
            return $http.get(url);
            // more elegant call
            // url and action could be removed
            // return $http.get(gbmono.api_site_prefix.product_api_url)
        }

        function getProductDetails(id) {
            return $http.get(url + action.get_product + id);
            // more elegant call
            // return $http.get(gbmono.api_site_prefix.product_api_url + '/GetProduct/' + id);
        }
    }

})(angular.module('gbmono'));