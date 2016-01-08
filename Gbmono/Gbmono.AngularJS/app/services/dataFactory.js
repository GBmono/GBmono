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
        var url = API_URL_ROOT + '/';

        // return data factory with CRUD calls
        return {
            getProductList: getProductList
        };

        function getProductList() {
            return $http.get(url);
        }
    }

})(angular.module('gbmono'));