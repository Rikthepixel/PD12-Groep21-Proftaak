<?php

function loginUser($conn, $Email, $Password){

    $SuccesLocation = "location: ../../Succes.php";
    $returnpage = "location: ../../index.php";

    $_SESSION['Email'] = $Email;

    $LoginQuery = "SELECT * FROM User WHERE LOWER(Email) = LOWER('$Email') AND Password = '$Password'";
    $LoginResult = $conn -> query($LoginQuery);

    if($LoginResult->num_rows == 1){
        $IdentityQuery = "SELECT Voornaam FROM User WHERE LOWER(Email) = LOWER('$Email') AND Password = '$Password'";
        $IdentityResult = $conn -> query($IdentityQuery);
        $row = $IdentityResult -> fetch_assoc();
        
        $_SESSION['Voornaam'] = $row['Voornaam'];

        $IdentityQuery = "SELECT Achternaam FROM User WHERE LOWER(Email) = LOWER('$Email') AND Password = '$Password'";
        $IdentityResult = $conn -> query($IdentityQuery);
        $row = $IdentityResult -> fetch_assoc();
        
        $_SESSION['Achternaam'] = $row['Achternaam'];
        $_SESSION['Loggedin'] = true;
        
        Unset($_SESSION['error']);

        header("$SuccesLocation");
    } else {
        $_SESSION['error'] = "invaliddetails";
        header("$returnpage");
        exit();
    }
}

function emptyLogin($Email, $Password) {
    $result;
    if(empty($_POST['EML']) || empty($_POST['PSWD'])){
        $result = true;
    } else {
        $result = false;
    }

    return $result;
}

function ErrorMessage($Error){
    $result;
    if ($Error == "emptylogin"){
        $result = "Please enter login details";
    }
    if ($Error == "invaliddetails"){
        $result = "Please enter the correct login details";
    }
    if ($Error == "badsubmit"){
        $result = "Submittion to Login was bad, please try again";
    }
    if ($Error == "invalidsession"){
        $result = "Session was invalid or has expired. Please Login again";
    }
    if ($Error == "SuccesLogout"){
        $result = "You were succesfully logged out";
    }
    if ($Error == "LoginRequired"){
        $result = "This page requires you to be logged in, please login";
    }
    if ($Error == "A"){
        $result = "";
    }
    if ($Error == "AlreadyLoggedin"){
        $result = "You are already logged-in";
    }
    return $result;
}