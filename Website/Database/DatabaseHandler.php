<?php
    $dbservername = "192.168.44.186";
    $logindbname = "Users";
    $logindbusername = "Login";
    $logindbpassword = "LoginUser";

    $Loginconn = mysqli_connect($dbservername, $logindbusername, $logindbpassword, $logindbname);
    if (!$Loginconn){
        die("Connection failed: " . mysqli_connect_error());
    }

    //$dbservername = "192.168.44.186"; <-- de server
    //$dbname = "Users"; <- De database die je wilt zien
    //$dbusername = "Login"; <-- De database user zijn username
    //$dbpassword = "LoginUser"; <-- de database user zijn password

    //$conn = mysqli_connect($dbservername, $dbusername, $dbpassword, $dbname);
    //if (!$conn){
       // die("Connection failed: " . mysqli_connect_error());
    //}
