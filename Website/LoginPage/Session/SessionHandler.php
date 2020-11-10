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
?>