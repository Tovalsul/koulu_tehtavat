function tama(val)
{
document.getElementById("naytto").value +=val;
 }

function ratkaise(){
  let lasku = document.getElementById("naytto").value;
  let tulos = eval(lasku);
  document.getElementById("naytto").value = tulos;
}

function pyyhi()
{
document.getElementById("naytto").value = "";
}

/* const nappulat = document.querySelectorAll('.nappula');
const tulos = document.querySelector('tulos');
const cNappula = document.querySelector('cNappula');


for (let i = 0 ; i < nappulat.length; i++){
  nappulat[i].addEventListener('click', function(){
  let numero = nappulat[i].getAttribute('value');
  tulos.value += numero;
});
}



function testi(){
  alert('test test');
}


cNappula.addEventListener('click', function(){
  console.log("toimii");
});

/*
cNappula.addEventListener('click', function(){
  tulos.value = '';
});
*/
