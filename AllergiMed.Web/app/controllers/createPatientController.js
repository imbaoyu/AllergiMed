'use strict';
app.controller('createPatientController', ['$rootScope', '$scope', '$location', 'NgTableParams', 'patientService', function (
    $rootScope, $scope, $location, NgTableParams, patientService) {
    
    if ($rootScope.editingPatientId !== null) {
        $scope.patient = patientService.getPatient($rootScope.editingPatientId);
        $scope.action = 'Edit';
    } else {
        $scope.patient = {};
        $scope.action = 'Create';
    }

    $scope.clear = function () {
        $scope.patient = {};
        $rootScope.editingPatientId = null;
    };

    $scope.cancel = function() {
        $location.path('/Dashboard');
    };

    $scope.next = function (patient) {
        $rootScope.pendingCase = {};
        $rootScope.pendingCase.intakeDate = patient.intakeDate;
        var pat = patientService.addPatient(patient);
        $rootScope.pendingCase.patientId = pat.id;
    }

    $scope.save = function() {
        patientService.addPatient($scope.patient);
        $location.path('/ManagePatient');
    };
}]);