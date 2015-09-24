'use strict';
app.factory('patientsService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var patientsServiceFactory = {};

    var _getPatients = function () {

        return $http.get(serviceBase + 'api/patients').then(function (results) {
            return results;
        });
    };

    patientsServiceFactory.getPatients = _getPatients;

    return patientsServiceFactory;

}]);