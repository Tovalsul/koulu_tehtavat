
<!DOCTYPE html>


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
</div>
<div class="pizza_modal">
  <div class="menu_content">
    <div class="close">+</div>
    <div class="menu_card">
      <div class="cards">
        <img class="pizza_pic" src="img/artichoke.png" alt="artichoke">
        <h1>artichoke</h1>
        <p>Tomato sauce, mozzarella, artichoke, mushrooms, tomato, olives, oregano</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/bbq seafood.png" alt="bbq seafood">
        <h1>bbq-seafood</h1>
        <p>Tomato sauce, mozzarella, prawns, squid, sea snail, BBQ-sauce, mushrooms, red pepper, onion, basil</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/california.png" alt="california">
        <h1>california</h1>
        <p>Tomato sauce, mozzarella, soft cheese, minth</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/chicago.png" alt="chicago">
        <h1>chicago</h1>
        <p>Tomato sauce, mozzarella, cheddar cheese, pulled chicken, chilli, red pepper, garlic, oregano</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/chilli.png" alt="chilli">
        <h1>chilli sausage</h1>
        <p>Tomato sauce, mozzarella, chilli sausage, mushrooms, green pepper, onion</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/margherita.png" alt="margherita">
        <h1>margherita</h1>
        <p>Tomato sauce, mozzarella</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/hawai.png" alt="hawai">
        <h1>hawai</h1>
        <p>Tomato sauce, mozzarella, ham, pineapple, oregano</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/italian.png" alt="italian">
        <h1>italian</h1>
        <p>Tomato sauce, mozzarella, asparagus, tomato, oregano</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/kebab.png" alt="kebab">
        <h1>kebab</h1>
        <p>Tomato sauce, mozzarella, döner kebab, mushrooms, green pepper, olives, garlic, oregano</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/krakov.png" alt="krakov">
        <h1>krakov</h1>
        <p>Tomato sauce, mozzarella, krakov sausage, garlic, oregano</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/mariana.png" alt="mariana">
        <h1>mariana</h1>
        <p>Tomato sauce, mozzarella, Mariana sauce, ham, mushrooms, green chilli, red pepper</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/new york.png" alt="new york">
        <h1>new york</h1>
        <p>Tomato sauce, mozzarella, pulled pork, chilli, cherry tomato, olives, garlic, basil</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/pepperoni.png" alt="pepperoni">
        <h1>pepperoni</h1>
        <p>Tomato sauce, mozzarella, pepperoni, garlic, oregano</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/prosciutto.png" alt="prosciutto">
        <h1>prosciutto</h1>
        <p>Tomato sauce, mozzarella, prosciutto, mushrooms, green pepper, oregano</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/sushi.png" alt="sushi">
        <h1>sushi</h1>
        <p>Tomato sauce, mozzarella, white fish, soy sauce, tomato, broccoli, olives, red pepper, tomato, garlic, oregano</p>
      </div>
      <div class="cards">
        <img class="pizza_pic" src="img/vegetarian.png" alt="vegetarian">
        <h1>vegetarian</h1>
        <p>Tomato sauce, mozzarella, tomato, garlic, rocket</p>
      </div>
    </div>
  </div>
</div>

</div><div class="drinks_modal">
  <div class="menu_content">
    <div class="close">+</div>
    <div class="menu_card">
      <div class="cards">
        <img class="drinks_pic" src="img/perrier.png" alt="perrier">
        <h1>Perrier 0,4l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/spellegrino.png" alt="s.pellegrino">
        <h1>S.Pellegrino 0,75</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/capi.png" alt="capi">
        <h1>Capi 0,2l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/schweppes.png" alt="ginger ale">
        <h1>Ginger Ale 0,2l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/schweppes2.png" alt="tonic water">
        <h1>Tonic Water 0,2l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/redbull.png" alt="red bull">
        <h1>Red Bull 0,25l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/pepsi.png" alt="pepsi">
        <h1>Pepsi 0,2l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/cocacola.png" alt="cocacola">
        <h1>Coca Cola 0,2l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/cocalight.png" alt="cocalight">
        <h1>Coca Cola Light 0,2l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/cocazero.png" alt="cocazero">
        <h1>Coca Cola Zero 0,2l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/heineken.png" alt="heineken">
        <h1>Heineken 0,3l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/carlsberg.png" alt="carlsberg">
        <h1>Carlsberg 0,3l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/bud.png" alt="bud">
        <h1>Bud 0,3l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/becks.png" alt="becks">
        <h1>Beck's 0,3l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/corona.png" alt="corona">
        <h1>Corona Extra 0,21l</h1>
      </div>
      <div class="cards">
        <img class="drinks_pic" src="img/sol.png" alt="sol">
        <h1>SOL 0,21l</h1>
      </div>
    </div>
  </div>
</div><div class="sweets_modal">
  <div class="menu_content">
    <div class="close">+</div>
    <div class="menu_card">
      <div class="cards">
        <img class="sweets_pic" src="img/bounty.png" alt="bounty">
        <h1>Bounty</h1>
      </div>
      <div class="cards">
        <img class="sweets_pic" src="img/kinderbueno.png" alt="kinderbueno">
        <h1>Kinder Bueno</h1>
      </div>
      <div class="cards">
        <img class="sweets_pic" src="img/kitkat.png" alt="kitkat">
        <h1>KitKat</h1>
      </div>
      <div class="cards">
        <img class="sweets_pic" src="img/maltesers.png" alt="maltesers">
        <h1>Maltesers</h1>
      </div>
      <div class="cards">
        <img class="sweets_pic" src="img/milkyway.png" alt="milkyway">
        <h1>MilkyWay</h1>
      </div>
      <div class="cards">
        <img class="sweets_pic" src="img/mmchoko.png" alt="mmchoko">
        <h1>m&m's Chockolate Bar</h1>
      </div>
      <div class="cards">
        <img class="sweets_pic" src="img/mmpeanut.png" alt="mmpeanut">
        <h1>m&m's Peanut</h1>
      </div>
      <div class="cards">
        <img class="sweets_pic" src="img/oreo.png" alt="oreo">
        <h1>Oreo</h1>
      </div>
      <div class="cards">
        <img class="sweets_pic" src="img/skittlesdarkside.png" alt="skittlesdarkside">
        <h1>Skittles DarkSide</h1>
      </div>
      <div class="cards">
        <img class="sweets_pic" src="img/skittlesoriginal.png" alt="skittlesoriginal">
        <h1>Skittles Original</h1>
      </div>
      <div class="cards">
        <img class="sweets_pic" src="img/snickers.png" alt="snickers">
        <h1>Snickers</h1>
      </div>
      <div class="cards">
        <img class="sweets_pic" src="img/twix.png" alt="twix">
        <h1>Twix</h1>
      </div>
    </div>
  </div>
</div>
  </body>
</html>
