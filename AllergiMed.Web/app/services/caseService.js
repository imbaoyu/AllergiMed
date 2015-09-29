'use strict';
app.factory('caseService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var caseServiceProduct = {};

    var collection = [
        {
            id: 1,
            patientId: 5,
            intakeDate: '09-SEP-2015',
            status: 'Pending',
        },
        {
            id: 2,
            patientId: 7,
            intakeDate: '22-JUL-2015',
            status: 'Pending',
        },
        {
            id: 3,
            patientId: 3,
            intakeDate: '13-OCT-2014',
            status: 'Pending',
        },
        {
            id: 4,
            patientId: 1,
            intakeDate: '01-FEB-2015',
            status: 'Pending',
        },
        {
            id: 5,
            patientId: 2,
            intakeDate: '13-OCT-2014',
            status: 'Pending',
        },
        {
            id: 6,
            patientId: 3,
            intakeDate: '23-NOV-2014',
            status: 'Pending',
        },
        {
            id: 7,
            patientId: 7,
            intakeDate: '22-AUG-2015',
            status: 'Pending',
        }     
    ];

    caseServiceProduct.selectedCase = null;

    caseServiceProduct.setSelectedCase = function (caseItem) {
        caseServiceProduct.selectedCase = caseItem;
    };

    caseServiceProduct.getSelectedCase = function () {
        return caseServiceProduct.selectedCase;
    };

    caseServiceProduct.getAllCases = function () {
        return collection;
    };

    caseServiceProduct.getCaseById = function (id) {
        for (var i = 0; i < collection.length; i++) {
            if (collection[i].id === id) {
                return collection[i];
            }
        }
        return null;
    };

    caseServiceProduct.deleteCaseById = function (id) {
        for (var i = 0; i < collection.length; i++) {
            if (collection[i].id === id) {
                collection.splice(i, 1);
            }
        }
    };

    caseServiceProduct.addCase = function (caseItem) {
        for (var i = 0; i < collection.length; i++) {
            if (collection[i].id === caseItem.id) {
                //replace the existing one
                collection[i] = caseItem;
                return caseItem;
            }
        }

        caseItem.id = collection.length + 1;
        collection.push(caseItem);
        return caseItem;
    };

    return caseServiceProduct;

}]);