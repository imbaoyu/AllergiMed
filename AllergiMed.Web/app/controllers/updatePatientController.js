'use strict';
app.controller('updatePatientController', ['$scope', '$state', '$stateParams', 'patientService', 'caseService',
    function ($scope, $state, $stateParams, patientService, caseService) {
        var patientId = $stateParams.patientId;

        if (!!patientId) {
            $scope.patient = patientService.getPatientById(patientId);
            $scope.action = 'Edit';
        } else {
            $scope.action = 'Create';
        }

        $scope.clear = function () {
            $scope.patient = {};
            patientService.setSelectedPatient(null);
        };

        $scope.cancel = function() {
            $state.go('listPatient');
        };

        $scope.save = function () {
            patientService.addPatient($scope.patient);
            $state.go('listPatient');
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