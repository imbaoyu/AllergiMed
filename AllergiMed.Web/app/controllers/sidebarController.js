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
            route: '/#/ManagePatient'
        }
    ];

    $scope.select = function (index) {
        $scope.selected = index;
    };

}]);