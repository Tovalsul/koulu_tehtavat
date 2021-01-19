/* Tämä on opiskelua varten tehty projekti jossa on käytetty netistä saatuja ohjeita.
Ohjeet: https://medium.com/javascript-in-plain-english/the-game-of-life-using-javascript-fc1aaec8274f
Tekijä: Tony Valdemar Lehtonen
*/

// Vakiot joilla määritellään kuinka monta pysty ja vaakariviä halutaan peliin.
const rivit = 40;
const pylvaat = 40;

let aloitettu = false; // Tämä muutetaan trueksi kun ohjelma käynnistyy aloitus nappia painamlla.
let ajastin; // tällä hallitaan solujen elämää reaaliajassa.
let elamanNopeus = 1000; // 1000ms on yhtkäkuin 1 sekunti. Laitan sukupolvet päivittymään sekunnin välein.

// Näistä tehdään sukupolvien seuraamista varten kaksiulotteiset taulukot.
let nykyinenSukupolvi = [rivit];
let seuraavaSukupolvi = [rivit];

// Luo kaksiulotteiset taulukot
function luoSukupolviTaulukko(){
  for (let i = 0; i < rivit; i++){
    nykyinenSukupolvi[i] = new Array(pylvaat);
    seuraavaSukupolvi[i] = new Array(pylvaat);
  }
}

function alkuperainenSukupolvi(){
  for (let i = 0; i < rivit; i++){
    for (let j = 0; j < pylvaat; j++){
      nykyinenSukupolvi[i][j] = 0;
      seuraavaSukupolvi[i][j] = 0;
    }
  }
}

function luoElinymparisto(){
  // Let elinYmparisto valitsee html:stä divin jolla on elinymparisto id ja tekee sille muuttujan.
  let elinymparisto = document.querySelector('#elinymparisto');

  // Tekee taulukon ja antaa sille ruudukko id:n.
  let taulukko = document.createElement("table");
  taulukko.setAttribute('id', 'ruudukko');

  // Pari for looppia joita käytetään tekemään haluttu määrä taulukon soluja ja niille id:t ja classit.
  for (let i = 0; i < rivit; i++){
    let taulukonRivi = document.createElement('tr');
    // Tämä ohjelma tarvitsee toisen for loopin eri nimellä luodakseen x,y akselilla joka solulle oman id:n
    for (let j = 0; j < pylvaat; j++){
      let solu = document.createElement('td');
      // Nämä luovat soluille oman id:n ja asettavat luokan kuollut
      solu.setAttribute('id', i + '_' + j);
      solu.setAttribute('class', 'kuollut');
      // Tämä haistelee kun solua on klikattu ja suorittaa sitten funktion.
      solu.addEventListener('click', solunKlikkaus);

      taulukonRivi.appendChild(solu);
    }
    taulukko.appendChild(taulukonRivi);
  }
  elinymparisto.appendChild(taulukko);
}

/* Solun sijainti x, y akselilla saadaan ottamalla sen i ja j looppien antamant arvot
ja jakamalla se kahteen eri taulukkoon joille sitten annettaan omat muuttujat.
*/
function solunKlikkaus(){
  let sijainti = this.id.split("_");
  let rivi = Number(sijainti[0]);
  let pylvas = Number(sijainti[1]);

  // Vaihtaa solun kuolleeksi tai eläväksi.
  if (this.className === 'elossa'){
    this.setAttribute('class', 'kuollut');
    nykyinenSukupolvi[rivi][pylvas] = 0;
  }
  else{
    this.setAttribute('class', 'elossa');
    nykyinenSukupolvi[rivi][pylvas] = 1;
  }

}

function luoSeuraavaSukupolvi(){
  for (rivi in nykyinenSukupolvi){
    for (pylvas in nykyinenSukupolvi[rivi]){

      let naapurit = tarkistaNaapurienMaara(rivi, pylvas);
      // Tarkista säännöt
      // Jos elossa

      if (nykyinenSukupolvi[rivi][pylvas] == 1){

        if (naapurit < 2){
          seuraavaSukupolvi[rivi][pylvas] = 0;
        } else if (naapurit == 2 || naapurit == 3){
          seuraavaSukupolvi[rivi][pylvas] = 1;
        } else if (naapurit > 3){
          seuraavaSukupolvi[rivi][pylvas] = 0;
        }
      } else if (nykyinenSukupolvi[rivi][pylvas] == 0){
          // Jos solu on kuollut tai tyhjä

          if (naapurit == 3){
            // Jos tyhjän solun naapureita on 3 niin siihen syntyy uusi solu.
            seuraavaSukupolvi[rivi][pylvas] = 1; // Syntymä
        }
      }
    }
  }
}

