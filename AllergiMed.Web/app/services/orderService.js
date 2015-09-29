'use strict';
app.factory('orderService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var orderServiceProduct = {};

    var collection = [
        {
            id: 1,
            patientId: 5,
            panels: 'Weed, Mold, Insect, Epidermal',
            dosage: 'Low',
            approved: false,
            startingDate: '10-10-2015'
        },
        {
            id: 2,
            patientId: 7,
            panels: 'Grass, Weed, Tree, Epidermal',
            dosage: 'Medium',
            approved: false,
            startingDate: '10-05-2015'
        },
        {
            id: 3,
            patientId: 3,
            panels: 'All',
            dosage: 'High',
            approved: false,
            startingDate: '10-13-2015'
        },
        {
            id: 4,
            patientId: 1,
            panels: 'Weed, Mold, Epidermal',
            dosage: 'Maintenance',
            approved: false,
            startingDate: '11-02-2015'
        },
        {
            id: 5,
            patientId: 2,
            panels: 'Insect',
            dosage: 'High',
            approved: false,
            startingDate: '10-22-2015'
        },
        {
            id: 6,
            patientId: 3,
            panels: 'All',
            dosage: 'Maintenance',
            approved: false,
            startingDate: '10-03-2015'
        },
    ];

    orderServiceProduct.approveOrder = function (id) {
        var order = orderServiceProduct.getOrderById(id);
        order.approved = true;
    };

    orderServiceProduct.getAllOrders = function () {
        return collection;
    };

    orderServiceProduct.getOrderById = function (id) {
        for (var i = 0; i < collection.length; i++) {
            if (collection[i].id === id) {
                return collection[i];
            }
        }
        return null;
    };

    return orderServiceProduct;
}]);