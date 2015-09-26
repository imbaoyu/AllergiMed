'use strict';
app.controller('createPatientController', ['$scope', '$location', 'patientService',
    function ($scope, $location, patientService) {
    
        //set the patient currently being edited
        //if creating a new patient set it to null
        $scope.patient = patientService.getSelectedPatient();
        if ($scope.patient == null) {
            $scope.action = 'Create';
        }
        else {
            $scope.action = 'Edit';
        }

        $scope.clear = function () {
            $scope.patient = {};
            patientService.setSelectedPatient(null);
        };

        $scope.cancel = function() {
            $location.path('/Dashboard');
        };

        $scope.save = function () {
            patientService.addPatient($scope.patient);
            $location.path('/ManagePatient');
        };

        //only used in create case wizard
        $scope.next = function (patient) {
            if (!$scope.patient) return;

            $rootScope.pendingCase = {};
            $rootScope.pendingCase.intakeDate = patient.intakeDate;

            //add a patient implicitly
            var pat = patientService.addPatient(patient);
            $rootScope.pendingCase.patientId = pat.id;
        }
}]);