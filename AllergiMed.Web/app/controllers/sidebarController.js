'use strict';
app.controller('sidebarController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.menuItems = [
        {
            name: 'Dashboard',
            state: 'dashboard',
            route: '/#/Dashboard'
        },
        {
            name: 'Patients',
            state: 'managePatient',
            route: '/#/ManagePatient'
        },
        {
            name: 'Cases',
            state: 'manageCase',
            route: '/#/ManageCase'
        },
        {
            name: 'Orders',
            state: 'orders',
            route: '/#/Orders'
        },
    ];

    $scope.select = function (index) {
        $scope.selected = index;
    };

}]);