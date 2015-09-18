'use strict';
app.factory('patientService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var patientServiceFactory = {};

    var collection = [
        {
            id: 1,
            patientName: 'John Novack',
            dob: '09-SEP-1968',
            phone: '576 654 7865',
            address: '123 Main Street',
            city: 'Miami',
            state: 'FL',
            Zip: '12345'
        },
        {
            id: 2,
            patientName: 'Bradley Cardoza',
            dob: '22-JUL-1981',
            phone: '786 312 3390',
            address: '456 Back Street',
            city: 'Fort Lauderdale',
            state: 'FL',
            Zip: '87345'
        },
        {
            id: 3,
            patientName: 'Mike West',
            dob: '13-OCT-1978',
            phone: '566 676 3451',
            address: 'Apt 304 Tent 33 34th street',
            city: 'Fort Lauderdale',
            state: 'FL',
            Zip: '87346'
        },
        {
            id: 4,
            patientName: 'Bob Jindal',
            dob: '01-FEB-1958',
            phone: '431 765 1234',
            address: '17324 Masha Way',
            city: 'Coral Springs',
            state: 'FL',
            Zip: '64354'
        },
        {
            id: 5,
            patientName: 'Jane Doe',
            dob: '13-OCT-1966',
            phone: '231 345 1874',
            address: '9988 Huntsman street',
            city: 'Miami Beach',
            state: 'FL',
            Zip: '98345'
        },
        {
            id: 6,
            patientName: 'Chang Chan',
            dob: '23-NOV-1938',
            phone: '734 666 1765',
            address: '453 Walter Street',
            city: 'West Palm Beach',
            state: 'FL',
            Zip: '23412'
        },
        {
            id: 7,
            patientName: 'Megan Lola',
            dob: '22-AUG-1992',
            phone: '145 453 6678',
            address: '786 Collin Ave',
            city: 'Delray Beach',
            state: 'FL',
            Zip: '45334'
        },
        {
            id: 8,
            patientName: 'Gilian M. Wei',
            dob: '12-JAN-1988',
            phone: '786 333 1876',
            address: '33 Amsterdan Street',
            city: 'Boca Raton',
            state: 'FL',
            Zip: '33434'
        },
        {
            id: 9,
            patientName: 'Animesh Podar',
            dob: '08-DEC-1976',
            phone: '786 543 7654',
            address: 'Apt 708, 1345 park ave',
            city: 'Deerfield Beach',
            state: 'FL',
            Zip: '45362'
        },
        {
            id: 10,
            patientName: 'Nick Savirk',
            dob: '23-SEP-1990',
            phone: '765 345 3452',
            address: '3894 5th ave',
            city: 'Fort Lauderdale',
            state: 'FL',
            Zip: '43212'
        },
        {
            id: 11,
            patientName: 'Jose Valdes',
            dob: '22-OCT-1987',
            phone: '987 343 2901',
            address: '1654 Broadway',
            city: 'Miami',
            state: 'FL',
            Zip: '34352'
        }
    ];


    var getPatients = function () {
        return collection;
    };

    var getPatient = function (id) {
        for (var i = 0; i < collection.length; i++) {
            if (collection[i].id === id) {
                return collection[i];
            }
        }
        return null;
    };

    var addPatient = function (patient) {
        patient.id = collection.length;
        collection.push(patient);
    };

    patientServiceFactory.getPatients = getPatients;
    patientServiceFactory.getPatient = getPatient;
    patientServiceFactory.addPatient = addPatient;

    return patientServiceFactory;

}]);