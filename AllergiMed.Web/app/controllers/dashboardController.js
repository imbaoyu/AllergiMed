'use strict';
app.controller('dashboardController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {
    $scope.patientsNumber = 11;
    $scope.processedCase = 23;
    $scope.pendingCase = 5;

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