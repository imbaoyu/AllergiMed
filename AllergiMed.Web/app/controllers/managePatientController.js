'use strict';
app.controller('managePatientController', ['$location', '$rootScope', '$scope', 'NgTableParams', 'patientService', function (
    $location, $rootScope, $scope, NgTableParams, patientService) {
    var patientList = patientService.getPatients();

    $scope.edit = function(id) {
        $rootScope.editingPatientId = id;
        $location.path('/CreatePatient');
    }

    $scope.delete = function (id) {
        patientService.deletePatient(id);
        $location.path('/Dashboard');
    }

    this.tableParams = new NgTableParams({
        page: 1, // show first page
        count: 10 // count per page
    }, {
        filterDelay: 0,
        data: patientList
    });
}]);