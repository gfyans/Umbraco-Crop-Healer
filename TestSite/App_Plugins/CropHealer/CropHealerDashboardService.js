angular.module('umbraco.resources').factory('cropHealerDashboardService',
    function ($q, $http) {
        var serviceRoot = 'backoffice/CropHealer/CropHealerApi/';

        return {
            runCropHealer: function () {
                return $http.get(serviceRoot + 'RunCropHealer');
            }
        }
    });