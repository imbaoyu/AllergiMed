var app = angular.module('AllergiMedApp', ['ui.router', 'ui.bootstrap', 'LocalStorageModule', 'angular-loading-bar',
    'mgo-angular-wizard', 'ngTable']);

app.config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {

    $stateProvider.state('dashboard', {
        url: '/dashboard',
        templateUrl: '/app/views/dashboard.html',
        controller: 'dashboardController',
    })
    .state('listPatient', {
        url: '/listPatient',
        templateUrl: '/app/views/listPatient.html',
        controller: 'listPatientController as controller'
    })
    .state('createPatient', {
        url: '/createPatient',
        templateUrl: '/app/views/updatePatient.html',
        controller: 'updatePatientController'
    })
    .state('editPatient', {
        url: '/editPatient/:patientId',
        templateUrl: '/app/views/updatePatient.html',
        controller: 'updatePatientController'
    })
    .state('viewPatient', {
        url: '/viewPatient/:patientId',
        templateUrl: '/app/views/viewPatient.html',
        controller: 'viewPatientController as controller'
    })
    .state('wizard', {
        url: '/wizard',
        templateUrl: '/app/views/wizard.html',
    })
    .state('manageCase', {
        url: '/manageCase',
        templateUrl: '/app/views/manageCase.html',
        controller: 'manageCaseController'
    })
    .state('orders', {
        url: '/orders',
        templateUrl: '/app/views/manageOrder.html',
        controller: 'manageOrderController'
    })
    .state('login', {
        url: '/login',
        templateUrl: '/app/views/login.html',
        controller: 'loginController'
    })
    .state('signup', {
        url: '/signup',
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

    $urlRouterProvider.otherwise('/dashboard');

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
