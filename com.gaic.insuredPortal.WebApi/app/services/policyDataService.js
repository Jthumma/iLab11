(function () {
    'use strict';

    var serviceId = 'policyDataService';
    angular.module('app').factory(serviceId, ['common', '$http', policyDataService]);

    function policyDataService(common, $http) {
        var $q = common.$q;

        var service = {
            getPolicies: getPolicies,
            getAgentInfo: getAgentInfo
        };
        return service;


        function getPolicies() {
            var deferred = $q.defer();

            $http.get('/policy/GetPolicies').success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        }

        function getAgentInfo() {
            var deferred = $q.defer();

            $http.get('/policy/GetAgentInfo').success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        }
    }
})();