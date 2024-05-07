function EditUser(Id) {
    $.get("/Users/EditUserJ", { Id: Id }, function (data) {              //fetching data of the selected user from controller  
        if (data != null) {
            $("#tableUser").hide();
            $("#CreateUser").hide();
            $("#EditUser").show();

            //data contains the details of the user   
            // now showing those details in the textbox  

            $("#NameEdit").val(data.Name);
            $("#AddressEdit").val(data.Address);
            $("#PhoneNumberEdit").val(data.Phone_Number);
            $("#IdEdit").val(data.Id);
        }
    });
}


$("#btnSaveEdit").click(function () {
    var objUser = {};                      //same action as per creating the user  
    objUser.Id = $("#IdEdit").val();
    objUser.Name = $("#NameEdit").val();
    objUser.Address = $("#AddressEdit").val();
    objUser.Phone_Number = $("#PhoneNumberEdit").val();
    $.post("/Users/EditUserJ", { objUser: objUser }, function (data) {
        if (data != null) {
            location.reload();
            alert("User Edited");
        }
        else {
            alert("Error");
        }
    });
})  