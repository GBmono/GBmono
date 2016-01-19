/*
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
                data: "userName=" + userName + "&password=" + password + "&grant_type=password"
            });
        }
    }
})(angular.module('gbmono'));

(function (module) {
    // inject params
    factory.$inject = ['$http'];

    // create instance
    module.factory('profileDataFactory', factory);

    // factory implement
    function factory($http) {
        // return data factory with CRUD calls
        return {
            getMy: getMy
        }

        //Get my profile 
        function getMy() {
            //todo make it to $http.post
            //return $http.post(gbmono.api_site_prefix.profile_api_url + '/GetMyProfile', {
            //    headers: getHeaders()
            //});

            var token = "z0qO-u31GlBXqGPTPEK9g7UzzH0NIPDFW5HDZxCozrCggdfBM8niWNxyDi8Cl-PB0IXCbcb_tx-aQVqrkfD2Ghorqg0nyhIR38DZrnc5W0_Ywvw4C2tXRy5nbIZ_FnqHXDOm_0MibSmPqrz32Y9xTrQFT34cL2vd5n6nSs4TL8pyFqzJ5y9-RLU8lalAdIwbP4VKEFn9Ds_Sw0DD8tX9-ue-hyPlR4vk5c4b9w3org5leBzoU6GoVF6HfH7tpDUCgTU35WNXCVXjYEXP0FBQ6Qc4qZLpGyiyXZyjbXP7kogHPF9jJJhpqPoNfFnfLXyqiIffd1cLBcpFZVapa-sAj1093tI-mdt3SN98UNgJDpDiMrWqNB3XHfJJP_cCZxX0bCzqAR6ZMfFY-m94w9KFzPAjxs0Hx_dOSADr24_zM67BJVecGwJZfkE1Jn8Qtf6BT0gRMe8Vv6bVxT2YO66Y1mprJomsq1wZ8LjXuwKuXjGh8xrBv_cK1CVKnx7Bq9M6";
            //working with corred token
            $http({
                url: gbmono.api_site_prefix.profile_api_url + '/GetMyProfile',
                method: "POST",
                headers: {
                    "Authorization": "Bearer "+token
                }
            });
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

