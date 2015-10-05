'use strict';
app.controller('indexController', ['$scope', '$state', 'authService', '$rootScope', function ($scope, $state, authService, $rootScope) {

    $scope.logOut = function () {
        //authService.logOut();
        $rootScope.isLogin = false;
        $state.go('login');
    }

    $scope.authentication = authService.authentication;
}]);