<?php
include_once "../Include/SH.inc.php";
include_once "../Include/DatabaseHandler.php";

echo VerifySession();
if(VerifySession()){
    $Query;
    $ConnectionStr;

    //Needs:
    //Cookies: Session & RequestingKey
    //To send query:
    //SQLQuery

    if(isset($_COOKIE['RequestingKey'])){
        if($_COOKIE['RequestingKey'] == $_SESSION['UserRequestKey'] && isset($_POST['SQLQuery'])){
            $Query = $_POST['SQLQuery'];
                
            $Result = $Prodsconn -> query($Query);

            if ($Result->num_rows >= 0){
                $rows = array();
                while ($row = $Result -> fetch_assoc()){
                  $rows[] = $row;
                }
                echo json_encode($rows);
            }
        } else {
            //VerifySessionReturn("../../index.php", false);
            echo "Stage3";
        }
    } else{
        //VerifySessionReturn("../../index.php", false);
        echo "Stage2";
    }
} else {
    //VerifySessionReturn("../../index.php", false);
    echo "Stage1";
}

?>