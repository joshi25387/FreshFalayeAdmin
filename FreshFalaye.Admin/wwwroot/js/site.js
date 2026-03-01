window.reportViewer = {

    loadFromBytes: function (frameId, bytes) {

        const blob = new Blob([new Uint8Array(bytes)], {
            type: "application/pdf"
        });

        const url = URL.createObjectURL(blob);

        const frame = document.getElementById(frameId);
        if (frame) {
            frame.src = url + "#zoom=120";
        }
    }

};


function openPdfInNewTab(base64) {
    var pdfWindow = window.open("");
    pdfWindow.document.write(
        "<iframe width='100%' height='100%' src='data:application/pdf;base64," 
        + base64 + "'></iframe>"
    );
}