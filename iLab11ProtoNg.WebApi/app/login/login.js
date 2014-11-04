(function () {
    'use strict';
    var controllerId = 'dashboard';
    angular.module('app').controller(controllerId, ['common', 'datacontext', 'dashboardDataService', dashboard]);

    function dashboard(common, datacontext, dashboardDataService) {
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
        vm.title = 'Dashboard';

        activate();

        function activate() {
            var promises = [getMessageCount(), getPolicies(), getClaims()];
            common.activateController(promises, controllerId)
                .then(function () { log('Activated Dashboard View'); });
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