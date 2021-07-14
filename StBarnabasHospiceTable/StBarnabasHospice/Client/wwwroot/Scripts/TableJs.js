var blazorInterop = blazorInterop || {};

blazorInterop.registerResizeHandler = function (windowPaneObject) {
    const paneOne = document.querySelector(`div[_bl_5]`);
    function resizeHandler() {
        windowPaneObject.invokeMethodAsync("SetWindowPaneSize",
            {
                width: paneOne.clientWidth,
                height: paneOne.clientHeight
            });
    };

    //Set up initial values
    resizeHandler();

    //Reigster event handler
    window.addEventListener("mousemove", resizeHandler);
    window.addEventListener("resize", resizeHandler);
};
