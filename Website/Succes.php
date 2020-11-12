<?php
include_once './Session/SH.inc.php';

if(!VerifySession()){
    if(ReadSessionVariable('Loggedin') != "true"){
        StoreSessionVariable('error', 'invalidsession');
        header("location: index.php");
        exit();  
    }
}

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <p> 
        <?php 

        if(isset($_SESSION['Voornaam'])) {
            echo ($_SESSION['Voornaam']);
        }
        ?>
    </p>

    <p> 
        <?php 

        if(isset($_SESSION['Achternaam'])) {
            echo ($_SESSION['Achternaam']);
        }
        ?>
    </p>


</body>
</html>