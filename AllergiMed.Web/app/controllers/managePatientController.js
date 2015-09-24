'use strict';
app.controller('managePatientController', ['$location', '$scope', 'NgTableParams', 'patientsService', function (
    $location, $scope, NgTableParams, patientsService) {

    var patientList = patientsService.getAllPatients();

    $scope.edit = function(patient) {
        patientsService.setSelectedPatient(patient);
        $location.path('/CreatePatient');
    }

    $scope.delete = function (id) {
        patientsService.deletePatientById(id);
        patientList = patientsService.getAllPatients();
        this.tableParams.reload();
        //$location.path('/Dashboard');
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