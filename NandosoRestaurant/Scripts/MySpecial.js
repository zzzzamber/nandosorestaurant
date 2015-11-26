﻿// We're using the module pattern here to make it easier to reuse
// this bit of code and seperate out our namespaces.
var MySpecial = (function () {

    // If you want to declare things that are private to the module, 
    // simply declare them here without returning them
    var privatethingy = 10;

    // Only things that are returned from this closure is exposed
    return {
        getMySpecial: function (callback) {

            // $ means that the function is being called from JQuery
            // We pass the parameters for the api as an object
            // The success function is called when the data is recieved
            // The callback allows us to pass this data back out main js file.
            $.ajax({
                type: "GET",
                dataType: "json",
                url: "https://nandosorestauranthome.azurewebsites.net/Special",
                success: function (data) {
                    callback(data);
                }
            });
        }
    }
}());