<?php
include_once "../Include/DatabaseHandler.php";
include_once "../Include/SH.inc.php";

if(VerifySession()){
    $Query;

    if ($conn->connect_error){
        die("Connection to the database fialed")
    }

    if(isset($_COOKIE['RequestingKey'])){
        if($_COOKIE['RequestingKey'] == $_SESSION['UserRequestKey'] && isset($_POST['SQLQuery'])){
            $Query = $_POST['SQLQuery'];
                
            if($Result = $Prodsconn -> query($Query) === true){
                if ($Result->num_rows >= 0){
                    $rows = array();
                    while ($row = $Result -> fetch_assoc()){
                      $rows[] = $row;
                    }
                    echo json_encode($rows);
                }
                else{
                    $row['succesful'] = "Query was succefully executed"
                    echo json_encode()
                }
            }
            else{
                $row['succesful'] = "Unable to execute query"
                echo json_encode()
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