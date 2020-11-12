<?php
include_once '../Database/DatabaseHandler.php';
$Datum = '2020-10-05';
$testquery = "SELECT Gewicht from Xanac where Datum_ontvangen = '$Datum'";
$queryresult = $Prodsconn -> query($testquery);
$row = $queryresult -> fetch_assoc();

echo '<p>';
echo "$row[Gewicht]";
echo '</p>';