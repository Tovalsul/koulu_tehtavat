const nappi = document.querySelectorAll('.nappi');
const arvaustenMaara = 3;

var arvattavaNumero = Math.floor((Math.random() * 10) + 1);
var arvaus = nappi.values();
var arvaukset = 0;

/*
  KOKEILE FOR LOOPILLA VIELÄ KERRAN JOS SE PASKA KÄVIS TON NAPPI
  TAULUKON LÄPI!!!!
*/

for (let i = 0 ; i < nappi.length; i++){
  nappi[i].addEventListener('click', function(){
  let numero = nappi[i].getAttribute('value');
});
}


function tarkistaVastaus(){
  if (arvattavaNumero === arvaus){
    alert('Arvasit oikein!');
  } else {
    if(arvaus < arvattavaNumero){
      document.getElementById('vihje').innerHTML = "Liian pieni numero! Kokeile isompaa lukua.";
    } else if(arvaus > arvattavaNumero){
      document.getElementById('vihje').innerHTML = "Liian suuri numero! Kokeile pienempää lukua";
    }
};

function vastaus(){
  tarkistaVastaus(arvaus);
  arvaukset++;

  if(arvaukset == arvaustenMaara) {
    alert("Peli päättyi");
  } else {
    alert("Arvasit oikein!")
  }
};


nappi.addEventListener('click', vastaus());
