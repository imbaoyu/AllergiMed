'use strict';
app.controller('listPatientController', ['$state', '$scope', '$filter', 'NgTableParams', 'patientService', function (
    $state, $scope, $filter, NgTableParams, patientService) {

    var patientList = patientService.getAllPatients();

    $scope.edit = function (patient) {
        patientService.setSelectedPatient(patient);
        $state.go('createPatient');
    };

    $scope.view = function (patient) {
        $state.go('viewPatient.profile', { patientId: patient.id});
    };

    $scope.delete = function (id) {
        patientService.deletePatientById(id);
        patientList = patientService.getAllPatients();
        params.reload();
    };

    var params = this.tableParams = new NgTableParams(
        {
            page: 1,
            count: 10
        },
        {
            total: patientList.length,
            counts: [10,25,50],
            filterDelay: 0,
            getData: function ($defer, params) {
                var filteredData = params.filter() ? $filter('filter')(patientList, params.filter()) : patientList;
                var orderedData = params.sorting() ? $filter('orderBy')(filteredData, params.orderBy()) : filteredData;
                var slicedData = orderedData.slice((params.page() - 1) * params.count(), params.page() * params.count());
                params.total(orderedData.length);
                $defer.resolve(slicedData);
            }
        });
    }
]);