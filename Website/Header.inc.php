<?php
include_once 'Session/SH.inc.php';
include_once 'Database/DatabaseHandler.php';

if(!VerifySession()){
    $LoginOrLogoutDirectory = './index.php';
    $LoginOrLogout = "Login";
    $Currentfilename = basename($_SERVER['PHP_SELF']);

    if($Currentfilename != "index.php" && $Currentfilename != "LoginMain.php" && $Currentfilename != "LoginFunctions.php"){
        $_SESSION['error'] = "LoginRequired";
        header("Location: index.php");
        exit();
    }
}

if(VerifySession()){
    $LoginOrLogoutDirectory = './Users/Logout/Logout.php';
    $LoginOrLogout = "Logout";
    
    $Achternaam = $_SESSION['Achternaam'];
    $Voornaam = $_SESSION['Voornaam'];
    $DisplayName = "$Voornaam $Achternaam";
    $_SESSION['error'] = "AlreadyLoggedin";
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

    .header  {
    overflow: hidden;
    background-color: #187757;

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
    background-color: #1aad7c;
    color: black;
    }

    .header a.active {
    background-color: #0D5B41;
    color: white;
    }

    .header-right {
    float: right;
    }
    .header-left {
    float: left;
    }

    .header-right a{
        background-color:#1f8563;
        margin: 0em;
        margin-left: 0.1em;
        margin-right: 0.1em;
    }

    .header-nametag {
    float: right;
    }
    
    .header-nametag p{
    margin: 0em;
    margin-left: 0.1em;
    margin-right: 0.1em;
    position: relative;
    top: -50%;

    text-align: bold;
    font-weight: 2;
    padding: 12px;
    text-decoration: none;
    font-size: 14px; 
    line-height: 25px;
    border-radius: 4px;

    background-color: rgb(238, 238, 238);
    color: black;
    }

    #MHC-Mar{
        margin-top:40px;
        margin-bottom:40px;
        margin-left:0;
        margin-right:20px;
    }
    #US-ExM{
        margin-left:0.8em;
    }
    #FH-LEF{
    }
    
    @media screen and (max-width: 760px) {
    .header a {
        float: none;
        display: block;
        text-align: left;
    }
    .header-right a{
        margin: 0em;
    }
    .header-right {
        float: none;
    }
    .header-left {
        float: none;

    }
    .header-left img{
        display: block;
        margin-left: auto;
        margin-right: auto;
    }

    .header-right a{
        margin: 0em;
        margin-top: 0.2em;
        margin-bottom:0.2em;
    }

    .header-nametag {
        margin:auto;
        float: none;
    }
    .header-nametag p{
        float: none;
        margin: 0em;
        margin-top: 0.2em;
        margin-bottom:0.2em;
    }
    #US-ExM {
        margin: 0em;
        margin-bottom:1em;
    }
    #MHC-Mar{
        margin-top:40px;
        margin-bottom:40px;
        margin-left:20px;
        margin-right:20px;
    }
    }


</style>
</head>
<body>

    <div class="header">
         
        <div class="header-left" id="FH-LEF">
        <img src="/Styles/Logo.png" alt="App-Otheek" style="max-height:128px;max-width:200px;"/> 
        </div>
  
        <div class="header-right" id="MHC-Mar">

            <!--UserSpecific-->
            <div class="header-right" id="US-ExM">
                <div class="header-right">
                    <!--Login/Out -->
                    <a href="<?= $LoginOrLogoutDirectory ?>"><?= $LoginOrLogout ?></a>  
                </div>

                <!--Nametag -->
                <?php 
                    if(VerifySession()){;
                        echo '<div class="header-nametag">';
                        echo "<p style='font-weight: bold;'> $DisplayName </p>";
                        echo '</div>';
                    }
                ?>
            </div>
            <!--Tabs-->
            <div class="header-right">

                <!--Tabs -->
                <?php 
                    if(VerifySession()){
                        $ProdOver = DeterminActive('Productpage.php');
                        $hrefProdOver = "Productpage.php";
                        $Bestel = DeterminActive('Bestellen.php');
                        $hrefBestel = "Bestellen.php";
                        //$ZoekF = DeterminActive('Zoekfunctie.php');
                        //$hrefZoekF = "Producten/Zoekfunctie.php";


                        echo "<a $ProdOver href=$hrefProdOver>Product Overzicht</a>";
                        echo "<a $Bestel href=$hrefBestel>Bestellen</a>";
                        //echo "<a $ZoekF href=$hrefZoekF>Zoeken</a>";
                    }
                ?>
                
            </div>
        </div>
        
    </div>

</body>
</html>