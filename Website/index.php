<?php
include_once 'Header.inc.php';
?>

<!--Rik werkt aan dit document-->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="Styles/DefaultStyle.css">

    <title>App-otheek</title>

    <style>
        /*#region Login form*/
            #LoginBTN{
                width:100%;
                background-color:#187757;

                padding-top: 3%;
                padding-bottom: 3%;

                margin-top: 2%;
                margin-bottom: 2%;

                font-size: 120%;
                font-weight: bold;

                line-height: 25px;
                border-radius: 8px;

                border: 4px solid #0e4a36;
            }
            #LoginBTN:hover{
                background-color:#1aad7c;
                color:#4f4f4f;
                border-color:#21755a;
            }

            #Text-Loginfo{
                width:100%;
                
                padding-left: 2%;
                padding-top: 3%;
                padding-bottom: 3%;
                
                background-color:#ebebeb;

                font-size: 110%;
                font-weight: bold;

                border-radius: 8px;
                border: 4px solid #0e4a36;
            }
            #Text-Loginfo:hover{
                border-color:#21755a;
                background-color:#f5f5f5;
            }
            #Text-Loginfo:focus{
                border-color:#21755a;
                background-color:white;
            }

            #EM-LB{
                margin-top: 1.5%;
                margin-bottom: 1.5%;
            }
            #EM-LC{
                margin-top: 1.5%;
                margin-bottom: 1.5%;
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
        /*#endregion */

        /*#region Forgot password*/
            
            #For-Pas{
                color:#10c775;
                margin:0px;
            }
            #For-Pas:hover{
                color:#02f584;
            }

            /* popup */

            /* Popup container */
            .popup {
                position: relative;
                display: inline-block;
                cursor: pointer;
                text-align: center;
            }

            /* The actual popup (appears on top) */
            .popup .popuptext {
                visibility: hidden;
                width: 400px;

                border: 4px solid #177354;
                background-color: #ebebeb;
                color: black;

                text-align: center;

                padding: 10px 8px;
                position: absolute;
                z-index: 1;
                bottom: 30%;
                left: 50%;
                margin-left: -200px;
            }

            /* Toggle this class when clicking on the popup container (hide and show the popup) */
            .popup .show {
                visibility: visible;
            }
        /*#endregion */

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

            #EM-LB{
                padding-top: 1.5%;
                padding-bottom: 1.5%;
            }
            #EM-LC{
                padding-top: 1.5%;
                padding-bottom: 0%;
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
   
    <div class="Ma-fivper">
        <div id="EM-LB">
            <!--Email--> 
            <input placeholder="E-mail address..." type="text" name="EML" required  id="Text-Loginfo">
        </div>
        <div  id="EM-LC">
            <!--Password-->
            <input placeholder="Wachtwoord..." type="password" name="PSWD" required id="Text-Loginfo">
        </div>
        <div class="popup" onclick="myFunction()" id="For-Pas">Wachtwoord vergeten?
            <p class="popuptext" id="myPopup">
                Neem a.u.b. contact op met uw systeembeheer
                om uw wachtwoord te veranderen 
                <br><br> <!--Phonenumber go BRRRRR-->
                Tel:pl4c3h0ld3r
            </p>
        </div>
        <div id="EM-LB">
            <!--Login button-->
            <button type="submit" value="AUserWantsToLogin" name="Login" id="LoginBTN">Login</button>
        </div>
    </div>

<script>
    // When the user clicks on Wachtwoord vergeten, open the popup
    function myFunction() {
    var popup = document.getElementById("myPopup");
    popup.classList.toggle("show");
    }
</script>

</form>

<!--ErrorMessage-->
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
</html>


