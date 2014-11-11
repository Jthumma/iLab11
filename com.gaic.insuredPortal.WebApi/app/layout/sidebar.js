(function () { 
    'use strict';
    
    var controllerId = 'sidebar';
    angular.module('app').controller(controllerId,
        ['$route', 'config', 'routes', 'common', 'authenticationDataService', sidebar]);

    function sidebar($route, config, routes, common, authenticationDataService) {
        var vm = this;

        vm.isCurrent = isCurrent;
        vm.User = '';
        activate();

        function activate() { getNavRoutes(); }
        
        function getNavRoutes() {
            vm.navRoutes = routes.filter(function(r) {
                return r.config.settings && r.config.settings.nav;
            }).sort(function(r1, r2) {
                return r1.config.settings.nav - r2.config.settings.nav;
            });

            var promises = [getAuthenticatedUser()];
            common.activateController(promises, controllerId);

        }
        
        function isCurrent(route) {
            if (!route.config.title || !$route.current || !$route.current.title) {
                return '';
            }
            var menuName = route.config.title;
            return $route.current.title.substr(0, menuName.length) === menuName ? 'current' : '';
        }

        function getAuthenticatedUser() {
            return authenticationDataService.getAuthenticatedUser().then(function (data) {
                return vm.User = data;
            });
        }
    };
})();
