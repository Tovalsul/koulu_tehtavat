<?php
session_start();
$con = mysqli_connect('localhost', 'root', '', 'mang');
mysqli_select_db($con, 'users');

$email = $_POST['email'];
$password = $_POST['password'];

$s = "SELECT * FROM users WHERE email = '$email' && password = '$password'";
$result = mysqli_query($con, $s);
$num = mysqli_num_rows($result);

if($num == 1){
  header('location: signup.html');
} else {
  $_message = "Wrong email or password!";
}
?>
