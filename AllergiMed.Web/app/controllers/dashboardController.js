'use strict';
app.controller('dashboardController', ['$scope', '$location', 'authService', 'patientsService', 'caseService', function (
    $scope, $location, authService, patientsService, caseService) {
    $scope.patientsNumber = patientsService.getAllPatients().length;
    $scope.processedCase = 23;
    $scope.pendingCase = caseService.getCases().length;

    $scope.managePatient = function() {
        $location.path('/ManagePatient');
    };

    $scope.createPatient = function () {
        $location.path('/CreatePatient');
    };

    $scope.manageCase = function() {
        $location.path('/ManageCase');
    };

    $scope.createCase = function() {
        $location.path('/Wizard');
    };
}]);