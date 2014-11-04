(function () {
    'use strict';

    var serviceId = 'dashboardDataService';
    angular.module('app').factory(serviceId, ['common', '$http', dashboardDataService]);

    function dashboardDataService(common, $http) {
        var $q = common.$q;

        var service = {
            getClaims: getClaims,
            getPolicies: getPolicies,
            getMessageCount: getMessageCount
            
        };
        return service;

        function getMessageCount() { return $q.when(3); }

        function getPolicies() {
            //var people = [
            //    { firstName: 'BAP 6542342 01', lastName: '01/01/2013', age: 25, location: 'Florida' },
            //    { firstName: 'XYZ 1245234 00', lastName: '05/05/2013', age: 31, location: 'California' },
            //    { firstName: 'ABC 6542347 02', lastName: '01/10/2014', age: 21, location: 'New York' },
            //    { firstName: 'STC 9860231 00', lastName: '11/01/2014', age: 18, location: 'North Dakota' }
            //    //{ firstName: 'Ella', lastName: 'Jobs', age: 18, location: 'South Dakota' },
            //    //{ firstName: 'Landon', lastName: 'Gates', age: 11, location: 'South Carolina' },
            //    //{ firstName: 'Haley', lastName: 'Guthrie', age: 35, location: 'Wyoming' }
            //];
            //return $q.when(people);

            var deferred = $q.defer();

            $http.get('/dashboard/GetPolicies').success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        }

        function getClaims() {
            var deferred = $q.defer();

            $http.get('/dashboard/GetClaims').success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        }
    }
})();