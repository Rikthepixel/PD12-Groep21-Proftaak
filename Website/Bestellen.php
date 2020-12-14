<?php
include_once 'Header.inc.php';

?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="Styles/DefaultStyle.css">

    <style>
            #BestelBTN{
                width:100%;
                background-color:#187757;

                padding-top: 3%;
                padding-bottom: 3%;

                margin-top: 2%;
                margin-bottom: 2%;

                font-size: 120%;
                font-weight: bold;

                line-height: 25px;
                border-radius: 8px;

                border: 4px solid #0e4a36;
            }
            #BestelBTN:hover{
                background-color:#1aad7c;
                color:#4f4f4f;
                border-color:#21755a;
            }

            #BestelCont{
                width:50%;
                /*text-align: center;*/
                margin-left:25%;
                font-family: Arial, Helvetica, sans-serif;
            }

            #Inputs{
                /*float:left;*/
                display: inline-block;
                text-align: right;

                padding-left: 1%;
                padding-top: 2%;
                padding-bottom: 2%;

                font-size:110%;
                font-weight:bold;

                color:white;
            }
            
            #InputText{
                width:100%;

                background-color:#ebebeb;
                color:black;

                border-radius:3px;
                border:3px solid #0e4a36;
            }

            #InputText:hover{
                border-color:#21755a;
                background-color:#f5f5f5;
            }
            #InputText:focus{
                border-color:#21755a;
                background-color:white;
            }

            .backgroundColor{
                background-color:#58c4a0;
                padding-bottom:50px;
            }
            .formMargin{
                padding-top:50px;
                text-align:center;
            }
    </style>
</head>
<body>
    <div class = "backgroundColor">
    <form action="Producten/BestellingUpdate.php" method="post" class="formMargin">
        <div id="BestelCont">
            <!--Bestelling-->
            <div>
                <div id="Inputs">
                <label>Aantal</label>
                <br><br>
                <label>Medicijn type</label>
                </div>
                <div id="Inputs">
                <input id="InputText" placeholder="Aantal medicijnen..." type="number" min="1" name="TNM" required>
                <br><br>
                <select id="InputText" placeholder="Medicijn naam..." name="MDC" required>
                    <option value="" disabled selected> Medicijn naam </option>
                    <!--<option value="<?php //if(isset($_POST['Product'])){echo $_POST['Product'];}?>" <?php //echo ""?>></option>-->
                    <?php
                        $QueryTables = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'Medical';";
                        $Tableresults = $Prodsconn -> query($QueryTables);

                        while($row2 = $Tableresults -> fetch_array())
                        {
                            echo "<option value='$row2[0]'";

                            if(isset($_POST["Product"])){
                                if($row2[0] == $_POST["Product"]){
                                    echo 'selected=""';
                                }
                            }

                            echo ">$row2[0]";
                            echo "</option>";
                        }
                    ?>
                </select>
                </div>
            </div>
            <!--Bestel button-->
            <button id="BestelBTN" type="submit" value="AUserWantsToBestel" name="Bestel">Bestellen</button>
        </div>
    </form>
    </div>
</body>
</html>

