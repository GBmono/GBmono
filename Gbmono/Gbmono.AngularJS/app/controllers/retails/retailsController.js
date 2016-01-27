(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'retailDataFactory'];

    // create controller
    module.controller('retailsController', ctrl);

    // controller body
    function ctrl($scope, retailDataFactory) {
        $scope.allRetails = [];

        var map;
        // call page init function
        init();

        // page init method
        function init() {
            initGoogleMap();

            loadRetails();
        }

        function loadRetails() {
            retailDataFactory.getAll().success(function (data) {
                $scope.allRetails = data;

                //todo temp function
                angular.forEach(data, function (retail, index, array) {
                    angular.forEach(retail.shops, function (shop, index, array) {
                            var shopMark = [shop.name, parseFloat(shop.latitude), parseFloat(shop.longitude), 1];
                        setSingleShop(shopMark);
                    }
                    );
                });
            }
       )
        };


        function initGoogleMap() {
            var center = { lat: 37.204824, lng: 137.252924 };
            map = new google.maps.Map(document.getElementById('mapCanvas'), {
                zoom: 6,
                center: center
            });

        }


        function setSingleShop(shop) {
            var marker = new google.maps.Marker({
                position: { lat: shop[1], lng: shop[2] },
                map: map,
                title: shop[0],
                zIndex: shop[3]
            });
        }

        //function setMutilMarkers() {
        //    var shops = [
        //      ['shops1', -33.890542, 151.274856, 1],
        //      ['shops2', -33.923036, 151.259052, 1],
        //      ['shops3', -34.028249, 151.157507, 1],
        //      ['shops4', -33.80010128657071, 151.28747820854187, 1],
        //      ['shops5', -33.950198, 151.259302, 1]
        //    ];

        //    for (var i = 0; i < shops.length; i++) {
        //        var shop = shops[i];
        //        var marker = new google.maps.Marker({
        //            position: { lat: shop[1], lng: shop[2] },
        //            map: map,
        //            title: shop[0],
        //            zIndex: shop[3]
        //        });
        //    }
        //}

    }

})(angular.module('gbmono'));