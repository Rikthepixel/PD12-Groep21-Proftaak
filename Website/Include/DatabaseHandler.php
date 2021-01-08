<?php

    $Logindbservername = "192.168.1.10";
    $logindbname = "Users";
    $logindbusername = "Login";
    $logindbpassword = "LoginUser";

    $Loginconn = mysqli_connect($Logindbservername, $logindbusername, $logindbpassword, $logindbname);
    if (!$Loginconn) {
        die("Connection to the database fialed");
    }



    $Prodsdbservername = "192.168.1.10";
    $prodsdbname = "Medical";
    $prodsdbusername = "producten";
    $prodsdbpassword = "Doemaarwat1";

    $Prodsconn = mysqli_connect($Prodsdbservername, $prodsdbusername, $prodsdbpassword, $prodsdbname);
    if (!$Prodsconn) {
        die("Connection to the database fialed");
    }

    //$dbservername = "192.168.44.186"; <-- de server
    //$dbname = "Users"; <- De database die je wilt zien
    //$dbusername = "Login"; <-- De database user zijn username
    //$dbpassword = "LoginUser"; <-- de database user zijn password

    //$conn = mysqli_connect($dbservername, $dbusername, $dbpassword, $dbname);
    //if (!$conn){
       // die("Connection failed: " . mysqli_connect_error());
    //}
?>