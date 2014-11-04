(function () {
    'use strict';

    var serviceId = 'datacontext';
    angular.module('app').factory(serviceId, ['common', datacontext]);

    function datacontext(common) {
        var $q = common.$q;

        var service = {
            getPeople: getPeople,
            getMessageCount: getMessageCount
        };

        return service;

        function getMessageCount() { return $q.when(3); }

        function getPeople() {
            var people = [
                { firstName: 'BAP 6542342 01', lastName: '01/01/2013', age: 25, location: 'Florida' },
                { firstName: 'XYZ 1245234 00', lastName: '05/05/2013', age: 31, location: 'California' },
                { firstName: 'ABC 6542347 02', lastName: '01/10/2014', age: 21, location: 'New York' },
                { firstName: 'STC 9860231 00', lastName: '11/01/2014', age: 18, location: 'North Dakota' }
                //{ firstName: 'Ella', lastName: 'Jobs', age: 18, location: 'South Dakota' },
                //{ firstName: 'Landon', lastName: 'Gates', age: 11, location: 'South Carolina' },
                //{ firstName: 'Haley', lastName: 'Guthrie', age: 35, location: 'Wyoming' }
            ];
            return $q.when(people);
        }
    }
})();