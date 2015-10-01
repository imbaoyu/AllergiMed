var app = angular.module('AllergiMedApp', ['ngRoute', 'LocalStorageModule', 'angular-loading-bar',
    'mgo-angular-wizard', 'ui.bootstrap', 'ngTable']);

app.config(function ($routeProvider) {
    $routeProvider.when("/Dashboard", {
        controller: "dashboardController",
        templateUrl: "/app/views/dashboard.html"
    });

    $routeProvider.when("/Wizard", {
        templateUrl: "/app/views/wizard.html"
    });

    $routeProvider.when("/ManageCase", {
        controller: "manageCaseController",
        templateUrl: "/app/views/manageCase.html"
    });

    $routeProvider.when("/ManagePatient", {
        controller: "managePatientController",
        templateUrl: "/app/views/patientList.html"
    });

    $routeProvider.when("/CreatePatient", {
        controller: "createPatientController",
        templateUrl: "/app/views/createPatient.html"
    });

    $routeProvider.when("/Orders", {
        controller: "manageOrderController",
        templateUrl: "/app/views/manageOrder.html"
    });

    $routeProvider.when("/login", {
        controller: "loginController",
        templateUrl: "/app/views/login.html"
    });

    $routeProvider.when("/signup", {
        controller: "signupController",
        templateUrl: "/app/views/signup.html"
    });

    $routeProvider.when("/patients", {
        controller: "patientsController",
        templateUrl: "/app/views/patients.html"
    });

    $routeProvider.when("/refresh", {
        controller: "refreshController",
        templateUrl: "/app/views/refresh.html"
    });

    $routeProvider.when("/tokens", {
        controller: "tokensManagerController",
        templateUrl: "/app/views/tokens.html"
    });

    $routeProvider.when("/associate", {
        controller: "associateController",
        templateUrl: "/app/views/associate.html"
    });

    $routeProvider.otherwise({ redirectTo: "/Dashboard" });

});

//var serviceBase = 'http://localhost:26264/';
var serviceBase = 'http://allergimedapi.azurewebsites.net/';
app.constant('ngAuthSettings', {
    apiServiceBaseUri: serviceBase,
    clientId: 'ngAuthApp'
});

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

app.run(['authService', '$rootScope', '$location', 'caseService', function (authService, $rootScope, $location, caseService) {
    authService.fillAuthData();
    $rootScope.isLogin = false;
    $rootScope.finishedWizard = function () {
        var caseItem = caseService.getSelectedCase();
        if (caseItem !== null) {
            caseItem.status = 'pending';
            caseService.addCase(caseItem);
            caseService.setSelectedCase(null);
        }
        $location.path('/Dashboard');
    }
}]);
