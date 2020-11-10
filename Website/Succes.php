<?php
include './Session/SH.inc.php';
?>

<?php
if(isset($_GET['Loggedin'])){
    if($_GET['Loggedin'] != "true"){
        header("location: index.php?error=invalidsession");
        exit();  
    }
} else{
    header("location: index.php?error=invalidsession");
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
    <p> <?php echo ReadSessionVariable('Voornaam');?></p>
</body>
</html>