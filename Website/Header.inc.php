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
    $LoginOrLogout = "Uitloggen";
   
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
    margin:0px;
    font-family: Arial, Helvetica, sans-serif;
    }

    .header {
    overflow: hidden;
    background-color: #187757;
    height:150px;
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

    .header a:hover {
    background-color: #1aad7c;
    color:#4f4f4f;
    }

    .header a.active {
    background-color: #0D5B41;
    color: white;
    }

    .header-right {
        float: right;
        margin:0px;
    }
    
    .header-left {
        float: left;
        margin:0px;
    }

    .header-right a{
        background-color:#1f8563;
        margin: 0px;
        margin-left: 3px;
        margin-right: 3px;
        display:inline;
    }

    .header-nametag {
        float: right;
    }
    
    .header-nametag p{

        margin: 0px;
        margin-left: 3px;
        margin-right: 3px;
        position: relative;
        top: -50%;
        
        text-decoration: none;
        text-align: bold;

        font-weight: 2;
        padding: 12px;

        font-size: 14px; 
        line-height: 25px;
        border-radius: 4px;

        background-color: rgb(238, 238, 238);
        color: black;
    }
    .header-nametag p:hover{
    color: #3d3d3d;
    }

    #MHC-Mar{
        margin-bottom:40px;
        margin-left:0;
        margin-right:20px;

        display: block;
    }

    #US-ExM{
        height:100%;
        margin-left:18px;
    }
    #Lower-Right-Block{
        margin-top:50.5px;
    }

    @media screen and (max-width: 760px) {
        .header {
            height:unset;
        }
        .header a {
            float: none;
            display: block;
            text-align: left;
        }
        .header-right a{
            margin: 0px;
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
            margin: 0px;
            margin-top: 6px;
            margin-bottom: 6px;
        }

        .header-nametag {
            margin:auto;
            float: none;
        }
        .header-nametag p{
            float: none;
            margin: 0px;
            margin-top: 6px;
            margin-bottom: 6px;
        }
        #US-ExM {
            margin: 0em;
            margin-bottom: 30px;
        }
        #MHC-Mar{
            margin-top:40px;
            margin-bottom:40px;
            margin-left:20px;
            margin-right:20px;
        }
        #Lower-Right-Block{
            margin-top: unset;
        }
        #Logo-Container{
            display: flex;
            justify-content: center;
            align-items: center;
        }
    }
</style>
</head>
<body>

    <div class="header" id="MainHeader">
         
        <div class="header-left" id="Logo-Container">
            <div>
                <img style="height:150px;margin:0px;padding:0px" src="/Styles/Logo.png" alt="App-Otheek"/> 
            </div>
        </div>


        <div class="header-right" id="MHC-Mar">
            <div class="header-right" id="Lower-Right-Block">
                <!--UserSpecific-->
                <div class="header-right" id="US-ExM">
                    <div class="header-right">
                        <!--Login/Out -->
                        <a href="<?=$LoginOrLogoutDirectory?>"><?= $LoginOrLogout ?></a>  
                    </div>
                
                    <!--Nametag -->
                    <?php 
                        if(VerifySession()){
                            echo "<div class='header-nametag'> <p style='font-weight:bold'>$DisplayName</p></div>";
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
        
    </div>

</body>
</html>