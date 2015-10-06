'use strict';
app.controller('manageCaseController', ['$scope', '$filter', '$state', 'NgTableParams', 'caseService', 'patientService',
    function ($scope, $filter, $state, NgTableParams, caseService, patientService) {
    
        var caseList = caseService.getAllCases();

        for (var i = 0; i < caseList.length; i++) {
            caseList[i].patient = patientService.getPatientById(caseList[i].patientId);
        }

        $scope.manage = function (caseId) {
            var caseItem = caseService.getCaseById(caseId);
            var patient = patientService.getPatientById(caseItem.patientId);
            caseService.setSelectedCase(caseItem);
            patientService.setSelectedPatient(patient);
            $state.go('wizard');
        };

        this.tableParams = new NgTableParams(
          {
              page: 1,
              count: 10
          },
          {
              total: caseList.length,
              counts: [10, 25, 50],
              filterDelay: 0,
              getData: function ($defer, params) {
                  var filteredData = params.filter() ? $filter('filter')(caseList, params.filter()) : caseList;
                  var orderedData = params.sorting() ? $filter('orderBy')(filteredData, params.orderBy()) : filteredData;
                  var slicedData = orderedData.slice((params.page() - 1) * params.count(), params.page() * params.count());
                  params.total(orderedData.length);
                  $defer.resolve(slicedData);
              }
          });
    }]);