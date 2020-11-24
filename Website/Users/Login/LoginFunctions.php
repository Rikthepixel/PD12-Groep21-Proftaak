<?php
function loginUser($conn, $Email, $Password){

    $_SESSION['Email'] = $Email;

    $LoginQuery = "SELECT * FROM User WHERE LOWER(Email) = LOWER('$Email') AND Password = '$Password'";
    $LoginResult = $conn -> query($LoginQuery);

    if($LoginResult->num_rows == 1){
        $IdentityQuery = "SELECT Voornaam FROM User WHERE LOWER(Email) = LOWER('$Email') AND Password = '$Password'";
        $IdentityResult = $conn -> query($IdentityQuery);
        $row = $IdentityResult -> fetch_assoc();
        
        $_SESSION['Voornaam'] = $row['Voornaam'];

        $IdentityQuery = "SELECT Achternaam FROM User WHERE LOWER(Email) = LOWER('$Email') AND Password = '$Password'";
        $IdentityResult = $conn -> query($IdentityQuery);
        $row = $IdentityResult -> fetch_assoc();
        
        $_SESSION['Achternaam'] = $row['Achternaam'];
        $_SESSION['Loggedin'] = true;
        
        Unset($_SESSION['error']);

        header("location:../../Producten.php");
        exit();
        
    } else {
        $_SESSION['error'] = "invaliddetails";
        header("location:../../index.php");
        exit();
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
    if(isset($_SESSION['Language'])){
        if($_SESSION['Language'] == "English"){
            if ($Error == "emptylogin"){
                $result = "Please enter login details";
            }
            if ($Error == "invaliddetails"){
                $result = "Please enter the correct login details";
            }
            if ($Error == "badsubmit"){
                $result = "Submission to Login was bad, please try again";
            }
            if ($Error == "invalidsession"){
                $result = "Session was invalid or has expired. Please Login again";
            }
            if ($Error == "SuccesLogout"){
                $result = "You were succesfully logged out";
            }
            if ($Error == "LoginRequired"){
                $result = "This page requires you to be logged in, please login";
            }
            if ($Error == "A"){
                $result = "";
            }
            if ($Error == "AlreadyLoggedin"){
                $result = "You are already logged-in";
            }
            return $result;
        }
        if($_SESSION['Language'] == "Dutch"){
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
    } else{
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
}