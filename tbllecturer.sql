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
-- Table structure for table `tbllecturer`
--

DROP TABLE IF EXISTS `tbllecturer`;
CREATE TABLE IF NOT EXISTS `tbllecturer` (
  `id` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `faculty` varchar(50) NOT NULL,
  `department` varchar(50) NOT NULL,
  `building` varchar(50) NOT NULL,
  `center` varchar(50) NOT NULL,
  `rank` varchar(50) NOT NULL,
  `level` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbllecturer`
--

INSERT INTO `tbllecturer` (`id`, `name`, `faculty`, `department`, `building`, `center`, `rank`, `level`) VALUES
('030', 'Binuli', 'Computing', 'HR', 'C-block', 'Metro ', '1', '1'),
('001', 'Amandi y', 'Business', 'Engineering', 'C-block', 'Matara', '2', '2'),
('002', 'Ayodhya', 'Engineering', 'Engineering', 'D-block', 'Matara', '4', '2'),
('034', 'Ganeesha', 'Engineering', 'Engineering', 'D-block', 'Kandy', '3', '5'),
('046', 'Iresha', 'Engineering', 'IT', 'C-block', 'Matara', '4', '1'),
('0995', 'Ramya P', 'Business', 'Engineering', 'D-block', 'Malabe', '4', '2');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
