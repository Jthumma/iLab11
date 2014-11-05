(function () {
    'use strict';
    var controllerId = 'register';
    angular.module('app').controller(controllerId, ['common',  register]);

    function register(common) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        
        vm.title = 'Register';

        activate();

        function activate() {
            var promises = [];
            common.activateController(promises, controllerId)
                .then(function () { log('Activated Register View'); });
        }

        
    }
})();