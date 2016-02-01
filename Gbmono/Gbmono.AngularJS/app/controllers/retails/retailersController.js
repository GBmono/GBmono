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
        var defaultMapZoom = 5;
        // call page init function
        init();
        // page init method
        function init() {
            //initGoogleMap();
            initMap();

            loadRetails();
        }


        function initMap() {
            var center = { lat: 38.904824, lng: 137.252924 };
            map = new google.maps.Map(document.getElementById('mapAll'), {
                zoom: defaultMapZoom,
                center: center
            });
        }


        $scope.showRetailShop = function (shops) {
            $scope.activeRetailShop = shops;

            //Clean Marks
            clearOverlays();

            //Show Shops Mark
            showShopsOnMap($scope.activeRetailShop);
        }

        $scope.animateMarker = function (shop) {
            var retailShopId = shop.retailShopId;
            angular.forEach(markersArray, function (markerInstance, index, array) {
                if (markerInstance.retailShopId==retailShopId) {
                    var marker = markerInstance.marker;
                    marker.setAnimation(google.maps.Animation.BOUNCE);
                }
            });
        }

        $scope.stopAnimateMarker = function (shop) {
            var retailShopId = shop.retailShopId;
            angular.forEach(markersArray, function (markerInstance, index, array) {
                if (markerInstance.retailShopId == retailShopId) {
                    var marker = markerInstance.marker;
                    marker.setAnimation(google.maps.Animation.DROP);
                }
            });
        }


        function loadRetails() {
            retailDataFactory.getAll().success(function (data) {
                $scope.allRetailers = data;
                if (data.length > 0) {
                    $scope.activeRetailShop = data[0].shops;
                    showShopsOnMap($scope.activeRetailShop);
                }
            }
            );
        };


        function showShopsOnMap(shops) {
            angular.forEach(shops, function (shop, index, array) {
                var shopMark = [shop.name, parseFloat(shop.latitude), parseFloat(shop.longitude), 1, shop.retailShopId];
                setSingleShop(shopMark);
            });
        }

        function setSingleShop(shop) {
            var marker = new google.maps.Marker({
                position: { lat: shop[1], lng: shop[2] },
                map: map,
                title: shop[0],
                zIndex: shop[3],
                animation: google.maps.Animation.DROP
            });
            var markerInstance = { retailShopId: shop[4], marker: marker }
            markersArray.push(markerInstance);
        }


        

        function clearOverlays() {
            for (var i = 0; i < markersArray.length; i++) {
                markersArray[i].marker.setMap(null);
            }
            markersArray.length = 0;
        }
    }

})(angular.module('gbmono'));


