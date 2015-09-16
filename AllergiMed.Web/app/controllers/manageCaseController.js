'use strict';
app.controller('manageCaseController', ['NgTableParams', function (NgTableParams) {
    var caseList = [
        {
            'id': '1',
            'patientName': 'John Dorr',
            'intakeDate': '16-Sep-2015',
            'status': 'Pending Test Result'
        },
        {
            'id': '2',
            'patientName': 'John Dorr',
            'intakeDate': '16-Sep-2015',
            'status': 'Pending Test Result'
        },
        {
            'id': '3',
            'patientName': 'John Dorr',
            'intakeDate': '16-Sep-2015',
            'status': 'Pending Test Result'
        },
        {
            'id': '4',
            'patientName': 'John Dorr',
            'intakeDate': '16-Sep-2015',
            'status': 'Pending Test Result'
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