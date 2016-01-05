// Interceptors
// For global authenticaiton
// Intercept requests before they are handed to the server and responses before they are handed over to the application code that initiated these requests. 
(function (module) {
    // inject the params
    intercepter.$inject = ['$q', '$window'];

    // create instance
    module.factory('authInterceptor', intercepter);

    // implementation
    function intercepter($q, $window) {
        // return intercepter object
        return {
            request: beforeRequestSend, // 在每一个request 发送前 添加token
            responseError: error // 错误处理 可根据不同错误代码 做一个全局处理
        }

        // attach bearer token into authorization http header before sending request
        function beforeRequestSend(config) {
            config.headers = config.headers || {};
            // retreive token value from local storage
            // if token is not null or empry, then set the token into htth header 'Authorization'
            if ($window.localStorage.getItem(metsys.LOCAL_STORAGE_TOKEN_KEY) && $window.localStorage.getItem(metsys.LOCAL_STORAGE_TOKEN_KEY) !== '') {
                // set the token value into the authorization header
                config.headers.Authorization = 'Bearer ' + $window.localStorage.getItem(metsys.LOCAL_STORAGE_TOKEN_KEY);
            }
            config.headers.Authorization = 'Bearer';
            // return config object
            return config;
        }

        // redirect user to login page when error code returned is 401
        function error(rejection) {
            // if Unauthorized error return
            if (rejection.status === '401') {
                // redirect to login page when user is not authorized 
                // todo:
              
            }

            return $q.reject(rejection);        
        }

    }
})(angular.module('metsys'));