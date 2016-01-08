/*
 global variables & consts
*/
(function (gbmono) {
    /* web application name */
    gbmono.APP_NAME = '';

    /* angularJs app view root path */
    gbmono.app_view_path = gbmono.APP_NAME + '/app/views';

    /* img root path */
    // gbmono.img_root_path = gbmono.APP_NAME + '/Content/img';

    /* gbmono bearer token key name */
    gbmono.LOCAL_STORAGE_TOKEN_KEY = 'gbmono_BEARER_TOKEN'; // localstorage token key name
    gbmono.LOCAL_STORAGE_USER_KEY = 'gbmono_USER_NAME'; // localstorage user account key name
    gbmono.LOCAL_STORAGE_ROLE_KEY = 'gbmono_ROLE_NAME'; // localstorage role key name    

    /* web api controller route prefix */
    /* bearer token entry point*/
    gbmono.api_token_url = gbmono.APP_NAME + '/Token'; // bearer token end point
    
    // category api url 
    gbmono.api_site_prefix = gbmono.APP_NAME + '/api/Categories';

})(window.gbmono = window.gbmono || {});