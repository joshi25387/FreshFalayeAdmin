

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
window.registerLedgerKeyboard = function (dotNetRef) {

    document.addEventListener("keydown", function (e) {


        // 🔥 If dialog is open → DO NOTHING
        if (document.querySelector('.rz-dialog-wrapper')) {
            return;
        }

        // 🔥 If active element is input / textarea / button → DO NOTHING
        const tag = document.activeElement?.tagName;
        if (tag === "INPUT" || tag === "TEXTAREA" || tag === "SELECT" || tag === "BUTTON") {
            return;
        }

        if (e.key === "ArrowDown") {
            e.preventDefault();
            dotNetRef.invokeMethodAsync("MoveSelection", "down");
        }

        if (e.key === "ArrowUp") {
            e.preventDefault();
            dotNetRef.invokeMethodAsync("MoveSelection", "up");
        }

        if (e.key === "Enter") {
            e.preventDefault();
            dotNetRef.invokeMethodAsync("OpenSelectedRow");
        }
    });
};

//window.registerLedgerKeyboard = function () {

//    document.addEventListener('keydown', function (e) {        
        
//        const grid = document.querySelector('.rz-grid-table');        
//        if (!grid) return;

//        const rows = grid.querySelectorAll('tbody tr');
//        if (!rows.length) return;

//        let selectedIndex = -1;        
//        rows.forEach((row, index) => {
//            if (row.classList.contains('ledger-selected')) {
//                selectedIndex = index;
//            }
//        });

//        if (e.key === "ArrowDown") {
//            e.preventDefault();            
//            if (selectedIndex < rows.length - 1) {
//                if (selectedIndex >= 0)
//                    rows[selectedIndex].classList.remove('ledger-selected');

//                rows[selectedIndex + 1].classList.add('ledger-selected');
//            }
//        }

//        if (e.key === "ArrowUp") {
//            e.preventDefault();            
//            if (selectedIndex > 0) {
//                rows[selectedIndex].classList.remove('ledger-selected');
//                rows[selectedIndex - 1].classList.add('ledger-selected');
//            }
//        }
//    });
//};

