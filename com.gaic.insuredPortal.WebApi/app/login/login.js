(function () {
    'use strict';
    var controllerId = 'login';
    angular.module('app').controller(controllerId, ['common','$location', login]);

    function login(common, $location) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.userId = '';
        vm.pwd = '';
        vm.doLogin();
        vm.redirectToRegister();
        vm.title = 'Login';

        activate();

        function activate() {
            var promises = [];
            common.activateController(promises, controllerId)
                .then(function () { log('Activated Login View'); });
        }

        function doLogin() {
            
        };

        function redirectToRegister() {
            $location.path('/register');
        };
    }
})();