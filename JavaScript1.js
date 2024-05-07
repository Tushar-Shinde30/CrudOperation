<script type="text/javascript">
    $("#btnCreate").click(function () {  
        var objUser = { };                   //objUser is variable through which i am passing the details filled by the user to the controller
    objUser.Name = $("#Name").val();            //fetching value from the textbox
    objUser.Address = $("#Address").val();
    objUser.Phone_Number = $("#PhoneNumber").val();
    $.post("/Users/CreateUser", {objUser: objUser }, function (data)        //data is a variable which contains the data returned from the action method
    {  
            if (data != null) {
        alert("User Created");
    location.reload();       //for refreshing the page after saving   
            }
    else {
        alert("Error");  
            }  
        });  
    })
</script>