function tarkistaNaapurienMaara(rivi, pylvas){
  let maara = 0;
  let monesRivi = Number(rivi);
  let monesPylvas = Number(pylvas);

    // Varmistaa että ei tarkisteta ensimmäisen rivin kohdalta.
    if (monesRivi - 1 >= 0){
      // Tarkistaa yläpuolella olevan naapurin.
      if (nykyinenSukupolvi[monesRivi - 1][monesPylvas] == 1){
        maara++;
      }
    }
    // Tarkistaa että sijainti ei ole ensimmäinen solu.
    if (monesRivi - 1 >= 0 && monesPylvas - 1 >= 0){
      // Tarkistaa yläpuolelta vasemmanpuolisen naapurin.
      if (nykyinenSukupolvi[monesRivi - 1][monesPylvas - 1] == 1){
        maara++;
      }
    }
    // Tarkistaa että sijainti ei ole ensimmäisen rivin viimeinen pylvas.
    if (monesRivi - 1 >= 0 && monesPylvas + 1 < pylvaat){
      // Tarkistaa yläpuolelta oikeanpuolisen naapurin.
      if (nykyinenSukupolvi[monesRivi - 1][monesPylvas + 1] == 1){
        maara++;
      }
    }
    // Tarkistaa että sijainti ei ole ensimmäinen pylväs.
    if (monesPylvas - 1 >= 0){
      // Tarkistaa vasemmanpuolisen naapurin.
      if (nykyinenSukupolvi[monesRivi][monesPylvas - 1] == 1){
        maara++;
      }
    }
    // Tarkistaa että sijainti ei ole viimeinen pylvas.
    if (monesPylvas + 1 < pylvaat){
      // Tarkistaa oikeanpuolisen naapurin.
      if (nykyinenSukupolvi[monesRivi][monesPylvas + 1] == 1){
        maara++;
      }
    }
    // Tarkistaa että sijainti ei ole vasen alakulma.
    if (monesRivi + 1 < rivit && monesPylvas - 1 >=0){
      // Tarkistaa alapuolelta vasemmanpuolisen naapurin.
      if (nykyinenSukupolvi[monesRivi + 1][monesPylvas -1] == 1){
        maara++;
      }
    }
    // Tarkistaa että sijainti ei ole oikea alakulma.
    if (monesRivi + 1 < rivit && monesPylvas + 1 < pylvaat){
      // Tarkistaa alapuolelta oikeanpuolisen naapurin.
      if (nykyinenSukupolvi[monesRivi + 1][monesPylvas + 1] ==1){
        maara++;
      }
    }
    // Tarkistaa että sijainti ei ole viimeinen rivi.
    if (monesRivi + 1 < rivit){
      // Tarkistaa alapuolella sijaitsevan naapurin.
      if (nykyinenSukupolvi[monesRivi + 1][monesPylvas] == 1){
        maara++;
      }
    }

    return maara;
  }

function paivitaNykyinenSukupolvi(){
  for (rivi in nykyinenSukupolvi){
    for (pylvas in nykyinenSukupolvi[rivi]){
      // Päivittää nykyisen sukupolven funktion luoSukupolviTaulukko tuloksilla.
      nykyinenSukupolvi[rivi][pylvas] = seuraavaSukupolvi[rivi][pylvas];
      // Asettaa seuraavan sukupolven takaisin tyhjäksi.
      seuraavaSukupolvi[rivi][pylvas] = 0;
    }
  }
}

function paivitaElinymparisto(){
  let solu = '';
  for (rivi in nykyinenSukupolvi){
    for (pylvas in nykyinenSukupolvi[rivi]){
      solu = document.getElementById(rivi + '_' + pylvas);
      if (nykyinenSukupolvi[rivi][pylvas] == 0){
        solu.setAttribute('class', 'kuollut');
      } else {
        solu.setAttribute('class', 'elossa');
      }
    }
  }
}

// Ela funktiota kutsuttaessa peli lähtee käyntiin.
function ela(){
  luoSeuraavaSukupolvi(); // Asettaa säännöt joilla peli toimii.
  paivitaNykyinenSukupolvi(); // Päivittää nykyisen sukupolven ja asettaa niille arvot.
  paivitaElinymparisto(); // Päivittää ruudun

  if (aloitettu){
    ajastin = setTimeout(ela, elamanNopeus);
  }
}

// Alla oleva pelin aloitus funktio vaihtaa pelin aloitus nappulan arvoa ja aloittaa tai pysäyttää pelin.
function aloitaLopetaPeli(){
  let aloitaLopeta = document.querySelector('#aloitaNappi');

  if (!aloitettu){
    aloitettu = true;
    aloitaLopeta.value = "Lopeta peli";
    ela();
  } else {
    aloitettu = false;
    aloitaLopeta.value = " Aloita peli";
    tyhjennaAjastin(ajastin);
  }
}

// ResetoiPeli funktiolla saada tyhjennettyä ruudut ja aloitettua peli alusta. Se mmyös palauttaa pelin aloitus napin takaisin alkuasetuksiin.
function resetoiPeli(){
  location.reload();
}

// Tällä kutsutaan funktiot ikkunan latautuessa.
window.onload=()=>{
  luoElinymparisto(); // Itse ruudukko joka on tehty tablesta ja sen soluista.
  luoSukupolviTaulukko(); // Nykyinen ja seuraava sukupolvi.
  alkuperainenSukupolvi(); // Asettaa kaikki taulukossa sijaitsevat solut 0=kuollut.
}
