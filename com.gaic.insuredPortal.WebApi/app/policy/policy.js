﻿(function () {
    'use strict';
    var controllerId = 'policy';
    angular.module('app').controller(controllerId, ['common', '$routeParams', 'policyDataService', 'authenticationDataService', policy]);

    function policy(common, $routeParams, policyDataService, authenticationDataService) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        //vm.agentInfo = {
        //    title: 'Agent information',
        //    description: 'Agent Andy - Agency Name, 123 Main St, Coloroado Springs, CO 56234'
        //};
        vm.policyNumber = $routeParams.policyNumber == ':policyNumber' ? '' : $routeParams.policyNumber;
        vm.messageCount = 0;
        vm.agentInfo = '';
        vm.policies = [];
        vm.User = '';
        vm.title = vm.policyNumber == '' ? 'Policies' : 'Policy';

        activate();

        function activate() {
            var promises = [getAuthenticatedUser(), getPolicies(), getAgentInfo()];
            common.activateController(promises, controllerId);
                //.then(function () { log('Activated Policy View'); });
        }

        function getAuthenticatedUser() {
            return authenticationDataService.getAuthenticatedUser().then(function (data) {
                return vm.User = data;
            });
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