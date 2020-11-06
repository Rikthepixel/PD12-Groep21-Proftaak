<?php

function loginUser($conn, $Email, $Password){
    $query = "SELECT * FROM users WHERE Email=$Email AND Password=$Password";
    $stmt = mysqli_stmt_init($conn);
    if (!mysqli_stmt_prepare($stmt, $query)) {
        header("location: LoginPage.php");
    }

    mysqli_stmt_bind_param($stmt, "ss", $Email, $Password);
    mysqli_stmt_execute($stmt);

    $resultData = mysqli_stmt_get_result($stmt);

    $row = mysqli_fetch_assoc($resultData);  
}

?>