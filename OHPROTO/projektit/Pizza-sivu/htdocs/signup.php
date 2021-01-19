<?php
session_start();
$_SESSION['message'] = '';
$mysqli = new mysqli('localhost', 'root', '', 'pizzadb');

if ($_SERVER['REQUEST_METHOD'] == 'POST'){
  //two passwords are equal to each other
  if ($_POST['password'] == $_POST['password_2']){
    $username = $_POST['username']);
    $first_name = $_POST['first_name']);
    $surname = $_POST['surname']);
    $email = $_POST['email']);
    $phone_number = $_POST['phone_number']);
    $city = $_POST['city']);
    $address = $_POST['address']);
    $post_code = $_POST['post_code']);
    $password = md5($_POST['password']); //md5 is hash password, aka security matters
    echo $password;
      $sql = "INSERT INTO customer (username, firstname, surname, email, phone_number, city, address, postcode, password) "
        . "VALUES ('$username', '$firstname', '$surname', '$email', '$phone_number', '$city', '$address', '$postcode', '$password')";
        //if the query is successful, redirect to login.html page, done!
        $result = mysqli_query($mysqli, $sql);
        if ($result === true) {
          $_SESSION['message'] = 'Sign-up is successful! Account added to the database!';
          header("location: pizza.php");
        }
        else{
          $_SESSION['message'] = "Account could not be added to the database!";
        }
  } else {
      $_SESSION['message'] = "Wrong password!";
  }
}
?>
<div class="modal_content">
  <div class="close">+</div>
  <img class="signing_pic" src="img/loging.png">
      <h1>Sign Up</h1>
      <form action="signup.php" method="post">
      <input id="user_pic" type="username" name="username" class="form_control" placeholder="Username" required><br>
      <input id="fname_pic" type="fname" name="first_name" class="form_control" placeholder="First Name" required><br>
      <input id="sname_pic" type="sname" name="surname" class="form_control" placeholder="Surname" required><br>
      <input id="email_pic" type="email" name="email" class="form_control" placeholder="Email" required><br>
      <input id="phone_pic" type="pnr" name="phonenumber" class="form_control" placeholder="Phone Number" required><br>
      <input id="city_pic" type="city" name="city" class="form_control" placeholder="City" required><br>
      <input id="address_pic" type="address" name="address" class="form_control" placeholder="Address" required><br>
      <input id="pcode_pic" type="pcode" name="post_code" class="form_control" placeholder="Post Code" required><br>
      <input id=pass_pic type="password" name="password" class="form_control" placeholder="Your Password" required><br>
      <input id="confirm_pic" type="password" name="password_2" class="form_control" placeholder="Confirm Password" required><br>
      <hr>
      <button type="submit" class="signup-btn">Sign up</button>
      </form>
</div>
