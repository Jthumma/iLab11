(function () {
    'use strict';
    var controllerId = 'claims';
    angular.module('app').controller(controllerId, ['common', 'authenticationDataService', 'claimsDataService', claims]);

    function claims(common, authenticationDataService, claimsDataService) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.User = '';
        vm.claims = [];
        vm.title = 'Claims History';

        activate();

        function activate() {
            common.activateController([getAuthenticatedUser(), getClaims()], controllerId)
                .then(function () { log('Activated Claims View'); });
        }

        function getAuthenticatedUser() {
            return authenticationDataService.getAuthenticatedUser().then(function (data) {
                return vm.User = data;
            });
        }

        function getClaims() {
            return claimsDataService.getClaims().then(function (data) {
                return vm.claims = data;
            });
        }
    }
})();