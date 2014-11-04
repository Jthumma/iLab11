(function () {
    'use strict';
    var controllerId = 'billing';
    angular.module('app').controller(controllerId, ['common', billing]);

    function billing(common) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.title = 'Billing';

        activate();

        function activate() {
            common.activateController([], controllerId)
                .then(function () { log('Activated Billing View'); });
        }
    }
})();