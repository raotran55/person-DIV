/////////////////////////////////////////////
    function jqAJAX(url, list) {
        var HTML = "";
        var jsonText = JSON.stringify({ list: list });
        
            $.ajax({
                type: "POST",
                url: url,
                data: jsonText,
                dataType: "json",
                async: false,
                contentType: "application/json; charset=utf-8",
                success: function (msg) { HTML = msg.d; }
            });//end ajax

        return HTML;
    }//end jqAJAX
/////////////////////////////////////////////