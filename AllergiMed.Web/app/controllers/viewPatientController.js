'use strict';
app.controller('viewPatientController', ['$scope', '$state', '$stateParams', '$filter', 'NgTableParams', 'patientService', 'caseService',
    function ($scope, $state, $stateParams, $filter, NgTableParams, patientService, caseService) {
        var patientId = $stateParams.patientId;
        $scope.patient = patientService.getPatientById(patientId);

        var caseList = caseService.getCasesByPatientId(patientId);

        var params = this.tableParams = new NgTableParams(
        {
            page: 1,
            count: 10,
            sorting: {
                name: 'asc'
            }
        },
        {
            total: caseList.length,
            filterDelay: 0,
            getData: function ($defer, params) {
                var filteredData = params.filter() ? $filter('filter')(caseList, params.filter()) : caseList;
                var orderedData = params.sorting() ? $filter('orderBy')(filteredData, params.orderBy()) : filteredData;
                params.total(orderedData.length);
                $defer.resolve(orderedData);
            }
        });
    }]);