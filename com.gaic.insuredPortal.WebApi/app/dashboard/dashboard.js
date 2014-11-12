(function () {
    'use strict';
    var controllerId = 'dashboard';
    angular.module('app').controller(controllerId, ['common', 'dashboardDataService', 'authenticationDataService', dashboard]);

    function dashboard(common, dashboardDataService, authenticationDataService) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;

        vm.notifications = [];
        vm.policies = [];
        vm.claims = [];
        vm.bills = [];
        vm.User = '';
        vm.title = 'Dashboard';

        activate();

        function activate() {
            var promises = [getAuthenticatedUser(), getNotifications(), getPolicies(), getClaims()];
            common.activateController(promises, controllerId)
                .then(function () { log('Activated Dashboard View'); });
        }

        function getAuthenticatedUser() {
            return authenticationDataService.getAuthenticatedUser().then(function (data) {
                return vm.User = data;
            });
        }

        function getNotifications() {
            return dashboardDataService.getNotifications().then(function (data) {
                return vm.notifications = data;
            });
        }

        function getPolicies() {
            return dashboardDataService.getPolicies().then(function (data) {
                return vm.policies = data;
            });
        }

        function getClaims() {
            return dashboardDataService.getClaims().then(function (data) {
                return vm.claims = data;
            });
        }
    }
})();