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
-- Database: `sessiondb`
--

-- --------------------------------------------------------

--
-- Table structure for table `consecutive`
--

DROP TABLE IF EXISTS `consecutive`;
CREATE TABLE IF NOT EXISTS `consecutive` (
  `ID` varchar(11) NOT NULL,
  `Lecturer1` varchar(50) NOT NULL,
  `Lecturer2` varchar(50) NOT NULL,
  `SubjectCode` varchar(50) NOT NULL,
  `SubjectName` varchar(50) NOT NULL,
  `GroupID` varchar(20) NOT NULL,
  `Tag` varchar(50) NOT NULL,
  `StudentCount` varchar(50) NOT NULL,
  `Duration` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consecutive`
--

INSERT INTO `consecutive` (`ID`, `Lecturer1`, `Lecturer2`, `SubjectCode`, `SubjectName`, `GroupID`, `Tag`, `StudentCount`, `Duration`) VALUES
('1', 'Mrs. Uthpala Ishadini', '', 'IT3030', 'SE', 'Y1S2.06.1', 'lecture/tute', '150', '3'),
('2', 'Mr. Savindra Keshan', 'Miss Iresha Ravihari', 'IT2030', 'ITPM', 'Y3S1.06,Y3S1.05', 'lecture/tute', '200', '3'),
('3', 'Mrs. Kushnara Suuriyawanse', '', 'IT2030', 'OOC', 'Y1S2.06.1', 'lecture/tute', '200', '3');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
