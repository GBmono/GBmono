(function (module) {
    // inject the controller params
    ctrl.$inject = ['$scope', 'retailerDataFactory'];

    // create controller
    module.controller('retailersController', ctrl);

    // controller body
    function ctrl($scope, retailDataFactory) {
        $scope.allRetailers = [];
        $scope.activeRetailShop = [];
        var map;
        var markersArray = [];
        var defaultZoom = 10;
        // call page init function
        init();

        // page init method
        function init() {
            initGoogleMap();

            loadRetails();
        }



        function initGoogleMap() {
            var center = { lat: 37.204824, lng: 137.252924 };
            map = new google.maps.Map(document.getElementById('mapCanvasDetail'), {
                zoom: defaultZoom,
                center: center
            });
        }

        $scope.showRetailShop = function (shops) {
            $scope.activeRetailShop = shops;
        }

        $scope.showRetailShopMap = function (shop) {
            var shopMark = [shop.name, parseFloat(shop.latitude), parseFloat(shop.longitude), 1];
            clearOverlays();

            $('#mapModal').on("shown.bs.modal", function () {
                google.maps.event.trigger(map, "resize");
            });
            $('#mapModal').modal('show');
            setSingleShop(shopMark);
        }




        function loadRetails() {
            retailDataFactory.getAll().success(function (data) {
                $scope.allRetailers = data;
                if (data.length > 0) {
                    $scope.activeRetailShop = data[0].shops;
                }
                }
            );
        };



        function setSingleShop(shop) {
            var newCenter = { lat: shop[1], lng: shop[2] };
            map.setCenter(newCenter);
            map.setZoom(defaultZoom);
            var marker = new google.maps.Marker({
                position: { lat: shop[1], lng: shop[2] },
                map: map,
                title: shop[0],
                zIndex: shop[3]
            });
            markersArray.push(marker);
        }

        function clearOverlays() {
            for (var i = 0; i < markersArray.length; i++) {
                markersArray[i].setMap(null);
            }
            markersArray.length = 0;
        }


        //function loadRetails() {
        //    retailDataFactory.getAll().success(function (data) {
        //        $scope.allRetailers = data;

        //        //todo temp function
        //        angular.forEach(data, function (retail, index, array) {
        //            angular.forEach(retail.shops, function (shop, index, array) {
        //                var shopMark = [shop.name, parseFloat(shop.latitude), parseFloat(shop.longitude), 1];
        //                setSingleShop(shopMark);
        //            }
        //            );
        //        });
        //    }
        //    );
        //};

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


