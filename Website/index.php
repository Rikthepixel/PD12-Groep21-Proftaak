<?php
include './Session/SH.inc.php';
?>
<!--Rik werkt aan dit document-->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./Styles/LoginStyle.css">

    <title>App-otheek</title>
</head>

<Header id="Main-header">
    <h1>App-Otheek</h1>
</Header>

<!--invoer-->
<form action="./Users/Login/LoginMain.php" method="post" id="LoginForm">

    <!--Email-->
    <label>Email</label>
    <input placeholder="Email" type="text" name="EML" required>

    <br><br>

    <!--Password-->
    <label>Password</label>
    <input placeholder="Password" type="password" name="PSWD" required>

    <br><br>

    <!--Login button-->
    <button type="submit" value="AUserWantsToLogin" name="Login">Login</button>

</form>

<!--ErrorMessage-->
<p>
    <?php
        //if the error variable is set, then get the appropriate ErrorMessage

        if(isset($_GET['error'])) {
            include_once 'LoginFunctions.php';
            echo ErrorMessage($_GET['error']);
        }
    ?>
</p>
</html>


