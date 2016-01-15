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
            return $http.get(gbmono.api_site_prefix.category_api_url );
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

