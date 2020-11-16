<?php
include_once 'Header.inc.php';
include_once 'Database/DatabaseHandler.php';
?>

<form action="BestellingUpdate.php" method="post" id="LoginForm">

    <!--Bestelling-->
    <label>Bestelling</label>
    <input placeholder="25" type="number" name="TNM" required>

    <br><br>

    <label>Medicijn</label>
    <input placeholder="Medicijn naam" type="text" name="MDC" value="<?php if(isset($_POST['Product'])){echo $_POST['Product'];}?>" required> </input>
    <!--Login button-->
    <button type="submit" value="AUserWantsToBestel" name="Bestel">Bestellen</button>
</form>
