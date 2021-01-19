//document.getElementById('login_btn').addEventListener('click', function () {
//  document.querySelector('.login_modal').style.display = 'flex';
//});//this code is to popup login modal !!!

//document.querySelector('.close').addEventListener('click', function () {
  document.querySelector('.login_modal').style.display = 'none';
//});//this code is to close login modal !!!
$("#login_btn").click(function(){

  $(".login_modal").show();
  $(".login_modal").css("display", "flex");
});

$(".close").click(function(){

  $(this).parents("div").hide();
});

document.getElementById('signup_btn').addEventListener('click', function () {
  document.querySelector('.signup_modal').style.display = 'flex';
});//this code is to popup signup modal !!!

////document.querySelector('.close').addEventListener('click', function () {
//  document.querySelector('.signup_modal').style.display = 'none';
//});//this code is to close signup modal !!!

document.getElementById('pizza_btn').addEventListener('click', function () {
  document.querySelector('.pizza_modal').style.display = 'flex';
});//this code is to popup pizza modal !!!

//document.querySelector('.close').addEventListener('click', function () {
//  document.querySelector('.pizza_modal').style.display = 'none';
//});//this code is to close pizza modal !!!

document.getElementById('drinks_btn').addEventListener('click', function () {
  document.querySelector('.drinks_modal').style.display = 'flex';
});//this code is to popup drinks modal !!!

//document.querySelector('.close').addEventListener('click', function () {
//  document.querySelector('.drinks_modal').style.display = 'none';
//});//this code is to close drinks modal !!!

document.getElementById('sweets_btn').addEventListener('click', function () {
  document.querySelector('.sweets_modal').style.display = 'flex';
});//this code is to popup drinks modal !!!

//document.querySelector('.close').addEventListener('click', function () {
//  document.querySelector('.sweets_modal').style.display = 'none';
//});//this code is to close drinks modal !!!
