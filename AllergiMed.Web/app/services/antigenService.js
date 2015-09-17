'use strict';
app.factory('antigenService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var antigenServiceFactory = {};

    var collection = [
        {
            index: 'A',
            name: 'GRASS',
            items: ['POSITIVE CONTROL', 'NEGATIVE CONTROL', 'ALFALFA', 'BERMUDA GRASS', 'JOHNSON GRASS', 'KENTUCKY BLUE', 'PERENNIAL RYE GRASS', 'TIMOTHY GRASS']
        },
        {
            index: 'B',
            name: 'WEEDS 1',
            items: ['BURWEED MARSH ELDER', 'CARELESS WEED', 'COCKLEBUR', 'COM MUGWORT SAGE', 'PRIVET', 'ENGLISH PLANTAIN', 'GIANT RAGWEED', 'KOCHIA']
        },
        {
            index: 'C',
            name: 'WEEDS 2',
            items: ['LAMBS QUARTERS', 'ROUGH PIGWEED', 'RUSSIAN THISTLE', 'SHEEP SORREL', 'SHORT RAGWEED', 'WESTERN WATER HEMP', 'CORN SMUT', 'VERTICILLIUM']
        },
        {
            index: 'D',
            name: 'TREES 1',
            items: ['BLACK WALNUT', 'BEECH AMERICAN', 'BOX ELDER', 'CEDAR RED', 'COTTONWOOD', 'ELM AMERICAN', 'SMOOTH BROME', 'MAPLE POLLEN']
        },
        {
            index: 'E',
            name: 'TREES 2',
            items: ['WINGSCALE', 'NETTLE POLLEN', 'NORTHERN RED OAK', 'OAK LIVE', 'OLIVE RUSSIAN', 'PECAN POLLEN', 'RED MULBERRY', 'ALTERNARIA']
        },
        {
            index: 'F',
            name: 'TREES 3',
            items: ['RED RIVER BIRTH', 'RHODOTORULA', 'SYCAMORE AMERICAN', 'TREE OF HEAVEN', 'WHITE ALDER', 'WHITE ASH', 'WHITE HICKORY', 'WHITE OAK']
        },
        {
            index: 'G',
            name: 'EPIDERMAL/INSECT',
            items: ['AMERICAN COCKROACH', 'ATRIPLEX MIXTURE', 'CAT HAIR', 'CATTLE HAIR', 'DOG HAIR', 'HORSE HAIR', 'MITE FARINAE', 'MITE PTERONYSIS']
        },
        {
            index: 'H',
            name: 'MOLDS',
            items: ['ASPERGILLUS', 'CANIDA ALBICANS', 'CEPHALOSPORIUM', 'CURVULARIA', 'FUSARIUM', 'HELMINTHOSPORIUM', 'PENICILLIUM NOTATUM', 'STEMPHYLIUM']
        },
        {
            index: 'I',
            name: 'FOODS',
            items: ['CACAO BEAN', 'CORN', 'COWS MILK', 'SOYBEAN', 'TOMATO', 'WHOLE EGGS', 'WHOLE GRAIN OAT', 'WHOLE WHEAT']
        }
    ];


    var getAntigens = function () {
        
        return collection;
    };

    antigenServiceFactory.getAntigens = getAntigens;

    return antigenServiceFactory;

}]);