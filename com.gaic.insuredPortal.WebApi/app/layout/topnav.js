(function () {
    'use strict';
    var controllerId = 'topnav';
    angular.module('app').controller(controllerId, ['common','authenticationDataService', topnav]);

    function topnav(common, authenticationDataService) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.title = 'Top Nav';
        vm.User = '';

        activate();

        function activate() {
            common.activateController([getAuthenticatedUser()], controllerId);
        }

        function getAuthenticatedUser() {
            return authenticationDataService.getAuthenticatedUser().then(function (data) {
                return vm.User = data;
            });
        }
    }
})();