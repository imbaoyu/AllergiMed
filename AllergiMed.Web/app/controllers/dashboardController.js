'use strict';
app.controller('dashboardController', ['$scope', '$location', 'authService', 'patientService', 'caseService', 'orderService',
    function ($scope, $location, authService, patientService, caseService, orderService) {
        $scope.patientsNumber = patientService.getAllPatients().length;
        $scope.pendingCase = caseService.getAllCases().length;
        $scope.pendingOrder = orderService.getAllOrders().length;

        $scope.managePatient = function() {
            $location.path('/ManagePatient');
        };

        $scope.createPatient = function () {
            patientService.setSelectedPatient(null);
            $location.path('/CreatePatient');
        };

        $scope.manageCase = function() {
            $location.path('/ManageCase');
        };

        $scope.createCase = function() {
            $location.path('/Wizard');
        };

        $scope.manageOrder = function () {
            $location.path('/Orders');
        };
}]);