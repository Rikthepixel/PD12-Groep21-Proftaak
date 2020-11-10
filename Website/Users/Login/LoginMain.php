<?php
include '../../Session/SH.inc.php';

if (isset($_POST['Login'])) {
    if($_POST['Login'] == "AUserWantsToLogin"){

        include_once '../../Database/DatabaseHandler.php';
        include_once 'LoginFunctions.php';

        $returnpage = "location: ../../index.php";

        $Email = mysqli_real_escape_string($conn, $_POST['EML']);     
        $Email = stripslashes($Email);
        
        $Pass = mysqli_real_escape_string($conn, $_POST['PSWD']);
        $Pass = stripslashes($Pass);
        //$Pass = md5($Pass);
        
        //If the login details are empty send the user back to the starting page
        if(emptyLogin($Email, $Pass)){
            $_SESSION['error'] = 'emptylogin';
            header("$returnpage");
            exit();
        } 
        
        //Log the user in
        loginUser($Loginconn, $Email, $Pass);

    } else {
        $_SESSION['error'] = 'badsubmit';
        header("$returnpage");
        exit();
    }
} 
else {
    $_SESSION['error'] = 'badsubmit';
    header("$returnpage");
    exit();
}