<?php
include_once "../Include/SH.inc.php";
if(VerifySession()){
    $Query;
    $ConnectionStr;

    //Needs:
    //Cookies: Session & RequestingKey
    //To send query:
    //DBServer, DBUser, DBPassword, DBName
    //SQLQuery

    if(isset($_COOKIE['RequestingKey'])){
        if($_COOKIE['RequestingKey'] == $_SESSION['UserRequestKey'] && isset($_POST['SQLQuery'])){      
            if(isset($_POST['DBServer']) && isset($_POST['DBUser']) && isset($_POST['DBPassword']) && isset($_POST['DBName'])){
                $Query = $_POST['SQLQuery'];
                $Conn = mysqli_connect($_POST['DBServer'], $_POST['DBUser'], $_POST['DBPassword'], $_POST['DBName']);
                if (!$Conn) {
                    die("Connection failed: " . mysqli_connect_error());
                }
                
                $Result = $Conn -> query($Query);

                if ($Result->num_rows >= 0){
                    $rows = array();
                    while ($row = $Result -> fetch_assoc()){
                      $rows[] = $row;
                    }
                    echo json_encode($rows);
                }
            }

        } else {
            VerifySessionReturn("../../index.php", false);
        }
    } else{
        VerifySessionReturn("../../index.php", false);
    }
} else {
    VerifySessionReturn("../../index.php", false);
}

?>