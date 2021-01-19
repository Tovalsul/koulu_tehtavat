<?php

if (isset($_POST['login-submit'])) {

    require_once 'connect_db.php';

    $username = $_POST['username'];
    $password = $_POST['password'];

    if (empty($username) || empty($password)) {
      header("Location: pizza.php?error=emptyfields");
      exit();
    }
    else {
      $sql = "SELECT * FROM customer WHERE username=?";
      $stmt = mysqli_stmt_init($conn);
      if (!mysqli_stmt_prepare($stmt, $sql)) {
        header("Location: pizza.php?error=sqlerror");
        exit();
      }
      else {

        mysqli_stmt_bind_param($stmt, "ss", $username, $username);
        mysqli_stmt_execute($stmt);
        $result = mysqli_stmt_get_result($stmt);
        if ($row = mysqli_fetch_assoc($result)) {
          $pswCheck = password_verify($password, $row['password']);
          if ($pswCheck == false) {
            header("Location: pizza.php?error=wrongpsw");
            exit();
          }
          else if ($pswCheck == true) {
            session_start();
            $_SESSION['userId'] = $row['id'];
            $_SESSION['unameId'] = $row['username'];

            header("Location: pizza.php?login=success");
            exit();
          }
          else {
            header("Location: pizza.php?error=wrongpsw");
            exit();
          }
        }
        else {
          header("Location: pizza2.php?error=nouser");
          exit();
        }
      }
    }

}
else {
  header("Location: pizza.php");
  exit();
}
