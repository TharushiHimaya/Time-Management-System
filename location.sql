-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 18, 2021 at 08:07 PM
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
-- Database: `locationdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `location`
--

DROP TABLE IF EXISTS `location`;
CREATE TABLE IF NOT EXISTS `location` (
  `AddNo` varchar(50) NOT NULL,
  `DepartmentName` varchar(50) NOT NULL,
  `RoomType` varchar(20) NOT NULL,
  `RoomName` varchar(50) NOT NULL,
  `Capacity` varchar(11) NOT NULL,
  PRIMARY KEY (`AddNo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `location`
--

INSERT INTO `location` (`AddNo`, `DepartmentName`, `RoomType`, `RoomName`, `Capacity`) VALUES
('4', 'Electronic Engineering (EN)', 'Lecture Hall', '13L-C-pclab', '60'),
('3', 'Civil Engineering (EN)', 'Lecture Hall', 'Auditorium', '300'),
('2', 'Information Techlogy (IT)', 'Lecture Hall', '601-Pclab', '400'),
('1', 'Software Engineering (IT)', 'Lecture Hall', 'A402', '200');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
