'use strict';
app.controller('sidebarController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.menuItems = [
        {
            name: 'Dashboard',
            route: '/#/Dashboard'
        },
        {
            name: 'Cases',
            route: '/#/ManageCase'
        },
        {
            name: 'Patients',
            route: '/#/ManagePatient'
        },
        {
            name: 'Orders',
            route: '/#/Orders'
        },
    ];

    $scope.select = function (index) {
        $scope.selected = index;
    };

}]);