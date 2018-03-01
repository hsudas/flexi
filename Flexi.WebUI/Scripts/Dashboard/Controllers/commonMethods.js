
function ajaxRequest(link, method, bodyParameter,callback,isasync) {
    let ass = false;
    if (isasync) {
        ass = true;
    }
    $.ajax({
        type: method,
        url: serviceurl + link,
        async: ass,
        data: bodyParameter,
        headers: { "Content-Type": "application/json" },
        success: function (data) { 
            callback(data);
        },
        error: function(e){
            if (e.statusText) {
                alert(e.statusText);
            }
            else {
                alert(JSON.stringify(e));

            }
        }

    })
    }

function getUrlParameter(param, dummyPath) {
    var sPageURL = dummyPath || window.location.search.substring(1),
        sURLVariables = sPageURL.split(/[&||?]/),
        res;

    for (var i = 0; i < sURLVariables.length; i += 1) {
        var paramName = sURLVariables[i],
            sParameterName = (paramName || '').split('=');

        if (sParameterName[0] === param) {
            res = sParameterName[1];
        }
    }

    return res;
}

function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}