

window.registerDialogShortcuts = function (dotNetRef) {
    document.addEventListener("keydown", function (e) {

        // Alt + S
        if (e.altKey && e.key.toLowerCase() === "s") {

            e.preventDefault();  
            if (document.activeElement) {
                console.log('blur called');
                document.activeElement.blur();
            }

            // Small delay to allow change event to fire
            setTimeout(() => {
                dotNetRef.invokeMethodAsync("OnAltS");
            }, 0);                                  
        }

        // Esc
        if (e.key === "Escape") {
            e.preventDefault();
            dotNetRef.invokeMethodAsync("OnEsc");
        }
    });
};
