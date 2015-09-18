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
            'patientName': 'Mike West',
            'intakeDate': '16-Sep-2015',
            'status': 'Pending Test Result'
        },
        {
            'id': '3',
            'patientName': 'David Ediloud',
            'intakeDate': '16-Sep-2015',
            'status': 'Pending Test Result'
        },
        {
            'id': '4',
            'patientName': 'Bradley Monte',
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

}]);