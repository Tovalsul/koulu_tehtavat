
<!DOCTYPE html>

<?php
  session_start();

  include 'connect_db.php';
?>


<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <title>Pizza</title>
    <script src="jquery-3.5.1.js"></script>
    <script src="script.js" defer></script>
    <link rel="stylesheet" type="text/css" href="style.css">
    <link href="https://fonts.googleapis.com/css2?family=Gloria+Hallelujah&display=swap" rel="stylesheet">
  </head>
  <body>
    <header>
      <div class="header_btn">
        <a href="#" class="button" id="account_btn">My Account</a>
        <br><br>
        <a href="#" class="button" id="order_button">Order</a>
        <br><br>
        <a href="logout.php" class="button">Log out</a>
      </div>
    </header>
    <div class="h1p">
      <h1>Gourmet pizza by R<span class="andsign">&</span>T</h1>
      <p>Pizza recipe has been mastered over 40 years of <br>experience of family recipe. For tomato sauce, we<br> use special tomatoes that grow at an altitude of<br> 1,500 meters on Mount Etna. Growing time is very<br> long, it takes up to 4 months for tomatos to get ripe! </p>
      <img class="comingsoon" src="comingsoon.png">
    </div>
    <div id="menu">
      <div id="ruoka">
        <a href="#" class="button" id="pizza_btn">Pizza</a>
          <br><br>
        <a href="#" class="button" id="drinks_btn">Drinks</a>
        <br><br>
        <a href="#" class="button" id="sweets_btn">Sweets</a>
          <br>
      </div>
    </div>
    <div class="login_modal">
  <div class="modal_content">
    <div class="close">+</div>
    <img class="signing_pic" src="img/loging.png">
      <h1>Log In</h1>
      <form action="signup.php" method="post">
      <input id="user_pic" type="username" name="username" class="form_control" placeholder="Username" required><br>
      <input id="pass_pic" type="password1" name="password" class="form_control" placeholder="Password" required><br>
      <input type="checkbox" class="check-box"><span>Remember Password</span><br>
      <hr>
      <button type="submit" class="signin-btn">Log In</button><br>
      </form>
  </div>
</div>
<div class="signup_modal">
  <div class="modal_content">
    <div class="close">+</div>
    <img class="signing_pic" src="img/loging.png">
        <h1>Sign Up</h1>
        <form action="signup.php" method="post">
        <input id="user_pic" type="username" name="username" class="form_control" placeholder="Username" required><br>
        <input id="fname_pic" type="fname" name="fname" class="form_control" placeholder="First Name" required><br>
        <input id="sname_pic" type="sname" name="sname" class="form_control" placeholder="Surname" required><br>
        <input id="email_pic" type="email" name="email" class="form_control" placeholder="Email" required><br>
        <input id="phone_pic" type="pnr" name="pnr" class="form_control" placeholder="Phone Number" required><br>
        <input id="city_pic" type="city" name="city" class="form_control" placeholder="City" required><br>
        <input id="address_pic" type="address" name="address" class="form_control" placeholder="Address" required><br>
        <input id="pcode_pic" type="pcode" name="pcode" class="form_control" placeholder="Post Code" required><br>
        <input id=pass_pic type="password" name="password" class="form_control" placeholder="Your Password" required><br>
        <input id="confirm_pic" type="password" name="password_2" class="form_control" placeholder="Confirm Password" required><br>
        <hr>
        <button type="submit" class="signup-btn">Sign up</button>
        </form>
  </div>
  <div class="pizza_modal">
    <div class="menu_content">
      <div class="close">+</div>
      <div class="menu_card">
        <?php
          $sql = "SELECT * FROM sizes";
          $result = $conn->query($sql) OR die($conn->error);
          $sizes = array();
          while($row = $result->fetch_assoc())
          {
            $sizes[] = $row;
          }
            var_dump($sizes);

          $sql = "SELECT * FROM pizzas";
          $result = $conn->query($sql) OR die($conn->error);
          while($row = $result->fetch_assoc())
          {
         ?>
        <div class="cards">
          <img class="pizza_pic" src="<?php echo $row["pictures"] ?>">
          <h1><?php echo $row["pizza_name"] ." <span>".$row["pizza_price"]."</span>€" ?></h1>
          <p><?php echo $row["comment"] ?></p>
          <?php
          foreach ($sizes as $key => $value) {
            // code...

          echo "<button type='button' name='button' data-value='{$value['size_price']}'>{$value['size_name']}</button>";
          }
          ?>
        </div>

        <?php
      }

         ?>

      </div>
    </div>
  </div>
  <div class="drinks_modal">
    <div class="menu_content">
      <div class="close">+</div>
      <div class="menu_card">
        <?php

          $sql = "SELECT * FROM drinks";
          $result = $conn->query($sql) OR die($conn->error);
          while($row = $result->fetch_assoc())
          {
         ?>
        <div class="cards" id="drinks_pic">
          <img class="drinks_pic" src="<?php echo $row["pictures"] ?>">
          <h1><?php echo $row["drink_name"] ." <span>".$row["drink_price"]."</span>€" ?></h1>
          <!--
          <?php echo $row["comment"] ?>
        -->
          <?php
          foreach ($sizes as $key => $value) {
            // code...


          }
          ?>
        </div>

        <?php
      }

         ?>

      </div>
    </div>
  </div>
  <div class="sweets_modal">
    <div class="menu_content">
      <div class="close">+</div>
      <div class="menu_card">
        <?php

          $sql = "SELECT * FROM sweets";
          $result = $conn->query($sql) OR die($conn->error);
          while($row = $result->fetch_assoc())
          {
         ?>
        <div class="cards" id="sweets_pic">
          <img class="sweets_pic" src="<?php echo $row["pictures"] ?>">
          <h1><?php echo $row["sweet_name"] ." <span>".$row["sweet_price"]."</span>€" ?></h1>

          <?php
          foreach ($sizes as $key => $value) {
            // code...


          }
          ?>
        </div>

        <?php
      }

         ?>

      </div>
    </div>
  </div>
    </body>
  </html>
