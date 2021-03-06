<?php
include_once "../../Include/SH.inc.php";
include_once "../../Include/DatabaseHandler.php";

//Needs:
//Login = AUserWantsToLogin
//IsApplication = true
//EML = UserEmail
//PSWD = UserPassword

$_SESSION['error'] = 'A';
if (isset($_POST['Login'])) {
    if($_POST['Login'] == "AUserWantsToLogin"){
        include_once 'LoginFunctions.php';

        if (isset($_POST['IsApplication'])){
            if ($_POST['IsApplication'] == "true"){
                $IsApplication = true;
            } 
        }
        
        $Email = mysqli_real_escape_string($Loginconn, $_POST['EML']);     
        $Email = stripslashes($Email);
        
        $Pass = mysqli_real_escape_string($Loginconn, $_POST['PSWD']);
        $Pass = stripslashes($Pass);
        //$Pass = md5($Pass);
        
        //If the login details are empty send the user back to the starting page
        if(emptyLogin($Email, $Pass)){
            $_SESSION['error'] = 'emptylogin';
            header("location:../../index.php");
            exit();
        } 

        if(isset($IsApplication)){
            if($IsApplication == true){
                //Log the user in
                loginApplication($Loginconn, $Email, $Pass, $IsApplication);
            } else {
                //Log the user in
                loginUser($Loginconn, $Email, $Pass, false);
            }
        } else{
            //Log the user in
            loginUser($Loginconn, $Email, $Pass, false);
        }


    } else {
        $_SESSION['error'] = 'badsubmit';
        header("location:../../index.php");
        exit();
    }
} 
else {
    $_SESSION['error'] = 'badsubmit';
    header("location:../../index.php");
    exit();
}