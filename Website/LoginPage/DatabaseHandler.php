<?php
    $dbservername = "192.168.44.186";
    $dbname = "users";
    $dbusername = "dbuser";
    $dbpassword = "Doemaarwat1";

    $conn = mysqli_connect($dbservername, $dbusername, $dbpassword, $dbname);

    if (!$conn){
        die("Connection failed: " . mysqli_connect_error());
    }