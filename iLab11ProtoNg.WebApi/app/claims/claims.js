(function () {
    'use strict';
    var controllerId = 'claims';
    angular.module('app').controller(controllerId, ['common', claims]);

    function claims(common) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.title = 'Claims';

        activate();

        function activate() {
            common.activateController([], controllerId)
                .then(function () { log('Activated Claims View'); });
        }
    }
})();