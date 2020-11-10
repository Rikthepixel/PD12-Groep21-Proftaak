<!--Rik werkt hier-->
<?php
session_start(); // Starts a session

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