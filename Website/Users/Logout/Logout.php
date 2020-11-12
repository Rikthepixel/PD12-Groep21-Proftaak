<?php




function LogoutUser(){
    unset($_SESSION['Loggedin']);
    unset($_SESSION['Voornaam']);
    unset($_SESSION['Achternaam']);
    unset($_SESSION['Email']);
    VerifySession(); //To send you back to the login page
}
?>