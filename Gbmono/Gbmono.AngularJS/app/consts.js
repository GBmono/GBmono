﻿/*
 global variables & consts
*/
(function (gbmono) {
    /* web api application name */
    //gbmono.web_api_app_name = 'http://localhost/name';
    gbmono.web_api_app_name = 'http://localhost:28975/';

    /* angularJs app view root path */
    gbmono.app_view_path = '/app/views';

    /* img root path */
    // gbmono.img_root_path = gbmono.APP_NAME + '/Content/img';

    /* gbmono bearer token key name */
    gbmono.LOCAL_STORAGE_TOKEN_KEY = 'gbmono_BEARER_TOKEN'; // localstorage token key name
    gbmono.LOCAL_STORAGE_USER_KEY = 'gbmono_USER_NAME'; // localstorage user account key name
    gbmono.LOCAL_STORAGE_ROLE_KEY = 'gbmono_ROLE_NAME'; // localstorage role key name    

    /* web api controller route prefix */
    /* bearer token entry point*/
    gbmono.api_token_url = gbmono.web_api_app_name + '/Token'; // bearer token end point

    gbmono.api_site_prefix = {
        // category api url 
        category_api_url: gbmono.web_api_app_name + '/Categories',
        // product detail url
        product_api_url: gbmono.web_api_app_name + '/api/Products',
    };

})(window.gbmono = window.gbmono || {});