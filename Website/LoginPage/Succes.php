<?php
if(isset($_GET['Loggedin'])){
    if($_GET['Loggedin'] != "true"){
        header("location: LoginPage.php?error=invalidsession");
        exit();  
    }
} else{
    header("location: LoginPage.php?error=invalidsession");
    exit();
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
    <p> SUCCES</p>
</body>
</html>