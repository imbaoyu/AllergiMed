'use strict';
app.controller('managePatientController', ['$location', '$scope', 'NgTableParams', 'patientService', function (
    $location, $scope, NgTableParams, patientService) {

    var patientList = patientService.getAllPatients();

    $scope.edit = function(patient) {
        patientService.setSelectedPatient(patient);
        $location.path('/CreatePatient');
    }

    $scope.delete = function (id) {
        patientService.deletePatientById(id);
        patientList = patientService.getAllPatients();
    }

    this.tableParams = new NgTableParams(
        {
            page: 1, // show first page
            count: 10 // count per page
        },
        {
            filterDelay: 0,
            getData: function ($defer, params) {
                $defer.resolve(patientList);
            }
        });
    }
]);