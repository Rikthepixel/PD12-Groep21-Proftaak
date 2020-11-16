<?php
include_once 'SH.inc.php';

unset($_SESSION['Loggedin']);
unset($_SESSION['Voornaam']);
unset($_SESSION['Achternaam']);
unset($_SESSION['Email']);

$_SESSION['error'] = "SuccesLogout";

VerifySessionReturn('../../index.php', true); //To send you back to the login page

?>