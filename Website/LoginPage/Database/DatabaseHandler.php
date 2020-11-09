<?php
    $dbservername = "192.168.44.186";
    $dbname = "Users";
    $dbusername = "Login";
    $dbpassword = "LoginUser";

    $conn = mysqli_connect($dbservername, $dbusername, $dbpassword, $dbname);

    if (!$conn){
        die("Connection failed: " . mysqli_connect_error());
    }