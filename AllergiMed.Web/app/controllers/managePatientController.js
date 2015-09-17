'use strict';
app.controller('managePatientController', ['NgTableParams', function (NgTableParams) {
    var caseList = [
        {
            'id': '1',
            'patientName': 'John Dorr',
            'dob': '16-Sep-2015',
            'address': '123 Main Street'
        },
        {
            'id': '2',
            'patientName': 'Mike Sanity',
            'dob': '16-Sep-2015',
            'address': 'Apt 34, 7985 Commercial Ave'
        },
        {
            'id': '3',
            'patientName': 'Jose Valdes',
            'dob': '16-Sep-2015',
            'address': '798 Spanish River Street'
        },
        {
            'id': '4',
            'patientName': 'Jane Dores',
            'dob': '16-Sep-2015',
            'address': '762 66th Street'
        }
    ];

    this.tableParams = new NgTableParams({
        page: 1, // show first page
        count: 10 // count per page
    }, {
        filterDelay: 0,
        data: caseList
    });

}]).service('demoDataGenerator', function () {


    this.generateData = generateData;
});