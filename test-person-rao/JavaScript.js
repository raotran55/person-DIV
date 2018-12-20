$(document).ready(function () {
    
    //build HTML Person page
    var list = ['list item'];
    $('#contentMain').html(jqAJAX('Default.aspx/testStarter', list));
   
    // search event
    $("#myInput").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myDIV .row").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
    //  edit Modal click event 
    $(document).on('click', 'div.rowitems', function () {
        
        $(this).each(function () {
            
            $("#editModal").modal("show");
            $("#edit-id").val($(this).find("div.item").html());
            $("#modal-title").text("Edit Person - Id: " + $(this).find("div.item").html());
            $("#edit-firstname").val($(this).find("div.item:eq(1)").html());
            $("#edit-lastname").val($(this).find("div.item:eq(2)").html());
            $("#edit-dob").val($(this).find("div.item:eq(3)").html());
            $("#edit-gender").val($(this).find("div.item:eq(4)").html());
            $("#edit-code").val($(this).find("div.item:eq(5)").html());
        });
      
    });
    //
    // edit submit button click
    $('[id^=edit-btn]').on('click', function (e) {
      
        $('#editmessage').text("Edit Changes were successfully !!!! ...");
        $('#editmessage').fadeIn('slow', function () {
            $('#editmessage').delay(5000).fadeOut();
        });
       
        var editId = $("#edit-id").val();
        var editFname = $("#edit-firstname").val();
        var editLname = $("#edit-lastname").val();
        var editDob = $("#edit-dob").val();
        var editGender = $("#edit-gender").val();
        var editCode = $("#edit-code").val();
        $('.rowitems').each(function () {
            if (editId == $(this).find("div.item").html()) {
                $(this).find("div.item:eq(1)").html(editFname);
                $(this).find("div.item:eq(2)").html(editLname);
                $(this).find("div.item:eq(3)").html(editDob);
                $(this).find("div.item:eq(4)").html(editGender);
                $(this).find("div.item:eq(5)").html(editCode);
                return false;
            }

        });

    });
    //
    // save click
    $('[id^=new-btn]').on('click', function (e) {    
        //    
        var newFname = $("#new-firstname").val();
        var newLname = $("#new-lastname").val();
        var newDob = $("#new-dob").val();
        var newGender = $("#new-gender").val();
        var newCode = $("#new-code").val();
        var list = [newFname, newLname, newDob, newGender, newCode];
        var newc = jqAJAX('Default.aspx/addNewPerson', list);
        $('#newmessage').text("Edit Changes were successfully !!!! ...");
        $('#newmessage').fadeIn('slow', function () {
            $('#newmessage').delay(5000).fadeOut();
        });
        $("#myDIV").html(newc);
    

    });
    // edit submit button clickwindow.location.reload();
    $('[id^=new-close]').on('click', function (e) {
       
    });
});// end ready
