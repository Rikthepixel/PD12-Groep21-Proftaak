<?php

if (isset($_POST['Login'])) {
    if($_POST['Login'] == "AUserWantsToLogin"){

        $returnpage = "location: ./index.php";

        $Email = $_POST['EML'];     
        $Email = stripslashes($Email);
        
        $Pass = $_POST['PSWD'];
        $Pass = stripslashes($Pass);
        //$Pass = md5($Pass);
        
        include_once 'DatabaseHandler.php';
        include_once 'LoginFunctions.php';
        
        if(emptyLogin($Email, $Pass)){
            header("$returnpage?error=emptylogin");
            exit();
        } 

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