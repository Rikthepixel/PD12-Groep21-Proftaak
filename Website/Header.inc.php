<?php
    include_once 'Include/SH.inc.php';
    include_once 'Include/DatabaseHandler.php';

    $Currentfilename = basename($_SERVER['PHP_SELF']);
    
    if(!VerifySession()){
        $LoginOrLogoutDirectory = './index.php';
        $LoginOrLogout = "Login";

        if($Currentfilename != "index.php" && $Currentfilename != "LoginFunctions.php"){
            if($Currentfilename != "LoginMain.php"){
                $_SESSION['error'] = "LoginRequired";
                header("Location: index.php");
                exit();
            }
        }
    }

    if($SessionValid = VerifySession()){
        $LoginOrLogoutDirectory = './Users/Logout/Logout.php';
        $LoginOrLogout = "Uitloggen";
    
        $Achternaam = $_SESSION['Achternaam'];
        $Voornaam = $_SESSION['Voornaam'];
        $DisplayName = "$Voornaam $Achternaam";
        $_SESSION['error'] = "AlreadyLoggedin";
    }

    function GetBrowser(){
        $arr_browsers = ["Opera", "Edg", "Chrome", "Safari", "Firefox", "MSIE", "Trident"];
        $agent = $_SERVER['HTTP_USER_AGENT'];
        $user_browser = '';

        foreach ($arr_browsers as $browser) {
            if (strpos($agent, $browser) !== false) {
                $user_browser = $browser;
                break;
            }   
        }

        switch ($user_browser) {
            case 'MSIE':
                $user_browser = 'Internet Explorer';
                break;   
            case 'Trident':
                $user_browser = 'Internet Explorer';
                break;
            case 'Edg':
                $user_browser = 'Microsoft Edge';
                break;
        }

        return $user_browser;
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
<title>App-Otheek - <?php

    $CurrentPageName = rtrim($Currentfilename, "php");
    $CurrentPageName = rtrim($CurrentPageName, ".");

    if($CurrentPageName == "index"){
        echo "Login";
        } else {
        echo $CurrentPageName;
    }
    ?>
</title>
<meta name="viewport" content="width=device-width, initial-scale=1">

<link rel="stylesheet" href="Styles/HeaderStyle.css" >
<style>
    #Help-btn{

        <?php if($Browser = GetBrowser() == "Firefox") {
            echo "padding: 4px 31.7px;";
        } else {
            echo "padding: 4px 32.7px;";
        }?>

    }
</style>
</head>
<body>

    <div class="header" id="MainHeader">
         
        <div class="header-left" id="Logo-Container">
            <img style="height:150px;margin:0px;padding:0px" src="/Styles/Logo.png" alt="App-Otheek"/> 
        </div>

        <div class="header-right" id="MHC-Mar">
            <!--UserSpecific-->
            <?php
                if($SessionValid){
                    echo '<div id = "Help-From">';
                    echo '<form action="./Help.php" method="post">';   
                    echo '<button id = "Help-btn" type="submit">Help</button>';
                    echo '</form>';
                    echo '</div>';
                }
            ?>
            <div class="header-right" id="Lower-Right-Block">
                <!--UserSpecific-->
                <div class="header-right" id="US-ExM">
                    <div class="header-right">
                        <!--Login/Out -->
                        <a href="<?=$LoginOrLogoutDirectory?>"><?= $LoginOrLogout ?></a>  
                    </div>
                
                    <!--Nametag -->
                    <?php 
                        if($SessionValid){
                            echo "<div class='header-nametag'> <p style='font-weight:bold'>$DisplayName</p></div>";
                        }
                    ?>
                </div>
                <!--Tabs-->
                <div class="header-right">
                    <!--Tabs -->
                    <?php 
                        if($SessionValid){
                            $ProdOver = DeterminActive('Producten.php');
                            $hrefProdOver = "Producten.php";
                            $Bestel = DeterminActive('Bestellen.php');
                            $hrefBestel = "Bestellen.php";
                            echo "<a $ProdOver href=$hrefProdOver>Product Overzicht</a>";
                            echo "<a $Bestel href=$hrefBestel>Bestellen</a>";

                        }
                    ?>
                </div>
            </div>
        </div>
        
    </div>

</body>
</html>