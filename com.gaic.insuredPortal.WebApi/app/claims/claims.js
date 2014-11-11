﻿(function () {
    'use strict';
    var controllerId = 'claims';
    angular.module('app').controller(controllerId, ['common', 'authenticationDataService', claims]);

    function claims(common, authenticationDataService) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.User = '';
        vm.title = 'Claims';

        activate();

        function activate() {
            common.activateController([getAuthenticatedUser()], controllerId)
                .then(function () { log('Activated Claims View'); });
        }

        function getAuthenticatedUser() {
            return authenticationDataService.getAuthenticatedUser().then(function (data) {
                return vm.User = data;
            });
        }
    }
})();