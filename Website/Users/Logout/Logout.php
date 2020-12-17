<?php
include_once '../../Include/SH.inc.php';

unset($_SESSION['Loggedin']);
unset($_SESSION['Voornaam']);
unset($_SESSION['Achternaam']);
unset($_SESSION['Email']);
unset($_SESSION['UserRequestKey'])

unset($_COOKIE['RequestingKey']);
setcookie('RequestingKey', '', time() - 3600, '/');

$_SESSION['error'] = "SuccesLogout";

VerifySessionReturn('../../index.php', true); //To send you back to the login page

?>