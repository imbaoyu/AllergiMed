'use strict';
app.directive('amSignature', function () {
    // Adjust canvas coordinate space taking into account pixel ratio,
    // to make it look crisp on mobile devices.
    // This also causes canvas to be cleared.
    function resizeCanvas(canvas) {
        // When zoomed out to less than 100%, for some very strange reason,
        // some browsers report devicePixelRatio as less than 1
        // and only part of the canvas is cleared then.
        var ratio = Math.max(window.devicePixelRatio || 1, 1);
        canvas.width = canvas.offsetWidth * ratio;
        canvas.height = canvas.offsetHeight * ratio;
        canvas.getContext("2d").scale(ratio, ratio);
    }

    return {
        restrict: 'A',
        templateUrl: '/app/views/amSignaturePadTemplate.html',
        link: function (scope, element, attr) {
                var clearButton = element.find("[data-action=clear]").get(0),
                    saveButton = element.find("[data-action=save]").get(0),
                    canvas = element.find("canvas").get(0),
                    signaturePad;

                window.onresize = resizeCanvas;
                resizeCanvas(canvas);

                signaturePad = new SignaturePad(canvas);

                clearButton.addEventListener("click", function (event) {
                    signaturePad.clear();
                });

                saveButton.addEventListener("click", function (event) {
                    if (signaturePad.isEmpty()) {
                        alert("Please provide signature first.");
                    } else {
                        window.open(signaturePad.toDataURL());
                    }
                });
        }
    }
});