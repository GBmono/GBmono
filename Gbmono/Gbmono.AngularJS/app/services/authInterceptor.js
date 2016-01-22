//Global Http Interceptor
(function (module) {
    // inject params
    factory.$inject = ['$q', 'localStorageService'];

    // create instance
    module.factory('authInterceptor', factory);

    // factory implement
    function factory($q, localStorageService) {
        // return data factory with CRUD calls
        return {
            request: function (config) {
                config.headers = config.headers || {};
                //Add  config.url != gbmono.api_token_url or will get cross domain issue
                if (config.url != gbmono.api_token_url && localStorageService.get(gbmono.LOCAL_STORAGE_TOKEN_KEY)) {
                //if (localStorageService.get(gbmono.LOCAL_STORAGE_TOKEN_KEY)) {
                    config.headers.Authorization = 'Bearer ' + localStorageService.get(gbmono.LOCAL_STORAGE_TOKEN_KEY);
                }
                return config;
            },
            response: function (response) {
                if (response.status === 401) {
                    // handle the case where the user is not authenticated
                }
                return response || $q.when(response);
            },

            responseError: function (rejection) {
                if (rejection.status === 401) {
                    // handle the case where the user is not authenticated
                    //TODO 
                    alert("401 E");
                }

                // return error object
                return $q.reject(rejection);
            }
        };
    }
})(angular.module('gbmono'));