<!--Rik werkt hier-->
<?php

session_start(); // Starts a session

function VerifySession(){
$result = true;
    if(!isset($_SESSION['Voornaam'])){
        $_SESSION['error'] = "invalidsession";
        $result = false;
    }
    if(!isset($_SESSION['Achternaam'])){
        $_SESSION['error'] = "invalidsession";
        $result = false;
    }
    if(!isset($_SESSION['Email'])){
        $_SESSION['error'] = "invalidsession";
        $result = false;
    }

    if(!isset($_SESSION['Loggedin'])){
        $_SESSION['error'] = "invalidsession";
        $result = false;
    } else if (isset($_SESSION['Loggedin'])){

        if($_SESSION['Loggedin'] == false){
            $_SESSION['error'] = "invalidsession";
            $result = false;
        }
    }
return $result;
}

//Gives the ability to carry over variables to other pages with a session
function StoreSessionVariable($VariableName, $VariableValue){
    $_SESSION["$VariableName"] = $VariableValue;
}

//Gives the ability to call perviously stored variables within a session
function ReadSessionVariable($VariableName){
    return $_SESSION["$VariableName"];
}

//Deletes all the stored variables and ends the session
function EndSession(){
    session_destroy();
}


?>