<?php
//connecting with database
$servername = "localhost";
$dBUsername = "root";
$dBPassword = "";
$dBName = "pizzadb";

$conn = mysqli_connect($servername, $dBUsername, $dBPassword, $dBName);
//checking connection with database
if(!$conn){
  die("Connection failed: ".mysqli_connect_error());
}

//to get connection for every php file just add to beginning | include('config/connect_db.php');
//make sure you have THIS file added in folder named config!!!
