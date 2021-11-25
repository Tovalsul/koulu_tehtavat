-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 12, 2020 at 07:18 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `csharp_hotellinvarausjarjestelmadb`
--

-- --------------------------------------------------------

--
-- Table structure for table `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `id` int(11) NOT NULL,
  `etu_nimi` varchar(50) NOT NULL,
  `suku_nimi` varchar(50) NOT NULL,
  `puhelin_nro` varchar(20) NOT NULL,
  `maa` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `asiakkaat`
--

INSERT INTO `asiakkaat` (`id`, `etu_nimi`, `suku_nimi`, `puhelin_nro`, `maa`) VALUES
(1, 'Eero', 'Erkkilä', '2223099', 'Suomi'),
(2, 'Aasi', 'Akas', '4040338338', 'suomi'),
(3, 'idtest', 'poistonjalkeen', '03934747', 'täs'),
(4, 'kikkels', 'kokkels', '0349780392', 'suomi'),
(5, 'lester', 'idtester', '038573902', 'Borneo'),
(6, 'fdafda', 'ogfjjhf', '9239023', 'Papua uusi Guinea'),
(11, 'Joku', 'Jostain', '020402111', 'Ei');

-- --------------------------------------------------------

--
-- Table structure for table `eri_huone_tyypit`
--

CREATE TABLE `eri_huone_tyypit` (
  `kategoria_id` int(11) NOT NULL,
  `leima` varchar(200) NOT NULL,
  `hinta` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `eri_huone_tyypit`
--

INSERT INTO `eri_huone_tyypit` (`kategoria_id`, `leima`, `hinta`) VALUES
(1, 'Yhden hengen huone', '1000€'),
(2, 'Kahden hengen huone', '2000€'),
(3, 'Perhe huone', '3000€'),
(4, 'Sviitti', '5000€');

-- --------------------------------------------------------

--
-- Table structure for table `huoneet`
--

CREATE TABLE `huoneet` (
  `huone_numero` int(11) NOT NULL,
  `huoneTyyppi` int(11) NOT NULL,
  `puhelin` varchar(100) NOT NULL,
  `vapaana` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `huoneet`
--

INSERT INTO `huoneet` (`huone_numero`, `huoneTyyppi`, `puhelin`, `vapaana`) VALUES
(5, 4, '0983543', 'Kyllä'),
(6, 2, '2343266', 'Ei'),
(8, 2, '9043568', 'Kyllä'),
(9, 1, '203575', 'Kyllä'),
(12, 3, '65432', 'Kyllä'),
(14, 3, '775432', 'Kyllä'),
(54, 1, '790432', 'Kyllä'),
(101, 1, '2354623', 'Kyllä'),
(102, 2, '765422', 'Ei'),
(103, 2, '1124532', 'Kyllä'),
(104, 1, '53485928', 'Kyllä');

-- --------------------------------------------------------

--
-- Table structure for table `kayttajat`
--

CREATE TABLE `kayttajat` (
  `id` int(11) NOT NULL,
  `kayttajanimi` varchar(50) NOT NULL,
  `salasana` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kayttajat`
--

INSERT INTO `kayttajat` (`id`, `kayttajanimi`, `salasana`) VALUES
(1, 'admin', 'idiamin');

-- --------------------------------------------------------

--
-- Table structure for table `varaukset`
--

CREATE TABLE `varaukset` (
  `varausId` int(11) NOT NULL,
  `huoneNro` int(11) NOT NULL,
  `asiakasId` int(11) NOT NULL,
  `varausAlkaa` varchar(11) NOT NULL,
  `varausPaattyy` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `varaukset`
--

INSERT INTO `varaukset` (`varausId`, `huoneNro`, `asiakasId`, `varausAlkaa`, `varausPaattyy`) VALUES
(15, 9, 1, '13/12/2020 ', '14/12/2020 '),
(20, 6, 5, '16/12/2020 ', '17/12/2020 ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `eri_huone_tyypit`
--
ALTER TABLE `eri_huone_tyypit`
  ADD PRIMARY KEY (`kategoria_id`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`huone_numero`),
  ADD KEY `fk_tyyppi_id` (`huoneTyyppi`);

--
-- Indexes for table `kayttajat`
--
ALTER TABLE `kayttajat`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD PRIMARY KEY (`varausId`),
  ADD KEY `fk_huone_nro` (`huoneNro`),
  ADD KEY `fk_asiakas_id` (`asiakasId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `eri_huone_tyypit`
--
ALTER TABLE `eri_huone_tyypit`
  MODIFY `kategoria_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `kayttajat`
--
ALTER TABLE `kayttajat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `varaukset`
--
ALTER TABLE `varaukset`
  MODIFY `varausId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD CONSTRAINT `fk_tyyppi_id` FOREIGN KEY (`huoneTyyppi`) REFERENCES `eri_huone_tyypit` (`kategoria_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD CONSTRAINT `fk_asiakas_id` FOREIGN KEY (`asiakasId`) REFERENCES `asiakkaat` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_huone_nro` FOREIGN KEY (`huoneNro`) REFERENCES `huoneet` (`huone_numero`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
