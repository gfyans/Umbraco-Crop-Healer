angular.module('umbraco').controller('CropHealerDashboardController',
    function ($scope, $http, cropHealerDashboardService) {
        $scope.RunCropHealer = function () {
            $scope.result = false;

            cropHealerDashboardService.runCropHealer().then(function (result) {
                console.log(result);
                $scope.result = result.data;
            });
        };
    });