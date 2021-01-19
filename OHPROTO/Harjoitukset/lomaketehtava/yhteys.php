<?php
$enimi = $_GET["enimi"];
$snimi = $_GET["snimi"];
$losoite = $_GET["losoite"];
$postinro = $_GET["postinro"];
$postitp = $_GET["postitp"];
$maa = $_GET["maa"];
$puh = $_GET["puh"];
$sahkop = $_GET["sahkop"];

//Otetaan yhteys tietokantaan
$palvelin = "localhost";
$kayttaja = "root";
$salasana = "";
$tietokanta = "lomake";

$link = mysqli_connect($palvelin, $kayttaja, $salasana, $tietokanta);

if(mysqli_connect_error())
{
	die("Tietokantaan ei saatu yhteyttä");
	}

$kysely = "INSERT INTO osoiterekisteri (etunimi, sukunimi, lahiosoite, postinumero, postitoimipaikka, maa, puhnumero, email) VALUES
('$enimi', '$snimi', '$losoite', '$postinro', '$postitp', '$maa', '$puh', '$sahkop')";
if (mysqli_query($link, $kysely))
{
	echo 'Uudet tiedostot päivitetty';
}
else
{
	echo 'Virhe: ' . '$kysely' . '<br>' . mysqli_error($link);
}
mysqli_close($link);
?>