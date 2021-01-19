<?php
//connecting with database
$con = mysqli_connect('localhost', 'root', '', 'mang');
//checking connection with database
if(!$con){
  echo "Connection error:" . mysqli_connect_error();
}
?>

//to get connection for every php file just add to beginning | include('config/connect_db.php');
//make sure you have THIS file added in folder named config!!!
