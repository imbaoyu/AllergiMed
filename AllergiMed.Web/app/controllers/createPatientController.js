'use strict';
app.controller('createPatientController', ['$scope', '$location', 'patientsService',
    function ($scope, $location, patientsService) {
    
        //set the patient currently being edited
        //if creating a new patient set it to null
        $scope.patient = patientsService.getSelectedPatient();
        if ($scope.patient == null) {
            $scope.action = 'Create';
        }
        else {
            $scope.action = 'Edit';
        }

        $scope.clear = function () {
            $scope.patient = {};
            patientsService.setSelectedPatient(null);
        };

        $scope.cancel = function() {
            $location.path('/Dashboard');
        };

        $scope.save = function () {
            patientsService.addPatient($scope.patient);
            $location.path('/ManagePatient');
        };

        //only used in create case wizard
        $scope.next = function (patient) {
            if (!$scope.patient) return;

            $rootScope.pendingCase = {};
            $rootScope.pendingCase.intakeDate = patient.intakeDate;

            //add a patient implicitly
            var pat = patientsService.addPatient(patient);
            $rootScope.pendingCase.patientId = pat.id;
        }
}]);