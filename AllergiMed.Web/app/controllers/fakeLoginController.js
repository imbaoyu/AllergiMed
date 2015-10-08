'use strict';
app.controller('fakeLoginController', ['$scope', '$rootScope', '$location', '$state',

    function ($scope, $rootScope, $location, $state) {
        $rootScope.isLogin = false;

        $scope.login = function () {
            if ($scope.username === 'doctor' && $scope.password === 'doctor') {
                $scope.error = null;
                $rootScope.isLogin = true;
                $state.go('dashboard');
            } else {
                $scope.error = 'Invalid Username or Password';
                $rootScope.isLogin = false;
            }
        }
    }]);