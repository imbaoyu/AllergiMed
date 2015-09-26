'use strict';
app.controller('patientsController', ['$scope', 'patientService', function ($scope, patientService) {

    $scope.patients = [];

    patientService.getPatients().then(function (results) {
        $scope.patients = results.data;
    }, function (error) {
        alert(error.data.message);
    });

}]);