<?php
include_once 'Session/SH.inc.php';
include_once 'Database/DatabaseHandler.php';

if(!VerifySession()){
    $LoginOrLogoutDirectory = './index.php';
    $LoginOrLogout = "Login";
}

if(VerifySession()){
    $LoginOrLogoutDirectory = './Users/Logout/Logout.php';
    $LoginOrLogout = "Logout";
    
    $Achternaam = $_SESSION['Achternaam'];
    $Voornaam = $_SESSION['Voornaam'];
    $DisplayName = "$Voornaam $Achternaam";
}

function DeterminActive($LinkTarget){
$Currentfilename = basename($_SERVER['PHP_SELF']);
    if ($Currentfilename == $LinkTarget){
        $result = "class=active";   
    } else {
        $result = " ";
    }
    return $result;
}
?>

<!DOCTYPE html>
<html>
<head>
<title>App-Otheek</title>

<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
    
    * {box-sizing: border-box;}

    body { 
    margin: 0;
    font-family: Arial, Helvetica, sans-serif;
    }

    .header {
    overflow: hidden;
    background-color: #187757;
    padding: 40px 20px;
    }

    .header a {
    float: left;
    color: black;

    text-align: center;
    padding: 12px;
    text-decoration: none;
    font-size: 18px; 
    line-height: 25px;
    border-radius: 4px;
    }

    .header a.logo {
    font-size: 25px;
    font-weight: bold;
    }

    .header a:hover {
    background-color: #ddd;
    color: black;
    }

    .header a.active {
    background-color: #0D5B41;
    color: white;
    }

    .header-right {
    float: right;
    }

    .header-right a{
    background-color:#1f8563;
    }

    .header-nametag {
    float: inline-start;
    }
    .header-nametag p{
    margin: 0em;
    position: relative;
    top: -50%;

    text-align: bold;
    font-weight: 2;
    padding: 12px;
    text-decoration: none;
    font-size: 14px; 
    line-height: 25px;
    border-radius: 4px;

    background-color: rgb(255, 255, 255);
    color: black;
    }

    @media screen and (max-width: 500px) {
    .header a {
        float: none;
        display: block;
        text-align: left;
    }
    
    .header-right {
        float: none;
    }

    .header-nametag {
        float: none;
    }
    }
</style>
</head>
<body>

    <div class="header">

        <div class="header-right">

            <!--Tabs -->
            <?php 
                if(VerifySession()){
                    $ProdOver = DeterminActive('Productpage.php');
                    $hrefProdOver = "Producten/Productpage.php";
                    $ZoekF = DeterminActive('Zoekfunctie.php');
                    $hrefZoekF = "Producten/Zoekfunctie.php";
                    $Bestel = DeterminActive('Bestellingen.php');
                    $hrefBestel = "Producten/Bestellingen.php";

                    echo "<a $ProdOver href=$hrefProdOver>Product Overzicht</a>";
                    echo "<a $ZoekF href=$hrefZoekF>Zoeken</a>";
                    echo "<a $Bestel href=$hrefBestel>Bestellen</a>";
                    echo '<div class="header-nametag">';
                    echo "<p style='font-weight: bold;'> $DisplayName </p>";
                    echo '</div>';
                }
            ?>

            <!--Login/Out -->
            <a href="<?= $LoginOrLogoutDirectory ?>"><?= $LoginOrLogout ?></a>
            
        </div>
    </div>

</body>
</html>