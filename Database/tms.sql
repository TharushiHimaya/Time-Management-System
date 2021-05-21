-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 21, 2021 at 03:01 PM
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
-- Table structure for table `add_nat`
--

DROP TABLE IF EXISTS `add_nat`;
CREATE TABLE IF NOT EXISTS `add_nat` (
  `ID` int(11) NOT NULL,
  `lecturer` varchar(50) NOT NULL,
  `gp` varchar(50) NOT NULL,
  `sub_gp` varchar(50) NOT NULL,
  `day` varchar(50) NOT NULL,
  `stime` time NOT NULL,
  `etime` time NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `add_nat`
--

INSERT INTO `add_nat` (`ID`, `lecturer`, `gp`, `sub_gp`, `day`, `stime`, `etime`) VALUES
(1, 'Ms. Hansi', 'Y1.S1.IT.03', 'Y1.S1.IT.03.1', 'Tuesday', '14:00:00', '16:00:00'),
(2, 'Ms. Hansi', 'Y1.S1.IT.03', 'Y1.S1.IT.03.1', 'Tuesday', '14:00:00', '16:00:00');

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

-- --------------------------------------------------------

--
-- Table structure for table `consecutive_room`
--

DROP TABLE IF EXISTS `consecutive_room`;
CREATE TABLE IF NOT EXISTS `consecutive_room` (
  `ID` varchar(11) NOT NULL,
  `Lecturer1` varchar(50) NOT NULL,
  `Lecturer2` varchar(50) NOT NULL,
  `SubjectCode` varchar(50) NOT NULL,
  `SubjectName` varchar(50) NOT NULL,
  `GroupID` varchar(20) NOT NULL,
  `Tag` varchar(50) NOT NULL,
  `StudentCount` varchar(50) NOT NULL,
  `Duration` varchar(50) NOT NULL,
  `RoomName` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consecutive_room`
--

INSERT INTO `consecutive_room` (`ID`, `Lecturer1`, `Lecturer2`, `SubjectCode`, `SubjectName`, `GroupID`, `Tag`, `StudentCount`, `Duration`, `RoomName`) VALUES
('1', 'Mrs. Uthpala Ishadini', '', 'IT3030', 'SE', 'Y1S2.06.1', 'lecture/tute', '150', '3', '13L-C-pclab'),
('2', 'Mr. Savindra Keshan', 'Miss Iresha Ravihari', 'IT2030', 'ITPM', 'Y3S1.06,Y3S1.05', 'lecture/tute', '200', '3', 'Auditorium'),
('3', 'Mrs. Kushnara Suuriyawanse', '', 'IT2030', 'OOC', 'Y1S2.06.1', 'lecture/tute', '200', '3', 'Auditorium');

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
('4', 'Business Management (BM)', 'Lecture Hall', '601-Pclab', '300'),
('3', 'Civil Engineering (EN)', 'Lecture Hall', 'Auditorium', '300'),
('2', 'Information Techlogy (IT)', 'Lecture Hall', '601-Pclab', '400'),
('1', 'Software Engineering (IT)', 'Lecture Hall', 'A402', '200');

-- --------------------------------------------------------

--
-- Table structure for table `nat_for_rooms`
--

DROP TABLE IF EXISTS `nat_for_rooms`;
CREATE TABLE IF NOT EXISTS `nat_for_rooms` (
  `room` varchar(50) NOT NULL,
  `day` varchar(50) NOT NULL,
  `Stime` time NOT NULL,
  `Etime` time NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `nat_for_rooms`
--

INSERT INTO `nat_for_rooms` (`room`, `day`, `Stime`, `Etime`) VALUES
('A503', 'Wednesday', '08:00:00', '12:00:00'),
('A503', 'Thursday', '08:00:00', '11:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `session`
--

DROP TABLE IF EXISTS `session`;
CREATE TABLE IF NOT EXISTS `session` (
  `ID` varchar(11) NOT NULL,
  `Lecturer1` varchar(50) NOT NULL,
  `Lecturer2` varchar(50) NOT NULL,
  `SubjectCode` varchar(11) NOT NULL,
  `SubjectName` varchar(50) NOT NULL,
  `GroupID` varchar(20) NOT NULL,
  `Tag` varchar(50) NOT NULL,
  `StudentCount` varchar(50) NOT NULL,
  `Duration` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `session`
--

INSERT INTO `session` (`ID`, `Lecturer1`, `Lecturer2`, `SubjectCode`, `SubjectName`, `GroupID`, `Tag`, `StudentCount`, `Duration`) VALUES
('1', 'Mr. Dammika Senevirathne', 'Miss Shiromi Ranwella', 'IT1030', 'OOP', 'G05', 'lecture', '100', '2'),
('2', 'Mrs. Uthpala Ishadini', 'Miss Iresha Ravihari', 'IT3030', 'ITPM', 'G09', 'lab', '45', '2');

-- --------------------------------------------------------

--
-- Table structure for table `session_room`
--

DROP TABLE IF EXISTS `session_room`;
CREATE TABLE IF NOT EXISTS `session_room` (
  `ID` varchar(11) NOT NULL,
  `Lecturer1` varchar(50) NOT NULL,
  `Lecturer2` varchar(50) NOT NULL,
  `SubjectCode` varchar(11) NOT NULL,
  `SubjectName` varchar(50) NOT NULL,
  `GroupID` varchar(20) NOT NULL,
  `Tag` varchar(50) NOT NULL,
  `StudentCount` varchar(50) NOT NULL,
  `Duration` varchar(50) NOT NULL,
  `RoomName` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `session_room`
--

INSERT INTO `session_room` (`ID`, `Lecturer1`, `Lecturer2`, `SubjectCode`, `SubjectName`, `GroupID`, `Tag`, `StudentCount`, `Duration`, `RoomName`) VALUES
('1', 'Mr. Dammika Senevirathne', 'Miss Shiromi Ranwella', 'IT1030', 'OOP', 'G05', 'lecture', '100', '2', 'Auditorium');

-- --------------------------------------------------------

--
-- Table structure for table `stdgroup_table`
--

DROP TABLE IF EXISTS `stdgroup_table`;
CREATE TABLE IF NOT EXISTS `stdgroup_table` (
  `year` varchar(4) NOT NULL,
  `Program` varchar(50) NOT NULL,
  `Gnumber` int(11) NOT NULL,
  `SubGnumber` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tagtable`
--

DROP TABLE IF EXISTS `tagtable`;
CREATE TABLE IF NOT EXISTS `tagtable` (
  `tagname` varchar(50) NOT NULL,
  `tagcode` varchar(50) NOT NULL,
  `relatedtag` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tagtable`
--

INSERT INTO `tagtable` (`tagname`, `tagcode`, `relatedtag`) VALUES
('Data Science', 'IT2030', 'Lecture');

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
('046', 'IreshaU', 'Engineering', 'IT', 'C-block', 'Matara', '4', '1'),
('45', 'Himaya', 'Business', 'Engineering', 'D-block', 'Matara', '4', '2'),
('899', 'Dias', 'Computing', 'Engineering', 'New building', 'Matara', '899.2', '2');

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
) ENGINE=MyISAM AUTO_INCREMENT=4546 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsession`
--

INSERT INTO `tblsession` (`sid`, `lec1`, `lec2`, `tag`, `groupid`, `subject`, `studentno`, `duration`) VALUES
(33, 'dfdg', 'dfdg', 'Tutorial', 'dfdf', 'fdgf', '54', '5657'),
(56, 'Nipunsala', 'Shashini', 'Tutorial', 'Y1.S2.IT.01', 'ITPM - IT2867', '34', '8.00 AM - 12.00 PM'),
(6, 'Uthpala', 'Thusharani', 'Select Tags', 'Y1.S1.IT.04', 'ITPM - IT2867', '43', '1.00 PM - 5.00 PM'),
(4545, 'ghghg', 'fgfghb', 'Tutorial', 'Y1.S1.IT.02', 'ITPM - IT2867', '6768', '1.00 PM - 5.00 PM');

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
('IT1020', 'ESD', '3', '1st Semester', '27', '17', '12', '11'),
('IT2050', 'Data Science', '2012', '2nd Semester', '6', '3', '3', '3');

-- --------------------------------------------------------

--
-- Table structure for table `timeslot_table`
--

DROP TABLE IF EXISTS `timeslot_table`;
CREATE TABLE IF NOT EXISTS `timeslot_table` (
  `Listing` varchar(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Stime` time NOT NULL,
  `Etime` time NOT NULL,
  `Duration` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `timeslot_table`
--

INSERT INTO `timeslot_table` (`Listing`, `Date`, `Stime`, `Etime`, `Duration`) VALUES
('Y2S2G13(IT)-B502', 'Thursday, April 8, 2021', '08:00:00', '10:00:00', '02  Hour(s)  00  Minute(s)  00  Second(s)  '),
('Y2S1G10(IT)-A303', 'Sunday, April 11, 2021', '11:30:00', '13:30:00', '02  Hour(s)  00  Minute(s)  00  Second(s)  '),
('Y2S1G10(IT)-A303', 'Monday, April 19, 2021', '16:00:00', '18:00:00', '02  Hour(s)  00  Minute(s)  00  Second(s)  '),
('Y2S1G10(IT)-A303', 'Friday, April 23, 2021', '00:00:00', '00:00:00', '00  Hour(s)  00  Minute(s)  00  Second(s)  '),
('Y2S1G10(IT)-A303', 'Saturday, April 10, 2021', '08:30:00', '10:30:00', '02  Hour(s)  00  Minute(s)  00  Second(s)  '),
('Y2S1G10(IT)-A303', 'Saturday, April 10, 2021', '08:10:00', '10:10:00', '02  Hour(s)  00  Minute(s)  00  Second(s)  '),
('Y2S2G13(IT)-B502', 'Saturday, May 8, 2021', '07:00:00', '09:00:00', '02  Hour(s)  00  Minute(s)  00  Second(s)  '),
('Y2S1G10(IT)-A303', 'Monday, May 24, 2021', '14:00:00', '16:00:00', '02  Hour(s)  00  Minute(s)  00  Second(s)  ');

-- --------------------------------------------------------

--
-- Table structure for table `working_ds_and_hrs_table`
--

DROP TABLE IF EXISTS `working_ds_and_hrs_table`;
CREATE TABLE IF NOT EXISTS `working_ds_and_hrs_table` (
  `No_of_working_days` int(11) NOT NULL,
  `Working_days` varchar(100) NOT NULL,
  `Working_hrs_per_day` int(11) NOT NULL,
  `Working_Mins_per_day` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `working_ds_and_hrs_table`
--

INSERT INTO `working_ds_and_hrs_table` (`No_of_working_days`, `Working_days`, `Working_hrs_per_day`, `Working_Mins_per_day`) VALUES
(5, 'Monday  ,  Tuesday  ,  Wednesday  ,  Thursday  ,  Friday  ,  ', 8, 30);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
