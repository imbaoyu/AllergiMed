'use strict';
app.controller('wizardAntigenController', ['$scope', '$location', 'authService', 'antigenService', function ($scope,
    $location, authService, antigenService) {
    $scope.panelCollection = antigenService.getAntigens();
}]);