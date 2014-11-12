(function () {
    'use strict';

    var serviceId = 'claimsDataService';
    angular.module('app').factory(serviceId, ['common', '$http', claimsDataService]);

    function claimsDataService(common, $http) {
        var $q = common.$q;

        var service = {
            getClaims: getClaims,
            
        };
        return service;

        function getClaims() {
            var deferred = $q.defer();

            $http.get('/claims/GetClaims').success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        }
    }
})();