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
-- Table structure for table `tblsubject`
--

DROP TABLE IF EXISTS `tblsubject`;
CREATE TABLE IF NOT EXISTS `tblsubject` (
  `code` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `year` varchar(50) NOT NULL,
  `sem` varchar(50) NOT NULL,
  `lechrs` varchar(50) NOT NULL,
  `tutorialhrs` varchar(50) NOT NULL,
  `labhrs` varchar(50) NOT NULL,
  `evalutionhrs` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsubject`
--

INSERT INTO `tblsubject` (`code`, `name`, `year`, `sem`, `lechrs`, `tutorialhrs`, `labhrs`, `evalutionhrs`) VALUES
('IT2030', 'EAP', '3', '1st Semester', '23', '15', '18', '30'),
('IT2020', 'IRSP', '2', '', '2', '2', '2', '2'),
('IT1916', 'DSA', '1', '2nd Semester', '23', '16', '23', '19'),
('IT1020', 'ESD', '3', '1st Semester', '27', '17', '12', '11');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
