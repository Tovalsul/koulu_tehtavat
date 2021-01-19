/* Tämä on opiskelua varten tehty projekti jossa on käytetty netistä saatuja ohjeita.
Ohjeet: https://www.youtube.com/watch?v=bbb9dZotsOc
Tekijä: Tony Valdemar Lehtonen
*/

let valittuKortti = null;
let estaValinta = false;
let parejaLoydetty = 0;


// taulukko eri vareille joista for looppi valitsee kortteille satunnaisesti varin.
const varit = [
  'punainen',
  'sininen',
  'keltainen',
  'vihrea',
  'sinivihrea',
  'oranssi',
  'vaaleanpunainen',
  'syaani',
];


// Ensimmäiseks luodaan kortit vakio joka valitsee kaikki elementit joilla on kortti luokka.
// Sitten looppi vari taulukon läpi ja valitsee satunnaisen värin joka kortille ja asettaa niille oikeat luokat.
const kortit = [...document.querySelectorAll('.kortti')];
for (let vari of varit){
  const kortti1Indeksi = parseInt(Math.random() * kortit.length);
  const kortti1 = kortit[kortti1Indeksi];
  kortit.splice(kortti1Indeksi, 1);
  kortti1.className += `${vari}`;
  kortti1.setAttribute('data-color', vari);

  const kortti2Indeksi = parseInt(Math.random() * kortit.length);
  const kortti2 = kortit[kortti2Indeksi];
  kortit.splice(kortti2Indeksi, 1);
  kortti2.className += `${vari}`;
  kortti2.setAttribute('data-color', vari);
}

function kunKorttiValitaan(e){
  const valinta = e.currentTarget;

  // Jos pelaaja on jo onnistunut valitsemaan parin niin tämä pätkä sitten varmistaa että mitään ei taphdu tai että elementit ei saa monia samannimisiä luokkia.
  if (estaValinta || valinta === valittuKortti || valinta.className.includes('pari')){
    return;
  }

// Tämä pätkä muodostaa parit ja kääntää kortit poistamalla piilotettu-kortti luokan ja antamalla sille pari luokan.
  valinta.className = valinta.className
    .replace('piilotettu-kortti', '')
    .trim();
  valinta.className += ' pari';

  if (!valittuKortti){
    valittuKortti = valinta;
  } else if (valittuKortti){
    // Tarkistaa jos ensimmäinen kortti on pari toisen valitun kortin kanssa.
    estaValinta = true;
    if (valittuKortti.getAttribute('data-color') !== valinta.getAttribute('data-color')){
      setTimeout(() => {
        valittuKortti.className = valittuKortti.className.replace('pari', '').trim() + ' piilotettu-kortti';
        valinta.className = valinta.className.replace('pari', '').trim() + ' piilotettu-kortti';
        valittuKortti = null;
        estaValinta = false;
      }, 500);
    } else {
      // Tämä else pätkä nostaa löydettyjen parien arvoja ja ilmoittaa pelaajalle että hän on voittanut pelin kun kaikki kahdeksan paria on löytýnyt.
      parejaLoydetty++;
      valittuKortti = null;
      estaValinta = false;
      if (parejaLoydetty === 8){
        alert('Voitit pelin!');
      }
    }
  }
}
