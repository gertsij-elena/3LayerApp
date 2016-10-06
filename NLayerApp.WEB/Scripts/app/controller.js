(function () {
    'use strict';

    angular
       .module('myapp')
       .controller('myController', controller);
    function controller($scope) {
        //slider
        $scope.myInterval = 3000;
        $scope.noWrapSlides = false;
        $scope.active = 0;
        $scope.slides = [
          {
              image: '/Images/hotel.png'
          },
          {
              image: '/Images/standart.png'
          },
          {
              image: '/Images/hotel_washroom.png'
          },
          {
              image: '/Images/hotel_2mnumber.png'
          }
        ];
        //google map
        $scope.map = {
            center: {
                latitude: 55.711898,
                longitude: 9.5387363
            },
            zoom: 12,
            options: {
            },
            control: {}
        };
    }

})();
