(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("productsSource",
                ["$resource",
                "appSettings",
                productsSource])

    function productsSource($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/product/getproducts/:filter");

    }
}());