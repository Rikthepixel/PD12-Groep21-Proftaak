<?php

if (isset($_POST["submit"])) {

    $Email = $_POST["EML"];
    $Password = $_POST["PSWD"];

    require_once 'DatabaseHandler.php';
    require_once 'LoginFunctions.php';

    loginUser($conn, $Email, $Password);
} 
else {
    header("location: LoginPage.php");
    exit();
}

?>