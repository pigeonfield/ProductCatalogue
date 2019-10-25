(function () {
    "use strict";
    angular
        .module("productManagement")
        .controller("ProductCtrl",
                    ["productsSource",
                    ProductCtrl]);

    function ProductCtrl(productsSource) {
        var vm = this;
        
        productsSource.query(function (data) {
            vm.products = data;
        });
    }
}());