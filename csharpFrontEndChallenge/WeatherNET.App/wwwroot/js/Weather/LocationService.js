$(document).ready(function () {
    $('#useMyLocation').click(function (e) {
        e.preventDefault(); // Prevent the default button behavior

        if ("geolocation" in navigator) {
            navigator.geolocation.getCurrentPosition(function (position) {
                var lat = position.coords.latitude;
                var lon = position.coords.longitude;

                // Populate the hidden form's inputs with the coordinates
                $('#latitudeInput').val(lat);
                $('#longitudeInput').val(lon);

                // Submit the form
                $('#coordsForm').submit();
            }, function (error) {
                console.error('Error getting location:', error);
            });
        } else {
            console.error('Geolocation is not supported by this browser.');
        }
    });
});

$(document).ready(function () {
    $('#useMyLocationView').click(function () {
        if ("geolocation" in navigator) {
            navigator.geolocation.getCurrentPosition(function (position) {
                var lat = position.coords.latitude;
                var lon = position.coords.longitude;

                // Send the coordinates to the server using jQuery's AJAX
                $.get(`/Weather/GetWeatherByCoordinates?latitude=${lat}&longitude=${lon}`, function (data) {

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
});

$(document).ready(function () {
    $('#useMyLocationData').click(function () {
        if ("geolocation" in navigator) {
            navigator.geolocation.getCurrentPosition(function (position) {
                var lat = position.coords.latitude;
                var lon = position.coords.longitude;

                // Send the coordinates to the server using jQuery's AJAX
                $.get(`/Weather/GetWeatherDataAsJson?latitude=${lat}&longitude=${lon}`, function (data) {

                    // Handle the server response here, e.g., update the UI
                    console.log(data.location.name);
                    $('#currentLocationName').text(`Current Weather for ${data.location.name}`);

                    var currently = data.currently;

                    //const forecastBody = $('#forecastBody');
                    //forecastBody.empty();

                    // Update the card elements
                    $('#summaryValue').text(currently.Summary);
                    $('#iconValue').text(currently.Icon);
                    $('#temperatureValue').text(currently.Temperature);
                    $('#feelsLikeValue').text(currently.ApparentTemperature);
                    $('#nearestStormDistanceValue').text(currently.NearestStormDistance);
                    $('#nearestStormBearingValue').text(currently.NearestStormBearing);
                    $('#precipitationIntensityValue').text(currently.PrecipIntensity);
                    $('#precipitationProbabilityValue').text(currently.PrecipProbability);
                    $('#precipitationIntensityErrorValue').text(currently.PrecipIntensityError);
                    $('#precipitationTypeValue').text(currently.PrecipType);
                    $('#dewPointValue').text(currently.DewPoint);
                    $('#humidityValue').text(currently.Humidity);
                    $('#pressureValue').text(currently.Pressure);
                    $('#windSpeedValue').text(currently.WindSpeed);
                    $('#windGustValue').text(currently.WindGust);
                    $('#windBearingValue').text(currently.WindBearing);
                    $('#cloudCoverValue').text(currently.CloudCover);
                    $('#uvIndexValue').text(currently.UvIndex);
                    $('#visibilityValue').text(currently.Visibility);
                    $('#ozoneValue').text(currently.Ozone);
                    $('#precipitationAccumulationValue').text(currently.PrecipAccumulation);

                    //forecastBody.append(

                    //)
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
