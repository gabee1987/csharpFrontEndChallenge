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

    // always initialize the scroll on document ready for #hourlyScroll
    $(document).ready(function () {
        //initializeHorizontalScroll('#hourlyForecastScrollChart');
    });

    // Export function to use it for other elements in the future
    window.initializeHorizontalScroll = initializeHorizontalScroll;

})();