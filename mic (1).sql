-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 13, 2024 at 09:24 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mic`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `AdminID` int(11) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `RoleID` int(11) NOT NULL,
  `Login` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`AdminID`, `FirstName`, `LastName`, `RoleID`, `Login`) VALUES
(9, 'admin', 'admin', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `contact`
--

CREATE TABLE `contact` (
  `ContactID` int(11) NOT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Phone` varchar(255) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `contact`
--

INSERT INTO `contact` (`ContactID`, `Address`, `Phone`, `Email`) VALUES
(1, 'Michail Lysenko Address', '+37060010001', 'michail.lysenko@example.com'),
(2, 'RandomName RandomLastName Address', '+37060010002', 'random.name@example.com'),
(3, 'Alice Johnson Address', '+37060010003', 'alice.johnson@example.com'),
(4, 'Bob Smith Address', '+37060010004', 'bob.smith@example.com'),
(5, 'Charlie Williams Address', '+37060010005', 'charlie.williams@example.com'),
(6, 'David Davis Address', '+37060010006', 'david.davis@example.com'),
(7, 'Emma Jones Address', '+37060010007', 'emma.jones@example.com'),
(8, 'Frank Miller Address', '+37060010008', 'frank.miller@example.com'),
(9, 'Grace Brown Address', '+37060010009', 'grace.brown@example.com'),
(10, 'Henry Wilson Address', '+37060010010', 'henry.wilson@example.com'),
(11, 'Ivy Moore Address', '+37060010011', 'ivy.moore@example.com'),
(12, 'Jack Taylor Address', '+37060010012', 'jack.taylor@example.com'),
(13, 'Katherine Evans Address', '+37060010013', 'katherine.evans@example.com'),
(14, 'Leo Anderson Address', '+37060010014', 'leo.anderson@example.com'),
(15, 'Mia Martin Address', '+37060010015', 'mia.martin@example.com'),
(16, 'Nathan Clark Address', '+37060010016', 'nathan.clark@example.com'),
(17, 'Olivia Allen Address', '+37060010017', 'olivia.allen@example.com'),
(18, 'Patrick Hill Address', '+37060010018', 'patrick.hill@example.com'),
(19, 'Quinn Ward Address', '+37060010019', 'quinn.ward@example.com'),
(20, 'Rachel Cooper Address', '+37060010020', 'rachel.cooper@example.com'),
(21, 'Samuel Baker Address', '+37060010021', 'samuel.baker@example.com'),
(22, 'Tiffany Fisher Address', '+37060010022', 'tiffany.fisher@example.com'),
(23, 'testtestAddress', '+37060000000', 'test.test@example.com'),
(24, 'JohnWickAddress', '+37060000000', 'John.Wick@example.com');

-- --------------------------------------------------------

--
-- Table structure for table `group`
--

