'use strict';
app.controller('manageOrderController', ['$scope', '$filter', '$location', 'NgTableParams', 'orderService', 'patientService',
    function ($scope, $filter, $location, NgTableParams, orderService, patientService) {

        var orderList = orderService.getAllOrders();

        for (var i = 0; i < orderList.length; i++) {
            orderList[i].patient = patientService.getPatientById(orderList[i].patientId);
        }

        $scope.approve = function (orderId) {
            orderService.approveOrder(orderId);
        };

        this.tableParams = new NgTableParams(
        {
            page: 1,
            count: 10
        },
        {
            total: orderList.length,
            counts: [10, 25, 50],
            filterDelay: 0,
            getData: function ($defer, params) {
                var filteredData = params.filter() ? $filter('filter')(orderList, params.filter()) : orderList;
                var orderedData = params.sorting() ? $filter('orderBy')(filteredData, params.orderBy()) : filteredData;
                var slicedData = orderedData.slice((params.page() - 1) * params.count(), params.page() * params.count());
                params.total(orderedData.length);
                $defer.resolve(slicedData);
            }
        });
}]);