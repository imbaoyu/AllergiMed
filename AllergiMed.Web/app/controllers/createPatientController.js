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

    $scope.cancel = function () {
        $location.path('/Dashboard');
    }

    $scope.save = function() {
        patientService.addPatient($scope.patient);
        $location.path('/ManagePatient');
    };
}]);