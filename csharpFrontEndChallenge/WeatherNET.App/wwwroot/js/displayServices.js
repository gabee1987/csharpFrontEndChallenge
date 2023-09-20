(function () {
    function initializeHorizontalScroll(elementSelector) {
        console.log("element: ", elementSelector);
        console.log("Horizontal Scroll Service initialized...")
        $(elementSelector).on('wheel', function (e) {
            if (e.originalEvent.deltaY > 0) {
                $(this).scrollLeft($(this).scrollLeft() + 55);
            } else {
                $(this).scrollLeft($(this).scrollLeft() - 55);
            }
            e.preventDefault();
        });
    }

    // Set raindrop fill rate
    function setRaindropFill(percentage, index) {
        const totalHeight = 42;
        const height = (percentage / 100) * totalHeight;
        const yPos = totalHeight - height;

        const fillRect = document.getElementById('fillRect-' + index);
        fillRect.setAttribute('y', yPos);
        fillRect.setAttribute('height', height);
    }

    function initializeRaindropFillForForecast(data) {
        data.forEach((item, index) => {
            setRaindropFill(item.precipChance, index);
        });
    }

    // always initialize the scroll on document ready for #hourlyScroll
    $(document).ready(function () {
        //initializeHorizontalScroll('#hourlyForecastScrollChart');
    });

    // Export function to use it for other elements in the future
    window.initializeHorizontalScroll = initializeHorizontalScroll;
    window.initializeRaindropFillForForecast = initializeRaindropFillForForecast;

})();