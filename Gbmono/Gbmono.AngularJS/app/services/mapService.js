$(document).ready(function() {
    var map;

    function initialize() {
        var mapOptions =
        {
            zoom: 15,
            center: new google.maps.LatLng(39.904675, 116.398779),
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        map = new google.maps.Map(document.getElementById('mapCanvas'), mapOptions);
    }

    google.maps.event.addDomListener(window, 'load', initialize);
});

