<?php
include('connect_db.php');

session_start();
// initializing variables
$username = "";
$first_name = "";
$surname = "";
$email = "";
$phone_number = "";
$city = "";
$address = "";
$post_code = "";
$password = "";
$errors = array();

// REGISTER USER
if (isset($_POST['reg_user'])) {
  // receive all input values from the form
  $username = mysqli_real_escape_string($db, $_POST['username']);
  $first_name = mysqli_real_escape_string($db, $_POST['first_name']);
  $surname = mysqli_real_escape_string($db, $_POST['surname']);
  $email = mysqli_real_escape_string($db, $_POST['email']);
  $phone_number = mysqli_real_escape_string($db, $_POST['phone_number']);
  $city = mysqli_real_escape_string($db, $_POST['city']);
  $address = mysqli_real_escape_string($db, $_POST['address']);
  $post_code = mysqli_real_escape_string($db, $_POST['post_code']);
  $password = mysqli_real_escape_string($db, $_POST['password']);
  // form validation: ensure that the form is correctly filled ...
  // by adding (array_push()) corresponding error unto $errors array
  if (empty()$username) { array_push($errors, "Username is required"); }
  if (empty()$first_name) { array_push($errors, "First name is required"); }
  if (empty()$surname) { array_push($errors, "Surname is required"); }
  if (empty()$email) { array_push($errors, "Email is required"); }
  if (empty()$phone_number) { array_push($errors, "Phone number is required"); }
  if (empty()$city) { array_push($errors, "City is required"); }
  if (empty()$address) { array_push($errors, "Address is required"); }
  if (empty()$post_code) { array_push($errors, "Post code is required"); }
  if (empty()$password) { array_push($errors, "Password is required"); }
  if ($password != $password_2) {
	array_push($errors, "The two passwords do not match");
  }
  // first check the database to make sure
  // a user does not already exist with the same username and/or email
  $user_check_query = "SELECT * FROM customer WHERE username='$username' LIMIT 1";
  $user_check_query = "SELECT * FROM customer WHERE firstname='$firstname' LIMIT 1";
  $user_check_query = "SELECT * FROM customer WHERE surname='$surname' LIMIT 1";
  $user_check_query = "SELECT * FROM customer WHERE email='$email' LIMIT 1";
  $result = mysqli_query($db, $user_check_query);
  $user = mysqli_fetch_assoc($result);
  if ($user) { // if user exists
    if ($user['username'] === $username) {
      array_push($errors, "username already exists");
    }

  if ($user) { // if user exists
    if ($user['firstname'] === $firstname) {
      array_push($errors, "firstname already exists");
    }
  }
  if ($user) { // if user exists
    if ($user['surname'] === $surname) {
      array_push($errors, "surname already exists");
    }
  }
  if ($user) { // if user exists
    if ($user['email'] === $email) {
      array_push($errors, "email already exists");
    }
  }
  // Finally, register user if there are no errors in the form
  if (count($errors) == 0) {
  	$password = md5($password_2);//encrypt the password before saving in the database
  	$query = "INSERT INTO customer (username, firstname, surname, email, phone_number, city, address, postcode, password)
  			  VALUES('$username', '$firstname', '$surname', '$email', '$phone_number', '$city', '$address', '$postcode', '$password')";
  	mysqli_query($db, $query);
  	$_SESSION['username'] = $username;
    $_SESSION['firstname'] = $firstname;
    $_SESSION['surname'] = $surname;
    $_SESSION['email'] = $email;
  	$_SESSION['success'] = "Sign up has been successful";
  	header('location: pizza.php');
  }
}
// LOGIN USER
if (isset($_POST['login_user'])) {
  $username = mysqli_real_escape_string($db, $_POST['username']);
  $password = mysqli_real_escape_string($db, $_POST['password']);
  if (empty($email)) {
  	array_push($errors, "Username as user is required");
  }
  if (empty($password)) {
  	array_push($errors, "Password is required");
  }
  if (count($errors) == 0) {
  	$password = md5($password);
  	$query = "SELECT * FROM customer WHERE username='$username' AND password='$password'";
  	$results = mysqli_query($db, $query);
  	if (mysqli_num_rows($results) == 1) {
  	  $_SESSION['username'] = $username;
  	  $_SESSION['success'] = "You are now logged in";
  	  header('location: index.php');
  	}else {
  		array_push($errors, "Wrong username/password combination");
  	}
  }
}
?>
