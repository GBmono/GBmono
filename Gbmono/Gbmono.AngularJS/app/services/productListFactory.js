/*
    category data factory
*/
(function (module) {

    api_method = {
        mGetProductList: "GetProductList"
    }


    // inject params
    factory.$inject = ['$http'];

    // create instance
    module.factory('productListFactory', factory);


    // factory implement
    function factory($http) {
        // api url prefix
        var url = gbmono.api_site_prefix.product_api_url + '/';

        function getProductList() {
            var uri = url + api_method.mGetProductList;
            return $http.get(uri);
        }

        // 注释：api_method 可删除 Route可直接放在http method里面 代码跟为简洁
        //function getProductList() {
        //    return $http.get(gbmono.api_site_prefix.product_api_url + '/GetProductList');
        //}

        // return data factory with CRUD calls
        return {
            getProductList: getProductList
        }


    }

})(angular.module('gbmono'));
