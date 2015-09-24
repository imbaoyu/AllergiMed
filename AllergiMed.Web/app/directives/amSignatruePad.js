'use strict';
app.directive('amSignature', function () {

    return {
        restrict: 'A',
        templateUrl: '/app/views/directives/amSignaturePadTemplate.html',
        link: function (scope, element, attr) {
                var clearButton = element.find("[data-action=clear]").get(0),
                    saveButton = element.find("[data-action=save]").get(0),
                    canvas = element.find("canvas").get(0),
                    signaturePad;

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