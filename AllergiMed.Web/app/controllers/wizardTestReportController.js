﻿'use strict';
app.controller('wizardTestReportController', ['$scope', '$location', 'authService', 'antigenService', function ($scope,
    $location, authService, antigenService) {
    $scope.panelCollection = antigenService.getAntigens();
}]);