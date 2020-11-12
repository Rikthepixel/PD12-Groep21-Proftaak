<?php
include_once './Session/SH.inc.php';
include_once './Users/Logout/Logout.php';
include_once './Database/DatabaseHandler.php';
?>

<!DOCTYPE html>
<html>
<head>

<link rel="stylesheet" href="./Styles/HeaderStyle.css">
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
* {box-sizing: border-box;}
</style>
</head>
<body>

<div class="header">
  <a href="#default" class="logo"><img scr="./Styles/App-Otheeklogofullnobackground.png" alt="App-otheek"></a>
  <div class="header-right">
    <a class="active" href="#./Producten/">Product Overzicht</a>
    <a href="./Producten/Zoekfunctie.php">Zoeken</a>
    <a href="./Producten/Bestellingen.php">Bestellen</a>
  </div>
</div>

</body>
</html>