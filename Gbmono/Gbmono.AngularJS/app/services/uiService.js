/*
    ui (html element) service
*/
(function (module) {
    // inject params
    svr.$inject = ['$timeout'];

    // create service instance
    module.service('uiService', svr);

    function svr($timeout) {
        return {
            tab: tab
        };

        // tab
        // it disables default action for tab component
        function tab() {
            // disable the default behavior
            $timeout(function () {
                $('a[data-toggle="tab"]').click(function (e) {
                    e.preventDefault();
                });
            });
        }
    }




})(angular.module('gbmono'));