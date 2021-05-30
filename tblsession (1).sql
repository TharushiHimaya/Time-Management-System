-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 18, 2021 at 08:02 PM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tms`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblsession`
--

DROP TABLE IF EXISTS `tblsession`;
CREATE TABLE IF NOT EXISTS `tblsession` (
  `sid` int(50) NOT NULL AUTO_INCREMENT,
  `lec1` varchar(50) NOT NULL,
  `lec2` varchar(50) NOT NULL,
  `tag` varchar(50) NOT NULL,
  `groupid` varchar(50) NOT NULL,
  `subject` varchar(50) NOT NULL,
  `studentno` varchar(50) NOT NULL,
  `duration` varchar(50) NOT NULL,
  PRIMARY KEY (`sid`)
) ENGINE=MyISAM AUTO_INCREMENT=57 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsession`
--

INSERT INTO `tblsession` (`sid`, `lec1`, `lec2`, `tag`, `groupid`, `subject`, `studentno`, `duration`) VALUES
(33, 'dfdg', 'dfdg', 'Tutorial', 'dfdf', 'fdgf', '54', '5657'),
(56, 'Nipunsala', 'Shashini', 'Tutorial', 'Y1.S2.IT.01', 'ITPM - IT2867', '34', '8.00 AM - 12.00 PM'),
(6, 'Uthpala', 'Thusharani', 'Select Tags', 'Y1.S1.IT.04', 'ITPM - IT2867', '43', '1.00 PM - 5.00 PM');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
