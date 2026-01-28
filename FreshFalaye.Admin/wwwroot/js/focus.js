//window.safeFocus = function (element) {
//    setTimeout(() => {
//        if (element) {
//            element.focus({ preventScroll: true });
//        }
//    }, 100);
//};

window.safeFocus = (element) => {
    if (element) {
        element.focus({ preventScroll: true });
    }
};
