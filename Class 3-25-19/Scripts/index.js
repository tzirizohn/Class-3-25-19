$(() => {
    let x =0;
    $("#mybutton").on('click', function () {
       
        $("#person").append(`<div class="row">
       <div class="col-md-3">
           <input class="form-control" type="text" name="p[${x}].FirstName" placeholder="first name" />
       </div>
       <div class="col-md-3">
           <input class="form-control" type="text" name="p[${x}].LastName" placeholder="last name" />
       </div>
       <div class="col-md-3">
           <input class="form-control" type="text" name="p[${x}].Age" placeholder="age" />
       </div>
   </div>`)
       
    });  
    x++; 
});