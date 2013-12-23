-- phpMyAdmin SQL Dump
-- version 4.0.0
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 23, 2013 at 11:01 PM
-- Server version: 5.5.27
-- PHP Version: 5.4.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `ps_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `karta`
--

CREATE TABLE IF NOT EXISTS `karta` (
  `idKarta` int(11) NOT NULL AUTO_INCREMENT,
  `idTrasa` int(11) NOT NULL,
  `idPopust` int(11) NOT NULL,
  `idStanicaPolaska` int(11) NOT NULL,
  `idStanicaDolaska` int(11) NOT NULL,
  `vremePolaska` int(11) NOT NULL,
  `cena` int(11) NOT NULL,
  `aktivnost` int(11) NOT NULL,
  `povratna` int(11) NOT NULL,
  PRIMARY KEY (`idKarta`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;

--
-- Dumping data for table `karta`
--

INSERT INTO `karta` (`idKarta`, `idTrasa`, `idPopust`, `idStanicaPolaska`, `idStanicaDolaska`, `vremePolaska`, `cena`, `aktivnost`, `povratna`) VALUES
(1, 0, 0, 0, 0, 0, 0, 0, 0),
(2, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `otkazanavoznja`
--

CREATE TABLE IF NOT EXISTS `otkazanavoznja` (
  `idOtkazanaVoznja` int(11) NOT NULL AUTO_INCREMENT,
  `idTrasa` int(11) NOT NULL,
  `datum` int(11) NOT NULL,
  `vreme` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idOtkazanaVoznja`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `popusti`
--

CREATE TABLE IF NOT EXISTS `popusti` (
  `idPopust` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `procenat` int(11) NOT NULL,
  PRIMARY KEY (`idPopust`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=2 ;

--
-- Dumping data for table `popusti`
--

INSERT INTO `popusti` (`idPopust`, `naziv`, `procenat`) VALUES
(1, 'studentski', 20);

-- --------------------------------------------------------

--
-- Table structure for table `redvoznje`
--

CREATE TABLE IF NOT EXISTS `redvoznje` (
  `idRedVoznje` int(11) NOT NULL AUTO_INCREMENT,
  `idTrasa` int(11) NOT NULL,
  `dan` int(11) NOT NULL,
  `vremePolaska` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idRedVoznje`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `stanica`
--

CREATE TABLE IF NOT EXISTS `stanica` (
  `idStanica` int(11) NOT NULL AUTO_INCREMENT,
  `ime` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idStanica`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=3 ;

--
-- Dumping data for table `stanica`
--

INSERT INTO `stanica` (`idStanica`, `ime`) VALUES
(1, 'bg'),
(2, 'ns');

-- --------------------------------------------------------

--
-- Table structure for table `trasa`
--

CREATE TABLE IF NOT EXISTS `trasa` (
  `idTrasa` int(11) NOT NULL AUTO_INCREMENT,
  `polazak` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `dolazak` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `ukupnoKm` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idTrasa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `trasastanica`
--

CREATE TABLE IF NOT EXISTS `trasastanica` (
  `idTrasaStanica` int(11) NOT NULL AUTO_INCREMENT,
  `idTrasa` int(11) NOT NULL,
  `idStanica` int(11) NOT NULL,
  `kmOd` int(11) NOT NULL,
  `kmDo` int(11) NOT NULL,
  PRIMARY KEY (`idTrasaStanica`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
