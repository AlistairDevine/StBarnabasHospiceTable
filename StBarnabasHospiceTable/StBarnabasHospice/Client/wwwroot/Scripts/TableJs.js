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
    //RESEARCH : DOM events (https://www.w3schools.com/jsref/dom_obj_event.asp)
    window.document.querySelector(`div[_bl_5]`).addEventListener("resize", resizeHandler);
}

blazorInterop.getPaneOneSize = function () {
    const paneOne = document.querySelector(`div[_bl_5]`);
    return {
        width: paneOne.offsetWidth,
        height: paneOne.offsetHeight
    };
}

blazorInterop.registerResizeCallback = function () {
    //TODO : only event listener triggered when the browser window changes size, not window pane DOM element
    window.addEventListener("resize", blazorInterop.resized);
}

blazorInterop.resized = function () {
    //DotNet.invokeMethod("BrowserResize", 'OnBrowserResize');
    DotNet.invokeMethodAsync("StBarnabasHospice.Client", 'OnBrowserResize').then(data => data);
}
blazorInterop.ApiObserver = function () {
    const myObserver = new ResizeObserver(entries => {
        entries.forEach(entry => {
            console.log('width', entry.contentRect.width);
            console.log('height', entry.contentRect.height);
        });
    });

    const someEl = document.querySelector(`div[_bl_5]`);
    myObserver.observe(someEl);
}

