﻿var app = angular.module('AllergiMedApp', ['ngRoute', 'LocalStorageModule', 'angular-loading-bar',
    'mgo-angular-wizard', 'ui.bootstrap', 'ngTable']);

app.config(function ($routeProvider) {
    $routeProvider.when("/Dashboard", {
        templateUrl: "/app/views/dashboard.html"
    });

    $routeProvider.when("/Wizard", {
        templateUrl: "/app/views/wizard.html"
    });

    $routeProvider.when("/home", {
        controller: "homeController",
        templateUrl: "/app/views/home.html"
    });

    $routeProvider.when("/ManageCase", {
        controller: "manageCaseController",
        templateUrl: "/app/views/managecase.html"
    });

    //
    //$routeProvider.when("/manage", {
    //    controller: "homeController",
    //    templateUrl: "/app/views/home.html"
    //});

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

    $routeProvider.otherwise({ redirectTo: "/home" });

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

app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);
