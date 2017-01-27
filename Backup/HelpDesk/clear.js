function clear_Fields() {
    document.getElementById("fnameTB").value = '';
    document.getElementById("lnameTB").value = '';
    document.getElementById("emailTB").value = '';
    document.getElementById("ddlSeverity").options.length = 0;
    document.getElementById("ddlStatus").options.length = 0;
    document.getElementById("ddlDept").options.length = 0;
    document.getElementById("commentsTB").value = '';
    document.getElementById("ddlEmp").options.length = 0;
}