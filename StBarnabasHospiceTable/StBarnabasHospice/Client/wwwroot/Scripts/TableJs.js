var blazorInterop = blazorInterop || {};
//Testing enviorment
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
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Working, single version
blazorInterop.apiObserver = function () {
    const windowPaneOne = document.querySelector(`div[_bl_5]`);

    const myObserver = new ResizeObserver(entries => {
        entries.forEach(entry => {
            console.log(`${entry.target.className} width : ${Math.floor(entry.contentRect.width)}, ${entry.target.className} height: ${Math.floor(entry.contentRect.height)}`);

            document.querySelector(`.windowPane`).style.width = `${Math.floor(entry.contentRect.width)}px;`;
            document.querySelector(`.windowPane`).style.height = `${Math.floor(entry.contentRect.height)}px;`;
        });
    });

    myObserver.observe(windowPaneOne);
}
//Working, Multi-version
blazorInterop.multiObserver = function () {
    const windowPaneOne = document.querySelectorAll(`.windowPane`);

    const myObserver = new ResizeObserver(entries => {
        entries.forEach(entry => {
            console.log(`.${entry.target.className.replace(" ", ".")} width : ${Math.floor(entry.contentRect.width)}, ${entry.target.className} height: ${Math.floor(entry.contentRect.height)}`);

            document.querySelector(`.${entry.target.className.replace(" ", ".")}`).style.width = `${Math.floor(entry.contentRect.width)}px;`;
            document.querySelector(`.${entry.target.className.replace(" ", ".")}`).style.height = `${Math.floor(entry.contentRect.height)}px;`;

        });
    });

    windowPaneOne.forEach(pane => {
        myObserver.observe(pane);
    });
}