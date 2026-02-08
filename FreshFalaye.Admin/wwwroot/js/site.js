window.reportViewer = {

    loadFromBytes: function (frameId, bytes) {

        const blob = new Blob([new Uint8Array(bytes)], {
            type: "application/pdf"
        });

        const url = URL.createObjectURL(blob);

        const frame = document.getElementById(frameId);
        if (frame) {
            frame.src = url;
        }
    }

};