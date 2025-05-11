$(document).ready( function () {
    
    //GetStates();
});



$("#btnSaveEmployee").on("click", function () {
    formValidation()
});

function formValidation() {
    var name = $('#txtEmployeeName').val();
    var designation = $('#txtDesignation').val();
    var doj = $('#dtDOJ').val();
    var dob = $('#dtDOB').val();
    var salary = $('#txtSalary').val();
    var state = $('#ddlStates').val();
    var age = $('#txtAge').val();

    let isValid = true;
    if (name.trim() === '' || !name) {
        isValid = false;
        $('#lblNameError').html("please enter your name").css("color", "red");
        $('#txtEmployeeName').css("border", "0.5px solid red");
    }
    else {
        $('#lblNameError').html('');
        $('#txtEmployeeName').css("border", "");
    }

    if (name.trim() === '' || !name) {
        isValid = false;
        $('#lblDesignationError').html("please enter your designation").css("color", "red");
        $('#txtDesignation').css("border", "0.5px solid red");
    }
    else {
        $('#lblDesignationError').html('');
        $('#txtDesignation').css("border", "");
    }

    if (isValid === false) return;
}

function GetStates() {
    var ddlStates = $('#ddlStates');
    $.ajax({
        url: '/EmployeeInfo/GetStates',
        type: 'POST',
        success: function (respone) {
            var response = JSON.Parse(response);
            ddlStates.empty();

            for (var i = 0; i < response.length; i++) {
                ddlStates.append("<option value=" + respone[i].StateID + ">" + respone[i].StateName + "</option>");
            }

        }
    });
}
