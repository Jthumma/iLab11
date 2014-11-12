(function () {
    'use strict';

    var serviceId = 'authenticationDataService';
    angular.module('app').factory(serviceId, ['common', '$http', authenticationDataService]);

    function authenticationDataService(common, $http) {
        var $q = common.$q;

        var service = {
            getAuthenticatedUser: getAuthenticatedUser
            
        };
        return service;

        function getAuthenticatedUser() {
            var deferred = $q.defer();

            $http.get('/authentication/GetAuthorizedUser').success(deferred.resolve).error(deferred.reject);
            return deferred.promise;
        }
    }
})();