(function () {
    'use strict';
    var controllerId = 'dashboard';
    angular.module('app').controller(controllerId, ['common', 'datacontext', 'dashboardDataService', 'authenticationDataService', dashboard]);

    function dashboard(common, datacontext, dashboardDataService, authenticationDataService) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        //vm.news = {
        //    title: 'Agent information',
        //    description: 'Agent Andy - Agency Name, 123 Main St, Coloroado Springs, CO 56234'
        //};
        vm.messageCount = 0;
        vm.policies = [];
        vm.claims = [];
        vm.User = '';
        vm.title = 'Dashboard';

        activate();

        function activate() {
            var promises = [getAuthenticatedUser(), getMessageCount(), getPolicies(), getClaims()];
            common.activateController(promises, controllerId)
                .then(function () { log('Activated Dashboard View'); });
        }

        function getAuthenticatedUser() {
            return authenticationDataService.getAuthenticatedUser().then(function (data) {
                return vm.User = data;
            });
        }

        function getMessageCount() {
            return datacontext.getMessageCount().then(function (data) {
                return vm.messageCount = data;
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