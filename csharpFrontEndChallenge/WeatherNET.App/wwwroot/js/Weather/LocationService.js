$(document).ready(function () {
    $('#useMyLocationView').click(function () {
        if ("geolocation" in navigator) {
            navigator.geolocation.getCurrentPosition(function (position) {
                var lat = position.coords.latitude;
                var lon = position.coords.longitude;

                // Send the coordinates to the server using jQuery's AJAX
                $.get(`/Weather/GetWeatherBasedOnCoords?latitude=${lat}&longitude=${lon}`, function (data) {

                    // Handle the server response here, e.g., update the UI
                    //alert(data.location.name);
                    //console.log(data.location.name);
                    location.reload(true);
                })
                    .fail(function (error) {
                        console.error('Error fetching weather:', error);
                    });
            }, function (error) {
                console.error('Error getting location:', error);
            });
        } else {
            console.error('Geolocation is not supported by this browser.');
        }
    });

    $('#useMyLocationData').click(function () {
        if ("geolocation" in navigator) {
            navigator.geolocation.getCurrentPosition(function (position) {
                var lat = position.coords.latitude;
                var lon = position.coords.longitude;

                // Send the coordinates to the server using jQuery's AJAX
                $.get(`/Weather/GetWeatherData?latitude=${lat}&longitude=${lon}`, function (data) {

                    // Handle the server response here, e.g., update the UI
                    alert(data.location.name);
                    console.log(data.location.name);
                    $('#currentLocationName').text(`Current Weather for ${data.location.name}`);
                })
                    .fail(function (error) {
                        console.error('Error fetching weather:', error);
                    });
            }, function (error) {
                console.error('Error getting location:', error);
            });
        } else {
            console.error('Geolocation is not supported by this browser.');
        }
    });
});
