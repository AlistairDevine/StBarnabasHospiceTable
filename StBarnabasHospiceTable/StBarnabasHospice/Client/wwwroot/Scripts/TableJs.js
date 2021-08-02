var blazorInterop = blazorInterop || {};

blazorInterop.registerresizehandler = function (windowpaneobject) {
    function resizehandler() {
        windowpaneobject.invokemethodasync("setwindowpanesize",
            {
                width: window.width,
                height: window.height
            });
    };

    //set up initial values
    resizehandler();

    window.addEventListener("resize", resizeHandler);
};

blazorInterop.getPaneOneSize = function () {
    const paneOne = document.querySelector(`div[_bl_5]`);
    return {
        width: paneOne.offsetWidth,
        height: paneOne.offsetHeight
    };
}

blazorInterop.registerResizeCallback = function () {
    window.addEventListener("resize", blazorInterop.resized);
}

blazorInterop.resized = function () {
    DotNet.invokeMethodAsync("StBarnabasHospice.Client", 'OnBrowserResize').then(data => data);
}

blazorInterop.ApiObserver = function () {
    const myObserver = new ResizeObserver(entries => {
        entries.forEach(entry => {
            console.log(`${entry.target.className} width : ${entry.contentRect.width}, ${entry.target.className} height: ${entry.contentRect.height}`);
        });
    });

    const windows = document.querySelector('.PaneOne');
    for (pane in windows) {
        myObserver.observe(windows);
    }
}