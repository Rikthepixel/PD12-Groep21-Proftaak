<?php
include_once 'Header.inc.php';
?>

<!--Rik werkt aan dit document-->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./Styles/DefaultStyle.css">

    <title>App-otheek</title>

    <style>
        #LoginBTN{
            width:100%;
            background-color:#187757;
            padding-top: 3%;
            padding-bottom: 3%;

            font-size: 110%;
            font-weight: bold;

            line-height: 25px;
            border-radius: 8px;

            border: 4px solid #0e4a36;
        }
        #Text-Loginfo{
            width:100%;
            padding-left: 2%;
            padding-top: 3%;
            padding-bottom: 3%;

            font-size: 110%;
            font-weight: bold;

            border-radius: 8px;
            border: 4px solid #0e4a36;
        }
        .Ma-tenper{
            width:30%;
            flex:nowrap;
            float:right;
        }
        .Ma-fivper{
            width:40%;
            flex:nowrap;
            display:inline-block;
        }

        @media screen and (max-width: 760px) {
            #LoginBTN{
            width:100%;
            background-color:#187757;
            padding-left: 1%;
            padding-top: 3%;
            padding-bottom: 3%;
 
            line-height: 25px;
            }

            #Text-Loginfo{
            width:100%;
            padding-top: 3%;
            padding-bottom: 3%;
            }

            .Ma-tenper{
            width:20%;
            flex:nowrap;
            float:left;
            }
            .Ma-fivper{
            width:92%;
            flex:nowrap;
            display:inline-block;
        }
        }
    </style>
</head>

<!--invoer-->
<form action="./Users/Login/LoginMain.php" method="post" id="LoginForm">
    <div class="Ma-tenper">
        <div>
        </div>
    </div>
    <div class="Ma-fivper">
        <div>
        <input placeholder="E-mail address..." type="text" name="EML" required  id="Text-Loginfo">
        </div>
    </div>

    <!--Email-->


    <br><br>

    <!--Password-->
    <div class="Ma-tenper">
        <div>
        </div>
    </div>
    <div class="Ma-fivper">
        <div>
            <input placeholder="Password..." type="password" name="PSWD" required id="Text-Loginfo">
        </div>
    </div>


    <br><br>

    <!--Login button-->
    <div class="Ma-tenper">
        <div>
        </div>
    </div>
    <div class="Ma-fivper">
        <div>
        <button type="submit" value="AUserWantsToLogin" name="Login" id="LoginBTN">Login</button>
        </div>
    </div>


</form>

<!--ErrorMessage-->
<p>
    <?php
        //if the error variable is set, then get the appropriate ErrorMessage

        if(isset($_SESSION['error'])) {
            include_once './Users/Login/LoginFunctions.php';
            $errormsg = ErrorMessage($_SESSION['error']);
            echo "<div style='text-align: center;'> <div> <p> $errormsg </p> </div></div>";


            if($_SESSION['error'] == "LoginRequired" || $_SESSION['error'] == "SuccesLogout" || $_SESSION['error'] == "invalidsession" || $_SESSION['error'] == "invaliddetails"){
                $_SESSION['error'] = "A";
            }
        }
    ?>
</p>

</html>


