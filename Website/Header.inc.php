<?php
    include_once 'Session/SH.inc.php';
    include_once 'Database/DatabaseHandler.php';

    if(!VerifySession()){
        $LoginOrLogoutDirectory = './index.php';
        $LoginOrLogout = "Login";
        $Currentfilename = basename($_SERVER['PHP_SELF']);

        if($Currentfilename != "index.php" && $Currentfilename != "LoginFunctions.php"){
            if($Currentfilename != "LoginMain.php"){
                $_SESSION['error'] = "LoginRequired";
                header("Location: index.php");
                exit();
            }
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

<link rel="stylesheet" href="Styles/HeaderStyle.css" >

</head>
<body>

    <div class="header" id="MainHeader">
         
        <div class="header-left" id="Logo-Container">
            <div>
                <img style="height:150px;margin:0px;padding:0px" src="/Styles/Logo.png" alt="App-Otheek"/> 
            </div>
        </div>

        <div class="header-right" id="MHC-Mar">
            <!--UserSpecific-->
            <?php
                if(VerifySession()){
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