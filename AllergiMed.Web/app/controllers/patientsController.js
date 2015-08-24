'use strict';
app.controller('patientsController', ['$scope', 'patientsService', function ($scope, patientsService) {

    $scope.patients = [];

    patientsService.getPatients().then(function (results) {
        $scope.patients = results.data;
    }, function (error) {
        alert(error.data.message);
    });

}]);