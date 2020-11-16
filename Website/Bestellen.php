<?php
include_once 'Header.Inc.php';

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
                text-align: center;
                margin-left:25%;
            }
            
    </style>
</head>
<body>
    <form action="BestellingUpdate.php" method="post" id="LoginForm">
        <div id="BestelCont">
            <!--Bestelling-->
            <label>Bestelling</label>
            <input placeholder="25" type="number" name="TNM" required>

            <br><br>

            <label>Medicijn</label>
            <input placeholder="Medicijn naam" type="text" name="MDC" value="<?php if(isset($_POST['Product'])){echo $_POST['Product'];}?>" required> </input>
            <!--Bestel button-->
            <button id="BestelBTN" type="submit" value="AUserWantsToBestel" name="Bestel">Bestellen</button>
        </div>
    </form>
</body>
</html>

