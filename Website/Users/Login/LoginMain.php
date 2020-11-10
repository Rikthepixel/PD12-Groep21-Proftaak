<?php
include '../../Session/SH.inc.php';

if (isset($_POST['Login'])) {
    if($_POST['Login'] == "AUserWantsToLogin"){

        $returnpage = "location: ../../index.php";

        include_once '../../Database/DatabaseHandler.php';

        $Email = mysqli_real_escape_string($conn, $_POST['EML']);     
        $Email = stripslashes($Email);
        
        $Pass = mysqli_real_escape_string($conn, $_POST['PSWD']);
        $Pass = stripslashes($Pass);
        //$Pass = md5($Pass);

        include_once 'LoginFunctions.php';
        
        //If the login details are empty send the user back to the starting page
        if(emptyLogin($Email, $Pass)){
            header("$returnpage?error=emptylogin");
            exit();
        } 
        
        //Log the user in
        loginUser($conn, $Email, $Pass);

    } else {
        header("$returnpage?error=badsubmit");
        exit();
    }
} 
else {
    header("$returnpage?error=badsubmit");
    exit();
}

?>