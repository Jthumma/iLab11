(function () {
    'use strict';
    var controllerId = 'reports';
    angular.module('app').controller(controllerId, ['common', 'authenticationDataService', reports]);

    function reports(common, authenticationDataService) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.User = '';
        
        vm.title = 'Reports';

        activate();

        function activate() {
            common.activateController([getAuthenticatedUser()], controllerId)
                .then(function () { log('Activated Reports View'); });
        }

        function getAuthenticatedUser() {
            return authenticationDataService.getAuthenticatedUser().then(function (data) {
                return vm.User = data;
            });
        }

        
    }
})();