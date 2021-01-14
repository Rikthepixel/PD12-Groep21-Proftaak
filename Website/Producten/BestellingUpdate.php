<?php
include_once "../Include/DatabaseHandler.php";
include_once "../Include/SH.inc.php";

if(VerifySession()){
    $Medicijn = $_POST["MDC"];
    $Toename = $_POST["TNM"];
    $GewichtQuery = "SELECT Gewicht FROM $Medicijn WHERE ID = '1'";
    
    $GewichtResult = $Prodsconn -> query($GewichtQuery);
    $GewichtArr = $GewichtResult -> fetch_array();
    $Gewicht = $GewichtArr[0];
    $CurrentDate = date('Y-m-d');
    $ExpiryMonth = date('m') + 2;
    $ExpiryYear = date('Y');
    if ($ExpiryMonth > 12)
    {
        $ExpiryYear = $ExpiryYear + 1; 
        $ExpiryMonth = $ExpiryMonth - 12;
    }
    $ExpiryDate = date("$ExpiryYear-$ExpiryMonth-d");
    
    $Query = "INSERT INTO $Medicijn(Aantal, Gewicht, Datum_ontvangen, Uiterste_datum) 
    VALUES('$Toename', '$Gewicht', '$CurrentDate', '$ExpiryDate')";
    $Prodsconn -> query($Query);
    
    header("Location: ../../Bestellen.php");
} else {
    VerifySessionReturn("../../index.php", false);
}

?>