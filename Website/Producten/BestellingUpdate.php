<?php
include_once "../Include/DatabaseHandler.php";
include_once "../Include/SH.inc.php";

if(VerifySession()){
    $Medicijn = $_POST["MDC"];
    $Toename = $_POST["TNM"];
    $SameProdQuery = "SELECT * FROM $Medicijn WHERE ID = '1'";
    
    $SameProdResult = $Prodsconn -> query($SameProdQuery);
    $SameProdResultArr = $SameProdResult -> fetch_array();
    $Gewicht = $SameProdResultArr['Gewicht'];
    $Leverancier = $SameProdResultArr['Leverancier'];
    $Tpe = $SameProdResultArr['Type'];
    $CurrentDate = date('Y-m-d');
    $ExpiryMonth = date('m') + 2;
    $ExpiryYear = date('Y');
    if ($ExpiryMonth > 12)
    {
        $ExpiryYear = $ExpiryYear + 1; 
        $ExpiryMonth = $ExpiryMonth - 12;
    }
    $ExpiryDate = date("$ExpiryYear-$ExpiryMonth-d");
    
    $Query = "INSERT INTO $Medicijn(Aantal, Gewicht, Datum_ontvangen, Uiterste_datum, Type, Leverancier) VALUES('$Toename', '$Gewicht', '$CurrentDate', '$ExpiryDate', '$Tpe', '$Leverancier')";
    $Prodsconn -> query($Query);
    
    header("Location: ../../Bestellen.php");
} else {
    VerifySessionReturn("../../index.php", false);
}

?>