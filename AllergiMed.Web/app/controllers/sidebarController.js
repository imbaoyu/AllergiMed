'use strict';
app.controller('sidebarController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.menuItems = [
        {
            name: 'Dashboard',
            route: '/#/Dashboard'
        },
        {
            name: 'Patients',
            route: '/#/ManagePatient'
        },
        {
            name: 'Cases',
            route: '/#/ManageCase'
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