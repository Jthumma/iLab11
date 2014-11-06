(function () {
    'use strict';
    var controllerId = 'policy';
    angular.module('app').controller(controllerId, ['common', 'policyDataService', policy]);

    function policy(common, policyDataService) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        //vm.agentInfo = {
        //    title: 'Agent information',
        //    description: 'Agent Andy - Agency Name, 123 Main St, Coloroado Springs, CO 56234'
        //};
        vm.messageCount = 0;
        vm.agentInfo = '';
        vm.policies = [];
        vm.title = 'Policy';

        activate();

        function activate() {
            var promises = [getPolicies(), getAgentInfo()];
            common.activateController(promises, controllerId)
                .then(function () { log('Activated Policy View'); });
        }

        function getPolicies() {
            return policyDataService.getPolicies().then(function (data) {
                return vm.policies = data;
            });
        }

        function getAgentInfo() {
            return policyDataService.getAgentInfo().then(function (data) {
                return vm.agentInfo = data;
            });
        }
    }
})();