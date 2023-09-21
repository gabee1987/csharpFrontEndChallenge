$(document).ready(function () {
    $('#unitToggleButton').click(function () {
        if ($('#currentLocationName').hasClass('metric')) {
            convertToImperial();
            $('#currentLocationName').removeClass('metric').addClass('imperial');
        } else {
            convertToMetric();
            $('#currentLocationName').removeClass('imperial').addClass('metric');
        }
    });
});

function convertToImperial() {
    var tempC = parseFloat($('#temperature').text());
    var tempF = (tempC * 9 / 5) + 32;
    $('#temperature').text(tempF.toFixed(2));
    // ... similarly, convert other units
}

function convertToMetric() {
    var tempF = parseFloat($('#temperature').text());
    var tempC = (tempF - 32) * 5 / 9;
    $('#temperature').text(tempC.toFixed(2));
    // ... similarly, convert back other units
}