<?php
session_start();
$_SESSION['message'] = '';
$mysqli = new mysqli('localhost', 'root', '', 'mang');

if ($_SERVER['REQUEST_METHOD'] == 'POST'){
  //two passwords are equal to each other
  if ($_POST['password'] == $_POST['password_2']){
    $email = $_POST['email'];
    $password = md5($_POST['password']); //md5 is hash password, aka security matters
    echo $password;
      $sql = "INSERT INTO users (email, password) "
        . "VALUES ('$email', '$password')";
        //if the query is successful, redirect to login.html page, done!
        $result = mysqli_query($mysqli, $sql);
        if ($result === true) {
          $_SESSION['message'] = 'Sign-up is successful! $email added to the database!';
          header("location: signin.html");
        }
        else{
          $_SESSION['message'] = "email could not be added to the database!";
        }
  } else {
      $_SESSION['message'] = "Wrong password!";
  }
}
?>
    <div id="register" class="signForm">
      <img src="usericon.png">
        <h1>Sign Up</h1>
        <form action="form.php" method="post">
        <input type="email" name="email" class="form-control" placeholder="Your Email as user" required><br>
        <input type="password" name="password" class="form-control" placeholder="Your Password" required><br>
        <input type="password" name="password_2" class="form-control" placeholder="Confirm Password" required>
        <button type="submit" class="signup-btn">Sign up</button>
        </form>
        <hr>
        <p>Do you already have an account? <a href="signin.html">Log In</a></p>
    </div>
