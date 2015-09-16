'use strict';
app.controller('sidebarController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.menuItems = [
        {
            name: 'Dashboard',
            route: '/#/Dashboard'
        },
        {
            name: 'Manage Cases',
            route: '/#/ManageCase'
        },
        {
            name: 'Manage Patients',
            route: '/#/ManagePatients'
        },
        {
            name: 'Create Case Wizard',
            route: '/#/Wizard'
        }
    ];

    $scope.select = function (index) {
        $scope.selected = index;
    };

}]);