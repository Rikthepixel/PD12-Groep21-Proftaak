<?php

function loginUser($conn, $Email, $Password){
    $SuccesLocation = "location: ../Succes.php";
    $returnpage = "location: ../index.php";
    
    $query = "SELECT * FROM User WHERE LOWER(Email) = LOWER('$Email') AND Password = '$Password'";
    $result = $conn -> query($query);


    if($result->num_rows == 1){
       header("$SuccesLocation?Loggedin=true");
    } else {
        header("$returnpage?error=invaliddetails");
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
    return $result;
}

?>