'use strict';
app.controller('managePatientController', ['$state', '$scope', '$filter', 'NgTableParams', 'patientService', function (
    $state, $scope, $filter, NgTableParams, patientService) {

    var patientList = patientService.getAllPatients();

    $scope.edit = function (patient) {
        patientService.setSelectedPatient(patient);
        $state.go('createPatient');
    };

    $scope.view = function (patient) {
        patientService.setSelectedPatient(patient);
        $state.go('createPatient');
    };

    $scope.delete = function (id) {
        patientService.deletePatientById(id);
        patientList = patientService.getAllPatients();
        params.reload();
    };

    var params = this.tableParams = new NgTableParams(
        {
            page: 1,
            count: 10,
            sorting: {
                name: 'asc'
            }
        },
        {
            total: patientList.length,
            filterDelay: 0,
            getData: function ($defer, params) {
                var filteredData = params.filter() ? $filter('filter')(patientList, params.filter()) : patientList;
                var orderedData = params.sorting() ? $filter('orderBy')(filteredData, params.orderBy()) : filteredData;
                params.total(orderedData.length);
                $defer.resolve(orderedData);
            }
        });
    }
]);