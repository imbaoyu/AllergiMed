'use strict';
app.controller('wizardTestReportController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {
    $scope.panelCollection = [
        {
            index: 'A',
            name: 'GRASS',
            items: ['POSITIVE CONTROL', 'NEGATIVE CONTROL', 'ALFALFA', 'BERMUDA GRASS', 'JOHNSON GRASS', 'KENTUCKY BLUE', 'PERENNIAL RYE GRASS', 'TIMOTHY GRASS']
        },
        {
            index: 'B',
            name: 'WEEDS 1',
            items: ['POSITIVE CONTROL', 'NEGATIVE CONTROL', 'ALFALFA', 'BERMUDA GRASS', 'JOHNSON GRASS', 'KENTUCKY BLUE', 'PERENNIAL RYE GRASS', 'TIMOTHY GRASS']
        },
        {
            index: 'C',
            name: 'WEEDS 2',
            items: ['POSITIVE CONTROL', 'NEGATIVE CONTROL', 'ALFALFA', 'BERMUDA GRASS', 'JOHNSON GRASS', 'KENTUCKY BLUE', 'PERENNIAL RYE GRASS', 'TIMOTHY GRASS']
        },
        {
            index: 'D',
            name: 'TREES 1',
            items: ['POSITIVE CONTROL', 'NEGATIVE CONTROL', 'ALFALFA', 'BERMUDA GRASS', 'JOHNSON GRASS', 'KENTUCKY BLUE', 'PERENNIAL RYE GRASS', 'TIMOTHY GRASS']
        },
        {
            index: 'E',
            name: 'TREES 2',
            items: ['POSITIVE CONTROL', 'NEGATIVE CONTROL', 'ALFALFA', 'BERMUDA GRASS', 'JOHNSON GRASS', 'KENTUCKY BLUE', 'PERENNIAL RYE GRASS', 'TIMOTHY GRASS']
        },
        {
            index: 'F',
            name: 'TREES 3',
            items: ['POSITIVE CONTROL', 'NEGATIVE CONTROL', 'ALFALFA', 'BERMUDA GRASS', 'JOHNSON GRASS', 'KENTUCKY BLUE', 'PERENNIAL RYE GRASS', 'TIMOTHY GRASS']
        },
        {
            index: 'G',
            name: 'EPIDERMAL/INSECT',
            items: ['POSITIVE CONTROL', 'NEGATIVE CONTROL', 'ALFALFA', 'BERMUDA GRASS', 'JOHNSON GRASS', 'KENTUCKY BLUE', 'PERENNIAL RYE GRASS', 'TIMOTHY GRASS']
        },
        {
            index: 'H',
            name: 'MOLDS',
            items: ['POSITIVE CONTROL', 'NEGATIVE CONTROL', 'ALFALFA', 'BERMUDA GRASS', 'JOHNSON GRASS', 'KENTUCKY BLUE', 'PERENNIAL RYE GRASS', 'TIMOTHY GRASS']
        },
        {
            index: 'I',
            name: 'FOODS',
            items: ['POSITIVE CONTROL', 'NEGATIVE CONTROL', 'ALFALFA', 'BERMUDA GRASS', 'JOHNSON GRASS', 'KENTUCKY BLUE', 'PERENNIAL RYE GRASS', 'TIMOTHY GRASS']
        }
    ];
}]);