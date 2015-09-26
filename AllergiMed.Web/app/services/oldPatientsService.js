'use strict';
app.factory('patientService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var patientServiceFactory = {};

    var _getPatients = function () {

        return $http.get(serviceBase + 'api/patients').then(function (results) {
            return results;
        });
    };

    patientServiceFactory.getPatients = _getPatients;

    return patientServiceFactory;

}]);