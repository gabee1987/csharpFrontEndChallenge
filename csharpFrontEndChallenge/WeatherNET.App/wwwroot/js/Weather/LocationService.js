// Function to handle the 'useMyLocation' button click
function handleUseMyLocationClick(e) {
    e.preventDefault();

    if (!("geolocation" in navigator)) {
        console.error('Geolocation is not supported by this browser.');
        return;
    }

    navigator.geolocation.getCurrentPosition(function (position) {
        $('#latitudeInput').val(position.coords.latitude);
        $('#longitudeInput').val(position.coords.longitude);
        $('#coordsForm').submit();
    }, function (error) {
        console.error('Error getting location:', error);
    });
}

// Function to handle the 'useMyLocationView' button click
function handleUseMyLocationViewClick() {
    if (!("geolocation" in navigator)) {
        console.error('Geolocation is not supported by this browser.');
        return;
    }

    navigator.geolocation.getCurrentPosition(function (position) {
        $.get(`/Weather/GetWeatherByCoordinates?latitude=${position.coords.latitude}&longitude=${position.coords.longitude}`, function () {
            location.reload(true);
        }).fail(function (error) {
            console.error('Error fetching weather:', error);
        });
    }, function (error) {
        console.error('Error getting location:', error);
    });
}

// Function to handle the 'useMyLocationData' button click
function handleUseMyLocationDataClick() {
    if (!("geolocation" in navigator)) {
        console.error('Geolocation is not supported by this browser.');
        return;
    }

    navigator.geolocation.getCurrentPosition(function (position) {
        $.get(`/Weather/GetWeatherDataAsJson?latitude=${position.coords.latitude}&longitude=${position.coords.longitude}`, function (data) {
            updateUIWithWeatherData(data);
        }).fail(function (error) {
            console.error('Error fetching weather:', error);
        });
    }, function (error) {
        console.error('Error getting location:', error);
    });
}

// Function to update the UI with the fetched weather data
function updateUIWithWeatherData(data) {
    $('#currentLocationName').text(`Current Weather for ${data.location.name}`);
    const forecastBody = $('#forecastBody');
    forecastBody.empty();

    // Update the card elements with the data
    Object.keys(data.Currently).forEach(key => {
        $(`#${key}Value`).text(data.Currently[key]);
    });
}

$(document).ready(function () {
    $('#useMyLocation').click(handleUseMyLocationClick);
    $('#useMyLocationView').click(handleUseMyLocationViewClick);
    $('#useMyLocationData').click(handleUseMyLocationDataClick);
});
