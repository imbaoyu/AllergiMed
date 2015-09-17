'use strict';
app.controller('indexController', ['$scope', '$location', 'authService', '$rootScope', function ($scope, $location, authService, $rootScope) {

    $scope.logOut = function () {
        //authService.logOut();
        $rootScope.isLogin = false;
        $location.path('/');
    }

    $scope.authentication = authService.authentication;
}]);