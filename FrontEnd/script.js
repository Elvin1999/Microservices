
let myUrl = "https://localhost:22950/c";

function GetAll(){
 $.ajax({
    type: 'GET',  // http method
    url: myUrl,
    contentType: "application/json; charset=utf-8",
    dataType: "json",


    success: function (data) {
        console.log(data);
        let content="";
        for (let i = 0; i < data.length; i++) {
            const element = data[i];

            content+=element.id+"  =  "+element.firstName+"<br>";
   
        }
        $("#AllContact").html(content);
    },
    error: function (errorMessage) {
        console.log(errorMessage);
    }
});   
}

function GetContactById(){
    let element=document.getElementById("ContactId");
   
    $.ajax({
        type: 'GET',  // http method
        url: myUrl+"/"+element.value,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
    
    
        success: function (data) {
            console.log(data);
            let content=data.firstName+"<br>";
            content+=data.lastName+"<br>";
            $("#Contact").html(content);
        },
        error: function (errorMessage) {
            console.log(errorMessage);
        }
    }); 

}


function AddContact(){

    let id=document.getElementById("Id").value;
    let firstName=document.getElementById("firstname").value;
    let lastName=document.getElementById("lastname").value;
    let obj={
        id:id,
        firstName:firstName,
        lastName:lastName
    };
console.log(obj);
    $.ajax({
                       type: 'POST',  // http method
                       url: myUrl,
                       data: JSON.stringify(obj),  // data to submit
                       contentType: "application/json; charset=utf-8",
                       dataType: "json",
        
                       success: function (data) {
                           console.log("Added successfully");
                       },
                       error: function (errorMessage) {
                           console.log(errorMessage);
                       }
                   });
}


function DeleteContact(){
    let element=document.getElementById("C_Id");
   
    $.ajax({
        type: 'DELETE',  // http method
        url: myUrl+"/"+element.value,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
 
        success: function (data) {
            console.log("Deleted");  
            $("#Result").html("<h2 style='color:green;'>Deleted Succesfully</h2>");
        },
        error: function (errorMessage) {
            console.log("Error"); 
            $("#Result").html("<h2 style='color:green;'>Deleted Succesfully</h2>"); 
            console.log(errorMessage);
        }
    }); 
}