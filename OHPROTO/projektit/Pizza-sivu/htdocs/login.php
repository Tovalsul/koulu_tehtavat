<?php
session_start();
$con = mysqli_connect('localhost', 'root', '', 'pizzadb');
mysqli_select_db($con, 'customer');

$username = $_POST['username'];
$password = $_POST['password'];

$s = "SELECT * FROM customer WHERE username = '$username' && password = '$password'";
$result = mysqli_query($con, $s);
$num = mysqli_num_rows($result);

if($num == 1){
  header('location: pizza2.php');
} else {
  $_message = "Wrong username or password!";
}
?>
