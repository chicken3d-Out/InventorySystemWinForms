-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 07, 2021 at 07:23 AM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `username` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL,
  `firstName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `dateCreated` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`username`, `password`, `firstName`, `lastName`, `dateCreated`) VALUES
('admin', 'user', 'Vincent', 'Ontuca', '2021-06-07 05:03:28'),
('default', 'password', 'Jhepoy', 'Dizon', '2021-06-07 03:27:06'),
('qwerty', '1234', 'Allen', 'Kalbo', '2021-05-21 11:39:49');

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

CREATE TABLE `logs` (
  `phrase1` varchar(20) DEFAULT NULL,
  `StockChange` mediumint(9) NOT NULL,
  `phrase2` varchar(20) DEFAULT NULL,
  `phrase3` varchar(85) DEFAULT NULL,
  `dateChanged` timestamp NOT NULL DEFAULT current_timestamp(),
  `productID` smallint(6) NOT NULL,
  `username` varchar(15) DEFAULT NULL,
  `phrase4` varchar(5) DEFAULT NULL,
  `logsID` smallint(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `logs`
--

INSERT INTO `logs` (`phrase1`, `StockChange`, `phrase2`, `phrase3`, `dateChanged`, `productID`, `username`, `phrase4`, `logsID`) VALUES
('A total of ', 100, ' cases of ', ' has been released from the facility at exactly ', '2021-06-07 04:59:09', 100, 'qwerty', 'by', 16),
('A total of ', 6, ' cases of ', ' has been released from the facility at exactly ', '2021-06-07 04:59:30', 122, 'qwerty', 'by', 17),
('A total of ', 9, ' cases of ', ' has been added to the facility at exactly ', '2021-06-07 05:00:04', 107, 'qwerty', 'by', 18),
('A total of ', 55, ' cases of ', ' has been added to the facility at exactly ', '2021-06-07 05:01:56', 123, 'default', 'by', 19),
('A total of ', 140, ' cases of ', ' has been released from the facility at exactly ', '2021-06-07 05:03:58', 124, 'admin', 'by', 20),
('A total of ', 100, ' cases of ', ' has been added to the facility at exactly ', '2021-06-07 05:05:05', 124, 'admin', 'by', 21),
('A total of ', 100, ' cases of ', ' has been released from the facility at exactly ', '2021-06-07 05:20:30', 124, 'qwerty', 'by', 22);

-- --------------------------------------------------------

--
-- Table structure for table `price`
--

CREATE TABLE `price` (
  `priceID` smallint(6) NOT NULL,
  `Price` float(10,2) NOT NULL,
  `productID` smallint(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `price`
--

INSERT INTO `price` (`priceID`, `Price`, `productID`) VALUES
(2, 320.00, 101),
(3, 420.00, 102),
(4, 410.00, 100),
(5, 600.75, 103),
(6, 510.00, 104),
(7, 450.00, 105),
(8, 400.50, 106),
(9, 390.80, 107),
(10, 410.55, 108),
(11, 430.00, 109),
(12, 544.99, 110),
(13, 568.55, 111),
(14, 643.00, 114),
(15, 455.50, 115),
(16, 330.00, 116),
(17, 410.00, 117),
(18, 300.75, 118),
(19, 250.75, 119),
(20, 440.00, 120),
(21, 710.00, 121),
(22, 290.00, 122),
(23, 300.00, 123),
(24, 42.51, 124);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `productID` smallint(6) NOT NULL,
  `Product` varchar(50) NOT NULL,
  `Size` varchar(5) NOT NULL,
  `supplierID` smallint(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`productID`, `Product`, `Size`, `supplierID`) VALUES
(100, 'Coke', '1L', 1),
(101, 'Pepsi', '1L', 2),
(102, 'Coke', '1.75L', 1),
(103, 'San Miguel Pale Pilsen', '1L', 3),
(104, 'San Mig Light', '250ml', 3),
(105, 'San Miguel Flavored Beer', '250ml', 3),
(106, 'Powerade', '250ml', 2),
(107, '7-Up', '250ml', 2),
(108, 'Mountain Dew', '250ml', 2),
(109, 'Pineapple Juice', '250ml', 4),
(110, 'Strawberry Juice', '250ml', 4),
(111, 'Orange Juice', '250ml', 4),
(114, 'Ginebra San Miguel', '250ml', 5),
(115, 'GSM Blue', '250ml', 5),
(116, 'C2 Green Tea', '250ml', 7),
(117, 'Chuckie', '250ml', 6),
(118, 'Kopiko 78C', '250ml', 6),
(119, 'Mirinda', '250ml', 2),
(120, 'Coke Zero', '250ml', 1),
(121, 'Coke', '1.5L', 1),
(122, 'Vitasoy', '250ml', 6),
(123, 'C2 Apple', '250ml', 6),
(124, 'Vita Milk', '250ml', 6);

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `stockID` smallint(6) NOT NULL,
  `Stock` mediumint(9) NOT NULL,
  `date_Added` date NOT NULL DEFAULT current_timestamp(),
  `productID` smallint(6) NOT NULL,
  `username` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`stockID`, `Stock`, `date_Added`, `productID`, `username`) VALUES
(7, 200, '2021-05-24', 100, 'qwerty'),
(8, 100, '2021-05-24', 101, 'qwerty'),
(9, 100, '2021-05-24', 102, 'qwerty'),
(11, 141, '2021-05-25', 103, 'qwerty'),
(12, 213, '2021-05-25', 104, 'qwerty'),
(13, 345, '2021-05-25', 105, 'qwerty'),
(14, 400, '2021-05-25', 106, 'qwerty'),
(15, 620, '2021-05-25', 107, 'qwerty'),
(16, 141, '2021-05-25', 108, 'qwerty'),
(17, 568, '2021-05-25', 109, 'qwerty'),
(18, 465, '2021-05-25', 110, 'qwerty'),
(19, 657, '2021-05-25', 111, 'qwerty'),
(20, 141, '2021-05-25', 114, 'qwerty'),
(21, 546, '2021-05-25', 115, 'qwerty'),
(22, 456, '2021-05-25', 116, 'qwerty'),
(23, 769, '2021-05-25', 117, 'qwerty'),
(24, 432, '2021-05-25', 118, 'qwerty'),
(25, 567, '2021-05-25', 119, 'qwerty'),
(26, 617, '2021-05-25', 120, 'qwerty'),
(27, 234, '2021-05-25', 121, 'qwerty'),
(28, 560, '2021-05-25', 122, 'qwerty'),
(29, 555, '2021-05-25', 123, 'default'),
(30, 300, '2021-06-07', 124, 'qwerty');

--
-- Triggers `stock`
--
DELIMITER $$
CREATE TRIGGER `logRecords` BEFORE UPDATE ON `stock` FOR EACH ROW BEGIN
IF OLD.Stock > NEW.Stock THEN
INSERT INTO logs VALUES ('A total of ',old.Stock - new.Stock,' cases of ',' has been released from the facility at exactly ',current_timestamp(),old.productID,new.username,'by','');
ELSEIF OLD.Stock < NEW.Stock THEN
INSERT INTO logs VALUES ('A total of ',new.Stock - old.Stock,' cases of ',' has been added to the facility at exactly ',current_timestamp(),old.productID,new.username,'by','');
END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `supplierID` smallint(6) NOT NULL,
  `supplierName` varchar(50) NOT NULL,
  `contactNum` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`supplierID`, `supplierName`, `contactNum`) VALUES
(1, 'Coca-Cola Corporation', '141-6754'),
(2, 'Pepsi Corporation', '111-4421'),
(3, 'San Miguel Corp.', '213-9901'),
(4, 'Delmonte Inc.', '234-9982'),
(5, 'Ginebra San Miguel Corp.', '457-2001'),
(6, 'Nestle Corp.', '245-9110'),
(7, 'Universal Robina Corp.', '321-2019');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`logsID`),
  ADD KEY `productID` (`productID`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `price`
--
ALTER TABLE `price`
  ADD PRIMARY KEY (`priceID`),
  ADD KEY `productID` (`productID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`productID`),
  ADD KEY `supplierID` (`supplierID`);

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`stockID`),
  ADD KEY `productID` (`productID`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`supplierID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `logs`
--
ALTER TABLE `logs`
  MODIFY `logsID` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `price`
--
ALTER TABLE `price`
  MODIFY `priceID` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `productID` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=125;

--
-- AUTO_INCREMENT for table `stock`
--
ALTER TABLE `stock`
  MODIFY `stockID` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `supplierID` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `logs`
--
ALTER TABLE `logs`
  ADD CONSTRAINT `logs_ibfk_1` FOREIGN KEY (`productID`) REFERENCES `product` (`productID`),
  ADD CONSTRAINT `logs_ibfk_2` FOREIGN KEY (`username`) REFERENCES `account` (`username`);

--
-- Constraints for table `price`
--
ALTER TABLE `price`
  ADD CONSTRAINT `price_ibfk_1` FOREIGN KEY (`productID`) REFERENCES `product` (`productID`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`supplierID`) REFERENCES `supplier` (`supplierID`);

--
-- Constraints for table `stock`
--
ALTER TABLE `stock`
  ADD CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`productID`) REFERENCES `product` (`productID`),
  ADD CONSTRAINT `stock_ibfk_2` FOREIGN KEY (`username`) REFERENCES `account` (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
