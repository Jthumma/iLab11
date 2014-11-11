(function () {
    'use strict';
    var controllerId = 'billing';
    angular.module('app').controller(controllerId, ['common','authenticationDataService', billing]);

    function billing(common, authenticationDataService) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.User = '';
        vm.title = 'Billing';

        activate();

        function activate() {
            common.activateController([getAuthenticatedUser()], controllerId)
                .then(function () { log('Activated Billing View'); });
        }

        function getAuthenticatedUser() {
            return authenticationDataService.getAuthenticatedUser().then(function (data) {
                return vm.User = data;
            });
        }

    }
})();