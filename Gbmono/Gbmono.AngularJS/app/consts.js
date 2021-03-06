﻿/*
 global variables & consts
*/
(function (gbmono) {
    /* web api application name */
    //gbmono.web_api_app_name = 'http://localhost/name';
    gbmono.domain = 'http://localhost:28975/';
    gbmono.web_api_app_name = gbmono.domain + 'api';
    
    /* angularJs app view root path */
    gbmono.app_view_path = '/app/views';

    /* img root path */
    // gbmono.img_root_path = gbmono.APP_NAME + '/Content/img';

    /* gbmono bearer token key name */
    gbmono.LOCAL_STORAGE_TOKEN_KEY = 'gbmono_BEARER_TOKEN'; // localstorage token key name
    //gbmono.LOCAL_STORAGE_USER_KEY = 'gbmono_USER_NAME'; // localstorage user account key name
    
    /* web api controller route prefix */
    /* bearer token entry point*/
    gbmono.api_token_url = gbmono.domain + '/Token'; // bearer token end point

    // web api url routes
    gbmono.api_site_prefix = {
        // account api url
        account_api_url: gbmono.web_api_app_name + '/Accounts',
        // category api url 
        category_api_url: gbmono.web_api_app_name + '/Categories',
        // product detail url
        product_api_url: gbmono.web_api_app_name + '/Products',
        // brand url
        brand_api_url: gbmono.web_api_app_name + '/Brands',
        // profile url
        profile_api_url: gbmono.web_api_app_name + '/Profiles',
        // follow options url
        follow_options_url: gbmono.web_api_app_name + '/FollowOptions',
        // banner url
        banner_api_url: gbmono.web_api_app_name + '/Banners',
        // retail url
        retail_api_url: gbmono.web_api_app_name + '/Retailers'
    };

    gbmono.follow_type= {
        followProduct : 1, //关注的商品
        followBrand : 2,   //关注的品牌
        favoriteProduct : 3  //收藏夹商品
    }

})(window.gbmono = window.gbmono || {});