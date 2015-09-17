'use strict';
app.controller('fakeLoginController', ['$scope', '$rootScope', '$location', function ($scope, $rootScope, $location) {
    $rootScope.isLogin = false;

    $scope.login = function () {
        if ($scope.username === 'doctor' && $scope.password === 'doctor') {
            $scope.error = null;
            $rootScope.isLogin = true;
        } else {
            $scope.error = 'Invalid Username or Password';
            $rootScope.isLogin = false;
        }
    }
}]);