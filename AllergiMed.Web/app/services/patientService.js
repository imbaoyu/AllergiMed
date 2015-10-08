'use strict';
app.factory('patientService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var patientServiceProduct = {};

    var collection = [
        {
            id: 1,
            patientName: 'John Novack',
            dob: '09-SEP-1968',
            gender: 'Male',
            phone: '576 654 7865',
            address: '123 Main Street',
            city: 'Miami',
            state: 'FL',
            zip: '12345'
        },
        {
            id: 2,
            patientName: 'Bradley Cardoza',
            dob: '22-JUL-1981',
            gender: 'Male',
            phone: '786 312 3390',
            address: '456 Back Street',
            city: 'Fort Lauderdale',
            state: 'FL',
            zip: '87345'
        },
        {
            id: 3,
            patientName: 'Mike West',
            dob: '13-OCT-1978',
            gender: 'Male',
            phone: '566 676 3451',
            address: 'Apt 304 Tent 33 34th street',
            city: 'Fort Lauderdale',
            state: 'FL',
            zip: '87346'
        },
        {
            id: 4,
            patientName: 'Bob Jindal',
            dob: '01-FEB-1958',
            gender: 'Male',
            phone: '431 765 1234',
            address: '17324 Masha Way',
            city: 'Coral Springs',
            state: 'FL',
            zip: '64354'
        },
        {
            id: 5,
            patientName: 'Jane Doe',
            dob: '13-OCT-1966',
            gender: 'Female',
            phone: '231 345 1874',
            address: '9988 Huntsman street',
            city: 'Miami Beach',
            state: 'FL',
            zip: '98345'
        },
        {
            id: 6,
            patientName: 'Chang Chan',
            dob: '23-NOV-1938',
            gender: 'Male',
            phone: '734 666 1765',
            address: '453 Walter Street',
            city: 'West Palm Beach',
            state: 'FL',
            zip: '23412'
        },
        {
            id: 7,
            patientName: 'Megan Lola',
            dob: '22-AUG-1992',
            gender: 'Female',
            phone: '145 453 6678',
            address: '786 Collin Ave',
            city: 'Delray Beach',
            state: 'FL',
            zip: '45334'
        },
        {
            id: 8,
            patientName: 'Gilian M. Wei',
            dob: '12-JAN-1988',
            gender: 'Female',
            phone: '786 333 1876',
            address: '33 Amsterdan Street',
            city: 'Boca Raton',
            state: 'FL',
            zip: '33434'
        },
        {
            id: 9,
            patientName: 'Animesh Podar',
            dob: '08-DEC-1976',
            gender: 'Male',
            phone: '786 543 7654',
            address: 'Apt 708, 1345 park ave',
            city: 'Deerfield Beach',
            state: 'FL',
            zip: '45362'
        },
        {
            id: 10,
            patientName: 'Nick Savirk',
            dob: '23-SEP-1990',
            gender: 'Male',
            phone: '765 345 3452',
            address: '3894 5th ave',
            city: 'Fort Lauderdale',
            state: 'FL',
            zip: '43212'
        },
        {
            id: 11,
            patientName: 'Jose Valdes',
            dob: '22-OCT-1987',
            gender: 'Male',
            phone: '987 343 2901',
            address: '1654 Broadway',
            city: 'Miami',
            state: 'FL',
            zip: '34352'
        }
    ];

    patientServiceProduct.selectedPatient = null;

    patientServiceProduct.setSelectedPatient = function (patient) {
        patientServiceProduct.selectedPatient = patient;
    };

    patientServiceProduct.getSelectedPatient = function () {
        return patientServiceProduct.selectedPatient;
    };

    patientServiceProduct.getAllPatients = function () {
        return collection;
    };

    patientServiceProduct.getPatientById = function (id) {
        for (var i = 0; i < collection.length; i++) {
            if (collection[i].id == id) {
                return collection[i];
            }
        }
        return null;
    };

    patientServiceProduct.deletePatientById = function (id) {
        for (var i = 0; i < collection.length; i++) {
            if (collection[i].id == id) {
                collection.splice(i, 1);
            }
        }
    };

    patientServiceProduct.addPatient = function (patient) {
        if (!patient) {
            return null;
        }

        for (var i = 0; i < collection.length; i++) {
            if (collection[i].id == patient.id) {
                //update the existing one
                collection[i] = patient;
                return patient;
            }
        }

        patient.id = collection.length+1;
        collection.push(patient);
        return patient;
    };

    return patientServiceProduct;

}]);