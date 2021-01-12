<?php
include_once "../Include/DatabaseHandler.php";
include_once "../Include/SH.inc.php";

if(VerifySession()){
    if(isset($_COOKIE['RequestingKey'])){
        if($_COOKIE['RequestingKey'] == $_SESSION['UserRequestKey'] && isset($_POST['SQLQuery'])){          
            if(isset($_POST['REGISTER'])){
                ExecuteQuery($Loginconn, $_POST['SQLQuery']);
            }
            else{
                ExecuteQuery($Prodsconn, $_POST['SQLQuery']);
            }
        } else {
            ReturnToLogin();
        }
    } else{
        ReturnToLogin();
    }
} else {
    ReturnToLogin();
}

function ReturnToLogin(){
    VerifySessionReturn("../../index.php", false);
}

function ExecuteQuery($Connection, $Query){
    if($Result = $Connection -> query($Query)){
        if (is_object($Result)){
            if ($Result->num_rows >= 0){
                $returnData = array();
                while ($row = $Result -> fetch_assoc()){
                  $returnData[] = $row;
                }
                echo json_encode($returnData);
            } else{
                $returnData['succesful'] = "Query was succefully executed";
                echo json_encode($returnData);
            }
        }
        else{
            $returnData['succesful'] = "Query was succefully executed";
            echo json_encode($returnData);
        }
    }
    else{
        $returnData['succesful'] = "Unable to execute query";
        echo json_encode($returnData);
    }
}
?>