(function () {
    'use strict';
    var controllerId = 'policy';
    angular.module('app').controller(controllerId, ['common', policy]);

    function policy(common) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.title = 'Policy';

        activate();

        function activate() {
            common.activateController([], controllerId)
                .then(function () { log('Activated Policy View'); });
        }
    }
})();