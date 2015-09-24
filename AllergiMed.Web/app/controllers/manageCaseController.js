'use strict';
app.controller('manageCaseController', ['$scope', '$location', '$rootScope', 'NgTableParams', 'caseService', 'patientsService', function (
    $scope, $location, $rootScope, NgTableParams, caseService, patientsService) {
    
    var caseList = caseService.getCases();

    for (var i = 0; i < caseList.length; i++) {
        caseList[i].patient = patientsService.getPatient(caseList[i].patientId);
    }

    this.tableParams = new NgTableParams({
        page: 1, // show first page
        count: 10 // count per page
    }, {
        filterDelay: 0,
        data: caseList
    });

    $scope.manage = function(caseId) {
        var caseItem = caseService.getCase(caseId);
        $rootScope.editingPatientId = caseItem.patientId;
        $location.path('/Wizard');
    }

}]);