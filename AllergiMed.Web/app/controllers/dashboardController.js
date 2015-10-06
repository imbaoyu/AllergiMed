'use strict';
app.controller('dashboardController', ['$scope', '$state', 'authService', 'patientService', 'caseService', 'orderService',
    function ($scope, $state, authService, patientService, caseService, orderService) {
        $scope.patientsNumber = patientService.getAllPatients().length;
        $scope.pendingCase = caseService.getAllCases().length;
        $scope.pendingOrder = orderService.getAllOrders().length;

        $scope.managePatient = function() {
            $state.go('listPatient');
        };

        $scope.createPatient = function () {
            patientService.setSelectedPatient(null);
            $state.go('createPatient');
        };

        $scope.manageCase = function() {
            $state.go('manageCase');
        };

        $scope.createCase = function() {
            $state.go('wizard');
        };

        $scope.manageOrder = function () {
            $state.go('orders');
        };
}]);