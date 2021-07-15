var blazorInterop = blazorInterop || {};

blazorInterop.registerResizeHandler = function (windowPaneObject) {
    const paneOne = document.querySelector(`div[_bl_5]`);
    function resizeHandler() {
        windowPaneObject.invokeMethodAsync("SetWindowPaneSize",
            {
                width: paneOne.width,
                height: paneOne.height
            });
    };

    //Set up initial values
    resizeHandler();

    //Reigster event handler
    //RESEARCH : DOM events (https://www.w3schools.com/jsref/dom_obj_event.asp)
    window.addEventListener("click", resizeHandler);
};

blazorInterop.resizePane = function () {
    const paneOne = document.querySelector(`div[_bl_5]`);
    return paneOne.width;
    }
}

//ERROR : event handlers not the cause of the problem
//ERROR : type of width not the cause of the problem