CREATE TABLE `group` (
  `GroupID` int(11) NOT NULL,
  `GroupName` varchar(255) NOT NULL,
  `managerID` int(11) NOT NULL,
  `Balance` float NOT NULL,
  `TotalSize` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `group`
--

INSERT INTO `group` (`GroupID`, `GroupName`, `managerID`, `Balance`, `TotalSize`) VALUES
(0, 'DefaultGroup', 1, 0, 0),
(1, 'GroupOne', 1, 0, 0),
(2, 'GroupTwo', 1, 0, 0),
(3, 'GroupThree', 3, 0, 0),
(4, 'GroupFour', 2, 0, 0),
(5, 'GroupFive', 2, 0, 0),
(6, 'asdf', 3, 0, 0),
(7, 'GroupSeven', 4, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `groupbill`
--

CREATE TABLE `groupbill` (
  `groupBillID` int(11) NOT NULL,
  `GroupID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Price` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `groupbill`
--

INSERT INTO `groupbill` (`groupBillID`, `GroupID`, `Date`, `Price`) VALUES
(1, 1, '2023-11-30', 194),
(2, 2, '2023-11-30', 148),
(3, 3, '2023-11-30', 189),
(4, 4, '2023-11-30', 251),
(5, 5, '2023-11-30', 144),
(6, 1, '2023-12-31', 56),
(7, 2, '2023-12-31', 86),
(8, 3, '2023-12-31', 40),
(9, 4, '2023-12-31', 10),
(10, 5, '2023-12-31', 12),
(11, 6, '2023-12-31', 82),
(12, 7, '2023-12-31', 152),
(13, 1, '2024-01-31', 36),
(14, 2, '2024-01-31', 5),
(15, 3, '2024-01-31', 18),
(16, 4, '2024-01-31', NULL),
(17, 5, '2024-01-31', NULL),
(18, 6, '2024-01-31', NULL),
(19, 7, '2024-01-31', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `Login` int(11) NOT NULL,
  `Username` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`Login`, `Username`, `Password`) VALUES
(0, 'admin', 'admin'),
(1, 'manager1', 'manager1'),
(2, 'manager2', 'manager2'),
(3, 'manager3', 'manager3'),
(4, 'Michail', 'Lysenko'),
(5, 'RandomName', 'RandomLastName'),
(6, 'Alice', 'Johnson'),
(7, 'Bob', 'Smith'),
(8, 'Charlie', 'Williams'),
(9, 'David', 'Davis'),
(10, 'Emma', 'Jones'),
(11, 'Frank', 'Miller'),
(12, 'Grace', 'Brown'),
(13, 'Henry', 'Wilson'),
(14, 'Ivy', 'Moore'),
(15, 'Jack', 'Taylor'),
(16, 'Katherine', 'Evans'),
(17, 'Leo', 'Anderson'),
(18, 'Mia', 'Martin'),
(19, 'Nathan', 'Clark'),
(20, 'Olivia', 'Allen'),
(21, 'Patrick', 'Hill'),
(22, 'Quinn', 'Ward'),
(23, 'Rachel', 'Cooper'),
(24, 'Samuel', 'Baker'),
(25, 'Tiffany', 'Fisher'),
(26, 'test', 'test'),
(27, 'John', 'Wick'),
(28, 'Manager4', 'Manager4');

-- --------------------------------------------------------

--
-- Table structure for table `loginlog`
--

CREATE TABLE `loginlog` (
  `entryID` int(11) NOT NULL,
  `LoginID` int(11) NOT NULL,
  `DateTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `loginlog`
--

INSERT INTO `loginlog` (`entryID`, `LoginID`, `DateTime`) VALUES
(0, 0, '2023-11-21 00:00:00'),
(1, 1, '2023-11-01 12:34:56'),
(2, 2, '2023-11-02 09:45:12'),
(3, 3, '2023-11-03 15:23:45'),
(4, 4, '2023-11-04 18:02:34'),
(5, 5, '2023-11-05 07:56:21'),
(6, 6, '2023-11-06 14:27:59'),
(7, 7, '2023-11-07 11:08:43'),
(8, 8, '2023-11-08 17:39:32'),
(9, 9, '2023-11-09 10:15:28'),
(10, 10, '2023-11-10 22:41:09'),
(11, 11, '2023-11-11 05:12:37'),
(12, 12, '2023-11-12 16:09:54'),
(13, 13, '2023-11-13 13:22:17'),
(14, 14, '2023-11-14 19:48:32'),
(15, 15, '2023-11-15 08:37:45'),
(16, 16, '2023-11-16 20:59:01'),
(17, 17, '2023-11-17 09:14:26'),
(18, 18, '2023-11-18 14:55:42'),
(19, 19, '2023-11-19 16:37:59'),
(20, 20, '2023-11-20 12:04:15'),
(21, 0, '2024-01-06 17:25:35'),
(22, 4, '2024-01-06 17:26:19'),
(23, 0, '2024-01-06 17:32:23'),
(24, 1, '2024-01-07 12:18:53'),
(25, 1, '2024-01-07 12:26:37'),
(26, 1, '2024-01-07 12:28:27'),
(27, 1, '2024-01-07 12:32:55'),
(28, 1, '2024-01-07 12:44:25'),
(29, 1, '2024-01-07 12:46:20'),
(30, 2, '2024-01-07 12:47:56'),
(31, 1, '2024-01-07 12:52:42'),
(32, 1, '2024-01-07 12:54:52');

-- --------------------------------------------------------

--
-- Table structure for table `manager`
--

CREATE TABLE `manager` (
  `ManagerID` int(11) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `RoleID` int(11) NOT NULL,
  `Login` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `manager`
--

INSERT INTO `manager` (`ManagerID`, `FirstName`, `LastName`, `RoleID`, `Login`) VALUES
(1, 'Manager1', 'Manager1', 1, 1),
(2, 'Manager2', 'Manager2', 1, 2),
(3, 'Manager3', 'Manager3', 1, 3),
(4, 'Manager4', 'Manager4', 1, 28);

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `PaymentID` int(11) NOT NULL,
  `PersonID` int(11) NOT NULL,
  `Amount` int(11) NOT NULL,
  `Date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`PaymentID`, `PersonID`, `Amount`, `Date`) VALUES
(1, 1, 10, '2023-11-30 00:00:00'),
(2, 2, 15, '2023-11-30 00:00:00'),
(3, 3, 20, '2023-11-30 00:00:00'),
(4, 4, 25, '2023-11-30 00:00:00'),
(5, 5, 30, '2023-11-30 00:00:00'),
(6, 6, 35, '2023-11-30 00:00:00'),
(7, 7, 40, '2023-11-30 00:00:00'),
(8, 8, 45, '2023-11-30 00:00:00'),
(9, 9, 50, '2023-11-30 00:00:00'),
(10, 10, 55, '2023-11-30 00:00:00'),
(11, 11, 60, '2023-11-30 00:00:00'),
(12, 12, 65, '2023-11-30 00:00:00'),
(13, 13, 70, '2023-11-30 00:00:00'),
(14, 14, 75, '2023-11-30 00:00:00'),
(15, 15, 80, '2023-11-30 00:00:00'),
(16, 16, 85, '2023-11-30 00:00:00'),
(17, 17, 90, '2023-11-30 00:00:00'),
(18, 18, 95, '2023-11-30 00:00:00'),
(19, 19, 100, '2023-11-30 00:00:00'),
(20, 20, 105, '2023-11-30 00:00:00'),
(21, 21, 110, '2023-11-30 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `person`
--

CREATE TABLE `person` (
  `PersonID` int(11) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `RoleID` int(11) NOT NULL,
  `UnitID` int(11) DEFAULT NULL,
  `ContactID` int(11) DEFAULT NULL,
  `Login` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `person`
--

INSERT INTO `person` (`PersonID`, `FirstName`, `LastName`, `RoleID`, `UnitID`, `ContactID`, `Login`) VALUES
(1, 'Michail', 'Lysenko', 2, 1, 1, 4),
(2, 'RandomName', 'RandomLastName', 2, 2, 2, 5),
(3, 'Alice', 'Johnson', 2, 3, 3, 6),
(4, 'Bob', 'Smith', 2, 4, 4, 7),
(5, 'Charlie', 'Williams', 2, 5, 5, 8),
(6, 'David', 'Davis', 2, 6, 6, 9),
(7, 'Emma', 'Jones', 2, 7, 7, 10),
(8, 'Frank', 'Miller', 2, 8, 8, 11),
(9, 'Grace', 'Brown', 2, 9, 9, 12),
(10, 'Henry', 'Wilson', 2, 10, 10, 13),
(11, 'Ivy', 'Moore', 2, 11, 11, 14),
(12, 'Jack', 'Taylor', 2, 12, 12, 15),
(13, 'Katherine', 'Evans', 2, 13, 13, 16),
(14, 'Leo', 'Anderson', 2, 14, 14, 17),
(15, 'Mia', 'Martin', 2, 15, 15, 18),
(16, 'Nathan', 'Clark', 2, 16, 16, 19),
(17, 'Olivia', 'Allen', 2, 17, 17, 20),
(18, 'Patrick', 'Hill', 2, 18, 18, 21),
(19, 'Quinn', 'Ward', 2, 19, 19, 22),
(20, 'Rachel', 'Cooper', 2, 20, 20, 23),
(21, 'Samuel', 'Baker', 2, 21, 21, 24),
(22, 'Tiffany', 'Fisher', 2, 22, 22, 25),
(23, 'test', 'test', 2, 23, 23, 26),
(24, 'John', 'Wick', 2, 24, 24, 27);

-- --------------------------------------------------------

--
-- Table structure for table `provider`
--

CREATE TABLE `provider` (
  `ProviderID` int(11) NOT NULL,
  `ProviderName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `provider`
--

INSERT INTO `provider` (`ProviderID`, `ProviderName`) VALUES
(1, 'Provider0'),
(2, 'Provider2'),
(3, 'Provider3'),
(4, 'Provider4'),
(5, 'Provider5');

-- --------------------------------------------------------

--
-- Table structure for table `request`
--

CREATE TABLE `request` (
  `requestID` int(11) NOT NULL,
  `PersonID` int(11) NOT NULL,
  `Date` datetime NOT NULL,
  `Message` text NOT NULL,
  `Status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `request`
--

INSERT INTO `request` (`requestID`, `PersonID`, `Date`, `Message`, `Status`) VALUES
(1, 1, '2023-11-21 00:00:00', 'Him have solve problem 1', 0),
(2, 2, '2023-11-22 00:00:00', 'Need assistance with issue 2', 0),
(3, 3, '2023-11-23 00:00:00', 'Having trouble with task 3', 0),
(4, 4, '2023-11-24 00:00:00', 'Requesting help for problem 4', 0),
(5, 5, '2023-11-25 00:00:00', 'Seeking support for issue 5', 0),
(6, 1, '2023-11-26 00:00:00', 'Need urgent assistance with task 6', 0),
(7, 2, '2023-11-27 00:00:00', 'Facing challenges with problem 7', 0),
(8, 3, '2023-11-28 00:00:00', 'Request for help regarding task 8', 0),
(9, 4, '2023-11-29 00:00:00', 'Seeking resolution for issue 9', 0),
(10, 5, '2023-11-30 00:00:00', 'Having difficulty with problem 10', 0);

-- --------------------------------------------------------

--
-- Table structure for table `requestlog`
--

CREATE TABLE `requestlog` (
  `EntryID` int(11) NOT NULL,
  `requestID` int(11) NOT NULL,
  `AdminID` int(11) NOT NULL,
  `Message` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `requestlog`
--

INSERT INTO `requestlog` (`EntryID`, `requestID`, `AdminID`, `Message`) VALUES
(1, 1, 9, 'Solving'),
(2, 2, 9, 'Solving'),
(3, 3, 9, 'Solving');

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `RoleID` int(11) NOT NULL,
  `RoleName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`RoleID`, `RoleName`) VALUES
(0, 'Admin'),
(1, 'Manager'),
(2, 'Person');

-- --------------------------------------------------------

--
-- Table structure for table `service`
--

CREATE TABLE `service` (
  `serviceID` int(11) NOT NULL,
  `ServiceName` varchar(255) NOT NULL,
  `ServiceRate` float NOT NULL,
  `ProviderID` int(11) NOT NULL,
  `Date` datetime NOT NULL,
  `GroupBillID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `service`
--

INSERT INTO `service` (`serviceID`, `ServiceName`, `ServiceRate`, `ProviderID`, `Date`, `GroupBillID`) VALUES
(1, 'Service1', 20, 1, '2023-11-01 00:00:00', 1),
(2, 'Service2', 45, 2, '2023-11-02 00:00:00', 2),
(3, 'Service3', 78, 3, '2023-11-03 00:00:00', 3),
(4, 'Service4', 12, 4, '2023-11-04 00:00:00', 4),
(5, 'Service5', 63, 5, '2023-11-05 00:00:00', 5),
(6, 'Service6', 34, 1, '2023-11-06 00:00:00', 1),
(7, 'Service7', 87, 2, '2023-11-07 00:00:00', 2),
(8, 'Service8', 19, 3, '2023-11-08 00:00:00', 3),
(9, 'Service9', 56, 4, '2023-11-09 00:00:00', 4),
(10, 'Service10', 31, 5, '2023-11-10 00:00:00', 5),
(11, 'Service11', 72, 1, '2023-11-11 00:00:00', 1),
(12, 'Service12', 5, 2, '2023-11-12 00:00:00', 2),
(13, 'Service13', 42, 3, '2023-11-13 00:00:00', 3),
(14, 'Service14', 89, 4, '2023-11-14 00:00:00', 4),
(15, 'Service15', 23, 5, '2023-11-15 00:00:00', 5),
(16, 'Service16', 68, 1, '2023-11-16 00:00:00', 1),
(17, 'Service17', 11, 2, '2023-11-17 00:00:00', 2),
(18, 'Service18', 50, 3, '2023-11-18 00:00:00', 3),
(19, 'Service19', 94, 4, '2023-11-19 00:00:00', 4),
(20, 'Service20', 27, 5, '2023-11-20 00:00:00', 5),
(21, 'Service21', 25, 1, '2023-12-02 00:00:00', 6),
(22, 'Service22', 48, 3, '2023-12-03 00:00:00', 7),
(23, 'Service23', 16, 1, '2023-12-04 00:00:00', 8),
(24, 'Service24', 10, 1, '2023-12-05 00:00:00', 9),
(25, 'Service25', 12, 2, '2023-12-06 00:00:00', 10),
(26, 'Service26', 82, 3, '2023-12-07 00:00:00', 11),
(27, 'Service27', 78, 3, '2023-12-08 00:00:00', 12),
(28, 'Service28', 31, 4, '2023-12-09 00:00:00', 6),
(29, 'Service29', 38, 2, '2023-12-10 00:00:00', 7),
(30, 'Service30', 24, 2, '2023-12-11 00:00:00', 8),
(31, 'Service31', 74, 4, '2023-12-20 23:59:59', 12),
(42, 'Service42', 36, 2, '2024-01-01 00:00:00', 13),
(43, 'Service43', 5, 3, '2024-01-02 00:00:00', 14),
(44, 'Service44', 18, 3, '2024-01-03 00:00:00', 15);

-- --------------------------------------------------------

--
-- Table structure for table `unit`
--

CREATE TABLE `unit` (
  `UnitID` int(11) NOT NULL,
  `GroupID` int(11) NOT NULL,
  `UnitSize` float NOT NULL,
  `UnitName` varchar(255) NOT NULL,
  `PersonID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `unit`
--

INSERT INTO `unit` (`UnitID`, `GroupID`, `UnitSize`, `UnitName`, `PersonID`) VALUES
(1, 1, 69, 'UnitName1', 1),
(2, 2, 23, 'UnitName2', 2),
(3, 3, 57, 'UnitName3', 3),
(4, 4, 28, 'UnitName4', 4),
(5, 5, 63, 'UnitName5', 5),
(6, 1, 41, 'UnitName6', 6),
(7, 2, 55, 'UnitName7', 7),
(8, 3, 75, 'UnitName8', 8),
(9, 4, 21, 'UnitName9', 9),
(10, 5, 30, 'UnitName10', 10),
(11, 1, 68, 'UnitName11', 11),
(12, 2, 63, 'UnitName12', 12),
(13, 3, 34, 'UnitName13', 13),
(14, 4, 72, 'UnitName14', 14),
(15, 5, 73, 'UnitName15', 15),
(16, 1, 74, 'UnitName16', 16),
(17, 2, 75, 'UnitName17', 17),
(18, 3, 22, 'UnitName18', 18),
(19, 4, 34, 'UnitName19', 19),
(20, 5, 29, 'UnitName20', 20),
(21, 1, 21, 'UnitName21', 21),
(22, 2, 54, 'UnitName22', 22),
(23, 7, 50, 'UnitName23', 23),
(24, 0, 50, 'UnitName24', 24);

-- --------------------------------------------------------

--
-- Table structure for table `unitbill`
--

CREATE TABLE `unitbill` (
  `UnitBillID` int(11) NOT NULL,
  `UnitID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `TotalPrice` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `unitbill`
--

INSERT INTO `unitbill` (`UnitBillID`, `UnitID`, `Date`, `TotalPrice`) VALUES
(1, 1, '2023-11-30', 25),
(2, 2, '2023-11-30', 21),
(3, 3, '2023-11-30', 80),
(4, 4, '2023-11-30', 46),
(5, 5, '2023-11-30', 78),
(6, 6, '2023-11-30', 58),
(7, 7, '2023-11-30', 49),
(8, 8, '2023-11-30', 68),
(9, 9, '2023-11-30', 94),
(10, 10, '2023-11-30', 71),
(11, 11, '2023-11-30', 75),
(12, 12, '2023-11-30', 67),
(13, 13, '2023-11-30', 22),
(14, 14, '2023-11-30', 93),
(15, 15, '2023-11-30', 14),
(16, 16, '2023-11-30', 72),
(17, 17, '2023-11-30', 30),
(18, 18, '2023-11-30', 21),
(19, 19, '2023-11-30', 9);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`AdminID`),
  ADD UNIQUE KEY `Login` (`Login`),
  ADD KEY `FK_admin_role_RoleID` (`RoleID`);

--
-- Indexes for table `contact`
--
ALTER TABLE `contact`
  ADD PRIMARY KEY (`ContactID`);

--
-- Indexes for table `group`
--
ALTER TABLE `group`
  ADD PRIMARY KEY (`GroupID`),
  ADD KEY `FK_group_manager_ManagerID` (`managerID`);

--
-- Indexes for table `groupbill`
--
ALTER TABLE `groupbill`
  ADD PRIMARY KEY (`groupBillID`),
  ADD KEY `FK_groupbill_group_GroupID` (`GroupID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`Login`);

--
-- Indexes for table `loginlog`
--
ALTER TABLE `loginlog`
  ADD PRIMARY KEY (`entryID`),
  ADD KEY `FK_loginlog_login_Login` (`LoginID`);

--
-- Indexes for table `manager`
--
ALTER TABLE `manager`
  ADD PRIMARY KEY (`ManagerID`),
  ADD UNIQUE KEY `Login` (`Login`),
  ADD KEY `FK_manager_role_RoleID` (`RoleID`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`PaymentID`),
  ADD KEY `FK_payments_person_PersonID` (`PersonID`);

--
-- Indexes for table `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`PersonID`),
  ADD UNIQUE KEY `Login` (`Login`),
  ADD KEY `FK_person_unit_UnitID` (`UnitID`),
  ADD KEY `FK_person_role_RoleID` (`RoleID`),
  ADD KEY `FK_person_contact_ContactID` (`ContactID`);

--
-- Indexes for table `provider`
--
ALTER TABLE `provider`
  ADD PRIMARY KEY (`ProviderID`);

--
-- Indexes for table `request`
--
ALTER TABLE `request`
  ADD PRIMARY KEY (`requestID`),
  ADD KEY `FK_request_person_PersonID` (`PersonID`);

--
-- Indexes for table `requestlog`
--
ALTER TABLE `requestlog`
  ADD PRIMARY KEY (`EntryID`),
  ADD KEY `FK_requestlog_request_requestID` (`requestID`),
  ADD KEY `FK_requestlog_admin_AdminID` (`AdminID`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`RoleID`);

--
-- Indexes for table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`serviceID`),
  ADD KEY `FK_service_provider_ProviderID` (`ProviderID`),
  ADD KEY `FK_service_groupbill_groupBillID` (`GroupBillID`);

--
-- Indexes for table `unit`
--
ALTER TABLE `unit`
  ADD PRIMARY KEY (`UnitID`),
  ADD KEY `FK_unit_group_GroupID` (`GroupID`);

--
-- Indexes for table `unitbill`
--
ALTER TABLE `unitbill`
  ADD PRIMARY KEY (`UnitBillID`),
  ADD KEY `FK_unitbill_unit_UnitID` (`UnitID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `AdminID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `contact`
--
ALTER TABLE `contact`
  MODIFY `ContactID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT for table `group`
--
ALTER TABLE `group`
  MODIFY `GroupID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `groupbill`
--
ALTER TABLE `groupbill`
  MODIFY `groupBillID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
--
-- AUTO_INCREMENT for table `manager`
--
ALTER TABLE `manager`
  MODIFY `ManagerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `PaymentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `provider`
--
ALTER TABLE `provider`
  MODIFY `ProviderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `request`
--
ALTER TABLE `request`
  MODIFY `requestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `requestlog`
--
ALTER TABLE `requestlog`
  MODIFY `EntryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `RoleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `unitbill`
--
ALTER TABLE `unitbill`
  MODIFY `UnitBillID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `FK_admin_login_Login` FOREIGN KEY (`Login`) REFERENCES `login` (`Login`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_admin_role_RoleID` FOREIGN KEY (`RoleID`) REFERENCES `role` (`RoleID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `contact`
--
ALTER TABLE `contact`
  ADD CONSTRAINT `FK_contact_person_ContactID` FOREIGN KEY (`ContactID`) REFERENCES `person` (`ContactID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `group`
--
ALTER TABLE `group`
  ADD CONSTRAINT `FK_group_manager_ManagerID` FOREIGN KEY (`managerID`) REFERENCES `manager` (`ManagerID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `groupbill`
--
ALTER TABLE `groupbill`
  ADD CONSTRAINT `FK_groupbill_group_GroupID` FOREIGN KEY (`GroupID`) REFERENCES `group` (`GroupID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `loginlog`
--
ALTER TABLE `loginlog`
  ADD CONSTRAINT `FK_loginlog_login_Login` FOREIGN KEY (`LoginID`) REFERENCES `login` (`Login`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `manager`
--
ALTER TABLE `manager`
  ADD CONSTRAINT `FK_manager_login_Login` FOREIGN KEY (`Login`) REFERENCES `login` (`Login`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_manager_role_RoleID` FOREIGN KEY (`RoleID`) REFERENCES `role` (`RoleID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `payments`
--
ALTER TABLE `payments`
  ADD CONSTRAINT `FK_payments_person_PersonID` FOREIGN KEY (`PersonID`) REFERENCES `person` (`PersonID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `person`
--
ALTER TABLE `person`
  ADD CONSTRAINT `FK_person_login_Login` FOREIGN KEY (`Login`) REFERENCES `login` (`Login`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_person_role_RoleID` FOREIGN KEY (`RoleID`) REFERENCES `role` (`RoleID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `request`
--
ALTER TABLE `request`
  ADD CONSTRAINT `FK_request_person_PersonID` FOREIGN KEY (`PersonID`) REFERENCES `person` (`PersonID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `requestlog`
--
ALTER TABLE `requestlog`
  ADD CONSTRAINT `FK_requestlog_admin_AdminID` FOREIGN KEY (`AdminID`) REFERENCES `admin` (`AdminID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_requestlog_request_requestID` FOREIGN KEY (`requestID`) REFERENCES `request` (`requestID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `service`
--
ALTER TABLE `service`
  ADD CONSTRAINT `FK_service_groupbill_groupBillID` FOREIGN KEY (`GroupBillID`) REFERENCES `groupbill` (`groupBillID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_service_provider_ProviderID` FOREIGN KEY (`ProviderID`) REFERENCES `provider` (`ProviderID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `unit`
--
ALTER TABLE `unit`
  ADD CONSTRAINT `FK_unit_group_GroupID` FOREIGN KEY (`GroupID`) REFERENCES `group` (`GroupID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_unit_person_UnitID` FOREIGN KEY (`UnitID`) REFERENCES `person` (`UnitID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `unitbill`
--
ALTER TABLE `unitbill`
  ADD CONSTRAINT `FK_unitbill_unit_UnitID` FOREIGN KEY (`UnitID`) REFERENCES `unit` (`UnitID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
