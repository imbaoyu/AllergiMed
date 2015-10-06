'use strict';
app.controller('sidebarController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.menuItems = [
        {
            name: 'Dashboard',
            state: 'dashboard'
        },
        {
            name: 'Patients',
            state: 'listPatient'
        },
        {
            name: 'Cases',
            state: 'manageCase'
        },
        {
            name: 'Orders',
            state: 'orders'
        },
    ];

    $scope.select = function (index) {
        $scope.selected = index;
    };

}]);