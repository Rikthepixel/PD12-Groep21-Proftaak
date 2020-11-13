<?php
include_once '..\..\Database\DatabaseHandler.php';
include_once '..\..\Session\SH.inc.php';

$returnpage = "location: ../../index.php";

if (isset($_POST['Login'])) {

    if($_POST['Login'] == "AUserWantsToLogin"){

        include_once './LoginFunctions.php';

        $Email = mysqli_real_escape_string($Loginconn, $_POST['EML']);     
        $Email = stripslashes($Email);
        
        $Pass = mysqli_real_escape_string($Loginconn, $_POST['PSWD']);
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

?>