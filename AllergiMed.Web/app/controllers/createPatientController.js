'use strict';
app.controller('createPatientController', ['$scope', '$state', 'patientService', 'caseService',
    function ($scope, $state, patientService, caseService) {
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
            $state.go('dashboard');
        };

        $scope.save = function () {
            patientService.addPatient($scope.patient);
            $state.go('managePatient');
        };

        //only used in create case wizard
        $scope.next = function (patient) {
            if (!$scope.patient) return;
            
            var pendingCase = {};
            patient = patientService.addPatient(patient);

            pendingCase.intakeDate = patient.intakeDate;
            //add a patient implicitly        
            pendingCase.patientId = patient.id;

            caseService.setSelectedCase(pendingCase);
        }
}]);