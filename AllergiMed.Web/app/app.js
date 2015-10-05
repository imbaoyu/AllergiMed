var app = angular.module('AllergiMedApp', ['ui.router', 'ui.bootstrap', 'LocalStorageModule', 'angular-loading-bar',
    'mgo-angular-wizard', 'ngTable']);

app.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {

    $stateProvider.state('dashboard', {
        url: '/Dashboard',
        templateUrl: '/app/views/dashboard.html',
        controller: 'dashboardController',
    })
    .state('wizard', {
        url: '/Wizard',
        templateUrl: '/app/views/wizard.html',
    })
    .state('manageCase', {
        url: '/ManageCase',
        templateUrl: '/app/views/manageCase.html',
        controller: 'manageCaseController'
    })
    .state('managePatient', {
        url: '/ManagePatient',
        templateUrl: '/app/views/patientList.html',
        controller: 'managePatientController'
    })
    .state('createPatient', {
        url: '/CreatePatient',
        templateUrl: '/app/views/createPatient.html',
        controller: 'createPatientController'
    })
    .state('orders', {
        url: '/Orders',
        templateUrl: '/app/views/manageOrder.html',
        controller: 'manageOrderController'
    })
    .state('login', {
        url: '/Login',
        templateUrl: '/app/views/login.html',
        controller: 'loginController'
    })
    .state('signup', {
        url: '/Signup',
        templateUrl: '/app/views/signup.html',
        controller: 'signupController'
    })
    .state('refresh', {
        url: '/refresh',
        templateUrl: '/app/views/refresh.html',
        controller: 'refreshController'
    })
    .state('tokens', {
        url: '/refresh',
        templateUrl: '/app/views/tokens.html',
        controller: 'tokensManagerController'
    })
    .state('associate', {
        url: '/associate',
        templateUrl: '/app/views/associate.html',
        controller: 'associateController'
    });

    $urlRouterProvider.otherwise('/Dashboard');

}]);

//var serviceBase = 'http://localhost:26264/';
var serviceBase = 'http://allergimedapi.azurewebsites.net/';
app.constant('ngAuthSettings', {
    apiServiceBaseUri: serviceBase,
    clientId: 'ngAuthApp'
});

//app.config(function ($httpProvider) {
//    $httpProvider.interceptors.push('authInterceptorService');
//});

app.run(['authService', '$rootScope', '$state', 'caseService', function (authService, $rootScope, $state, caseService) {
    //authService.fillAuthData();
    $rootScope.isLogin = false;
    $rootScope.finishedWizard = function () {
        var caseItem = caseService.getSelectedCase();
        if (caseItem !== null) {
            caseItem.status = 'pending';
            caseService.addCase(caseItem);
            caseService.setSelectedCase(null);
        }
        $state.go('dashboard');
    }
}]);
