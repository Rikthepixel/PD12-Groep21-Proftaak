<?php

function loginUser($conn, $Email, $Password){

    $LoginQuery = "SELECT * FROM User WHERE LOWER(Email) = LOWER('$Email') AND Password = '$Password'";
    $LoginResult = $conn -> query($LoginQuery);

    if($LoginResult->num_rows == 1){
        $row = $LoginResult -> fetch_assoc();

        $_SESSION['Email'] = $Email;
        $_SESSION['Voornaam'] = $row['Voornaam'];  
        $_SESSION['Achternaam'] = $row['Achternaam'];
        $_SESSION['Loggedin'] = true;

        unset($_SESSION['error']);
        unset($row['Password']);

        header("location:../../Producten.php");
        exit();

    } else {

        $_SESSION['error'] = "invaliddetails";
        header("location:../../index.php");
        exit();

    }
}

function loginApplication($conn, $Email, $Password){

    $LoginQuery = "SELECT * FROM User WHERE LOWER(Email) = LOWER('$Email') AND Password = '$Password'";
    $LoginResult = $conn -> query($LoginQuery);

    if($LoginResult->num_rows == 1){
        $row = $LoginResult -> fetch_assoc();

        $_SESSION['Email'] = $Email;
        $_SESSION['Voornaam'] = $row['Voornaam'];  
        $_SESSION['Achternaam'] = $row['Achternaam'];
        $_SESSION['Loggedin'] = true;

        unset($_SESSION['error']);
        unset($row['Password']);
        

        $_SESSION['UserRequestKey'] = (rand(0, 666) * rand(0, 420) * rand(0, 69));
        setcookie("RequestingKey", $_SESSION['UserRequestKey']);
        
        $row['Loggedin'] = true;
        echo json_encode($row);

    } else {
        $row['loginerror'] = ErrorMessage("invaliddetails");
        $row['LoggedIn'] = false;
        echo json_encode($row);
    }
}

function emptyLogin($Email, $Password) {
    $result;
    if(empty($_POST['EML']) || empty($_POST['PSWD'])){
        $result = true;
    } else {
        $result = false;
    }

    return $result;
}

function ErrorMessage($Error){
    $result;
    if ($Error == "emptylogin"){
        $result = "Voer alstublieft uw gegevens in";
    }
    if ($Error == "invaliddetails"){
        $result = "Voer alstublieft de correcte gegevens in";
    }
    if ($Error == "badsubmit"){
        $result = "De indiening naar de login service was incorrect, probeer het alstublieft opnieuw";
    }
    if ($Error == "invalidsession"){
        $result = "De sessie was ongeldig of het is of is verlopen, log alstublieft opnieuw in";
    }
    if ($Error == "SuccesLogout"){
        $result = "Je bent succesvol uitgelogd";
    }
    if ($Error == "LoginRequired"){
        $result = "Om deze pagina te bekijken moet U ingelogd zijn, log alstublieft in";
    }
    if ($Error == "A"){
        $result = "";
    }
    if ($Error == "AlreadyLoggedin"){
        $result = "U bent al ingelogd";
    }
    return $result;
}