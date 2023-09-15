-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 15, 2023 at 04:16 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `salonsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `Id` int(11) NOT NULL,
  `First_Name` varchar(255) NOT NULL,
  `Last_Name` varchar(255) NOT NULL,
  `Gender` varchar(255) NOT NULL,
  `Date_of_Birth` varchar(255) NOT NULL,
  `Arriving_Date` varchar(255) NOT NULL,
  `Mobile_Number` bigint(10) NOT NULL,
  `Address` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`Id`, `First_Name`, `Last_Name`, `Gender`, `Date_of_Birth`, `Arriving_Date`, `Mobile_Number`, `Address`) VALUES
(1, 'Harsh', 'Ramwani', 'Male', '06-06-2003', '22-10-2020', 9978676386, 'Gandhidham'),
(2, 'Madhav', 'Gianchandani', 'Male', '24-12-2010', '22-09-2020', 7984814938, 'Gandhidham'),
(3, 'Dhruv', 'Karelia', 'Male', '15-05-2010', '22-10-2020', 7016697973, 'Gandhidham'),
(4, 'Meena', 'Ramwani', 'Female', '20-08-1962', '22-10-2020', 1234567890, 'Gandhidham'),
(5, 'Kruti', 'Shah', 'Female', '14-02-2006', '22-10-2020', 9876543210, 'Tarapur'),
(6, 'Lokesh', 'Maheswari', 'Male', '11-04-1996', '24-10-2020', 1212343456, 'Jai Mataji'),
(7, 'Janvi', 'Humbal', 'Female', '27-03-2003', '27-10-2020', 6354959880, 'Adipur'),
(8, 'Vishal', 'Tahiliani', 'Male', '30-08-2002', '28-10-2020', 8160532983, 'Aadipur'),
(9, 'Honey', 'Vacharaji', 'Female', '17-06-1971', '28-10-2020', 9825422115, 'Aadipur'),
(10, 'Jayesh', 'Belani', 'Male', '14-06-2000', '28-10-2020', 9548627154, 'Aadipur'),
(11, 'Mitesh', 'Thacker', 'Male', '18-06-1992', '28-10-2020', 6958463245, 'Gandhidham'),
(12, 'Something', 'Else', 'Female', '21-07-1989', '28-10-2020', 6565983241, 'Do Nothing'),
(13, 'Meena', 'Ramwani', 'Female', '30-09-1995', '28-10-2020', 9427858601, 'Gandhidham'),
(14, 'Amul', 'Bhanushali', 'Male', '05-04-2003', '01-11-2020', 7778982723, 'Aadipur'),
(15, 'Ajit', 'Ramwani', 'Male', '12-08-1974', '28-11-2020', 9825227014, 'Rudraksh Stationary'),
(16, 'Tushar', 'Karamchandani', 'Male', '05-07-2002', '28-11-2020', 9865378929, 'Sector - 7'),
(17, 'Test', 'Test', 'Male', '06-07-2023', '06-07-2023', 7863094326, 'Ahmedabad'),
(18, 'Test', 'Test', 'Male', '06-06-2003', '14-09-2023', 9978676386, 'Ahmedabad');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `Id` int(11) NOT NULL,
  `First_Name` varchar(255) NOT NULL,
  `Last_Name` varchar(255) NOT NULL,
  `Gender` varchar(255) NOT NULL,
  `Date_of_Birth` varchar(255) NOT NULL,
  `Mobile_Number` bigint(10) NOT NULL,
  `Ability` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`Id`, `First_Name`, `Last_Name`, `Gender`, `Date_of_Birth`, `Mobile_Number`, `Ability`, `Address`) VALUES
(1, 'Sneh', 'Todarmal', 'Male', '2000-03-02', 7979696969, 'Beard, Hair', '......... '),
(2, 'Madhav', 'Gyani', 'Male', '06-07-2001', 7979797979, 'Hair,Massage', '......... '),
(3, 'Darshan', 'Solanki', 'Male', '25-05-2003', 8735642998, 'Hair,Facial', '.................. '),
(4, 'Mahendra', 'Solanki', 'Male', '1999-01-07', 8635646598, 'Massage', 'ljsngisnan'),
(5, 'Jayessh', 'Maheswari', 'Male', '18-07-1996', 6932645684, 'Hair,Facial,Massage', 'Gandhidham '),
(6, 'Anil', 'Rawat', 'Male', '21-10-1996', 6481654645, 'Beard,Massage', 'Madhya Pradesh '),
(7, 'Ramkumar', 'Shrivastav', 'Male', '18-09-1979', 6394596321, 'Beard', 'Madhya Pradesh ');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Question` varchar(255) NOT NULL,
  `Answer` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`Username`, `Password`, `Question`, `Answer`) VALUES
('Admin', 'Admin', 'What is Your Pet Name ? ', 'Deffy'),
('Amul', 'Amul', 'What is Your Nickname?', 'Bhanushali'),
('Harsh', 'Ramwani', 'In what city or town did your mother and father meet?', 'Gandhidham');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `Id` int(11) NOT NULL,
  `Product_Name` varchar(255) NOT NULL,
  `Product_Category` varchar(255) NOT NULL,
  `Rate` int(11) NOT NULL,
  `Description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`Id`, `Product_Name`, `Product_Category`, `Rate`, `Description`) VALUES
(1, 'Beardo hair Oil', 'Hair Cut', 200, ''),
(2, 'Himaliya Face wash', 'Face Wash', 150, ''),
(3, 'Gel', 'Hair Cut', 200, ''),
(4, 'Dove', 'Shampoo', 250, 'Hi'),
(5, 'sansilk', 'Shampoo', 100, ''),
(6, 'Beardo Hair Spray', 'Hair Spray', 120, '200 ML'),
(7, 'Jai Sia Ram', 'Beardo Jai Sia ram', 149, 'Jai Sia Ram'),
(8, 'Himaliya Hair Spray', 'Hair Spray', 250, 'Null'),
(9, 'Hair Wax', 'Hair Cut', 200, 'Use for Hair Styling');

-- --------------------------------------------------------

--
-- Table structure for table `product_category`
--

CREATE TABLE `product_category` (
  `Id` int(11) NOT NULL,
  `Category_Name` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product_category`
--

INSERT INTO `product_category` (`Id`, `Category_Name`, `Description`) VALUES
(1, 'Face Wash', 'Face Wash Baba'),
(2, 'Hair Cut', 'Hair Cutting Lol'),
(3, 'Shampoo', 'xyz'),
(4, 'Hair Spray', 'Use to Make Hair Style Long Last.'),
(5, 'Beardo Jai Sia ram', 'Kucho Nahi');

-- --------------------------------------------------------

--
-- Table structure for table `product_sales_details`
--

CREATE TABLE `product_sales_details` (
  `Bill_No` int(11) NOT NULL,
  `Bill_Date` varchar(255) NOT NULL,
  `Product_Category` varchar(255) NOT NULL,
  `Product_Name` varchar(255) NOT NULL,
  `Product_Quantity` int(11) NOT NULL,
  `Product_Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product_sales_details`
--

INSERT INTO `product_sales_details` (`Bill_No`, `Bill_Date`, `Product_Category`, `Product_Name`, `Product_Quantity`, `Product_Price`) VALUES
(1, '28-11-2020', 'Face Wash', 'Himaliya Face wash', 2, 150),
(2, '04-07-2023', 'Hair Cut', 'Beardo hair Oil', 10, 200),
(3, '06-07-2023', 'Beardo Jai Sia ram', 'Jai Sia Ram', 5, 149),
(4, '08-07-2023', 'Face Wash', 'Himaliya Face wash', 2, 150),
(5, '21-08-2023', 'Face Wash', 'Himaliya Face wash', 3, 150),
(6, '14-09-2023', 'Beardo Jai Sia ram', 'Jai Sia Ram', 1, 149);

-- --------------------------------------------------------

--
-- Table structure for table `product_sales_master`
--

CREATE TABLE `product_sales_master` (
  `Bill_No` int(11) NOT NULL,
  `Bill_Date` varchar(255) NOT NULL,
  `Mobile_Number` bigint(10) NOT NULL,
  `Customer_Name` varchar(255) NOT NULL,
  `Customer_Address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product_sales_master`
--

INSERT INTO `product_sales_master` (`Bill_No`, `Bill_Date`, `Mobile_Number`, `Customer_Name`, `Customer_Address`) VALUES
(1, '28-11-2020', 7778982723, 'Amul', 'Aadipur'),
(2, '04-07-2023', 9978676386, 'Harsh', 'Gandhidham'),
(3, '06-07-2023', 9978676386, 'Harsh', 'Gandhidham'),
(4, '08-07-2023', 9978676386, 'Harsh', 'Gandhidham'),
(5, '21-08-2023', 9825227014, 'Ajit', 'Rudraksh Stationary'),
(6, '14-09-2023', 7778982723, 'Amul', 'Aadipur');

-- --------------------------------------------------------

--
-- Table structure for table `product_stock`
--

CREATE TABLE `product_stock` (
  `Stock_Id` int(11) NOT NULL,
  `date` varchar(255) NOT NULL,
  `Product_Category` varchar(255) NOT NULL,
  `Product_Name` varchar(255) NOT NULL,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product_stock`
--

INSERT INTO `product_stock` (`Stock_Id`, `date`, `Product_Category`, `Product_Name`, `Quantity`) VALUES
(0, '10-30-2020', 'Hair Spray', 'Beardo Hair Spray', 100),
(1, '07-15-2020', 'Face Wash', 'Himaliya Face wash', 93),
(2, '07-15-2020', 'Shampoo', 'sansilk', 100),
(3, '07-15-2020', 'Shampoo', 'Dove', 0),
(4, '07-15-2020', 'Hair Cut', 'Beardo hair Oil', 90),
(5, '07-15-2020', 'Hair Cut', 'Gel', 100),
(6, '11-28-2020', 'Beardo Jai Sia ram', 'Jai Sia Ram', 94);

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `Id` int(11) NOT NULL,
  `Service_Name` varchar(255) NOT NULL,
  `Description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`Id`, `Service_Name`, `Description`) VALUES
(1, 'Haircut', NULL),
(2, 'Beard Cut', NULL),
(3, 'Makeup or Facial', NULL),
(4, 'Massage', NULL),
(5, 'Tatoo', 'Price According to Tatoo Size'),
(6, 'No Name', 'Jai HInd');

-- --------------------------------------------------------

--
-- Table structure for table `service_sales`
--

CREATE TABLE `service_sales` (
  `Bill_No` int(11) NOT NULL,
  `Service_Name` varchar(255) NOT NULL,
  `Sub_Service_Name` varchar(255) NOT NULL,
  `Employee_Name` varchar(255) NOT NULL,
  `No_of_Person` int(11) NOT NULL,
  `Rate` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `service_sales`
--

INSERT INTO `service_sales` (`Bill_No`, `Service_Name`, `Sub_Service_Name`, `Employee_Name`, `No_of_Person`, `Rate`) VALUES
(1, 'Beard Cut (Men) ', 'Beard Cut', 'Maddy', 2, 400),
(2, 'Haircut (Men) ', 'Style Haircut', 'Maddy', 2, 600),
(3, 'Beard Cut (Men) ', 'Beard Cut', 'Harsh', 2, 400);

-- --------------------------------------------------------

--
-- Table structure for table `service_sales_details`
--

CREATE TABLE `service_sales_details` (
  `Bill_No` int(11) NOT NULL,
  `Bill_Date` varchar(255) NOT NULL,
  `Service_Name` varchar(255) NOT NULL,
  `Sub_Service_Name` varchar(255) NOT NULL,
  `Employee_Name` varchar(255) NOT NULL,
  `No_of_Person` int(11) NOT NULL,
  `Rate` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `service_sales_details`
--

INSERT INTO `service_sales_details` (`Bill_No`, `Bill_Date`, `Service_Name`, `Sub_Service_Name`, `Employee_Name`, `No_of_Person`, `Rate`) VALUES
(1, '07-15-2020', 'Beard Cut', 'Beard Cut', 'Darshan', 2, 200),
(1, '07-15-2020', 'Haircut', 'Style Haircut', 'Darshan', 2, 300),
(2, '10-27-2020', 'Massage', 'Head Massage', 'Revant', 1, 250),
(2, '10-27-2020', 'Beard Cut', 'Beard Cut', 'Revant', 1, 200),
(4, '07-15-2020', 'Haircut', 'Style Haircut', 'Madhav', 2, 300),
(5, '10-27-2020', 'Haircut', 'Style Haircut', 'Jayesh', 3, 300),
(6, '15-07-2020', 'Massage', 'Head Massage', 'Jayesh', 2, 250),
(7, '15-07-2020', 'Haircut', 'Style Haircut', 'Mahendra', 2, 300),
(8, '15-07-2020', 'Beard Cut', 'Beard Cut', 'Mahendra', 2, 200),
(2, '10-27-2020', 'Haircut', 'Style Haircut', 'Revant', 1, 300),
(3, '10-27-2020', 'Makeup or Facial', 'Make Up', 'Sneh', 2, 300);

-- --------------------------------------------------------

--
-- Table structure for table `service_sales_master`
--

CREATE TABLE `service_sales_master` (
  `Bill_No` int(11) NOT NULL,
  `Bill_Date` varchar(255) NOT NULL,
  `Mobile_Number` bigint(10) NOT NULL,
  `Customer_Name` varchar(255) NOT NULL,
  `Customer_Address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `service_sales_master`
--

INSERT INTO `service_sales_master` (`Bill_No`, `Bill_Date`, `Mobile_Number`, `Customer_Name`, `Customer_Address`) VALUES
(1, '07-15-2020', 8980842701, 'Yagnik', 'Gandhidham'),
(2, '10-27-2020', 9978676866, 'Jigar', 'Gandhidham'),
(3, '10-27-2020', 1212343456, 'Lokesh', 'Jai Mataji'),
(4, '07-15-2020', 1212343456, 'Lokesh', 'Jai Mataji'),
(5, '10-27-2020', 7016697973, 'Dhruv', 'Gandhidham'),
(6, '15-07-2020', 9999999999, 'Honey', 'Adipur'),
(7, '15-07-2020', 7778982723, 'Amul', 'Aadipur'),
(8, '15-07-2020', 9978676386, 'Harsh', 'Gandhidham');

-- --------------------------------------------------------

--
-- Table structure for table `sub_services`
--

CREATE TABLE `sub_services` (
  `Id` int(11) NOT NULL,
  `Sub_Service_Name` varchar(255) NOT NULL,
  `Service_Name` varchar(255) NOT NULL,
  `Price` bigint(10) NOT NULL,
  `Description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sub_services`
--

INSERT INTO `sub_services` (`Id`, `Sub_Service_Name`, `Service_Name`, `Price`, `Description`) VALUES
(1, 'Style Haircut', 'Haircut', 300, 'Require 20 Year Age'),
(2, 'Beard Cut', 'Beard Cut ', 200, ''),
(3, 'Child', 'Haircut', 100, 'Child Hair Cut'),
(4, 'Make Up', 'Makeup or Facial  ', 150, ''),
(5, 'Head Massage', 'Massage', 250, NULL),
(6, 'Nothing', 'No Name ', 250, 'Nothing Stupid'),
(7, 'Haircolor', 'Haircut ', 250, 'abc');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `product_category`
--
ALTER TABLE `product_category`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `product_sales_master`
--
ALTER TABLE `product_sales_master`
  ADD PRIMARY KEY (`Bill_No`);

--
-- Indexes for table `product_stock`
--
ALTER TABLE `product_stock`
  ADD PRIMARY KEY (`Stock_Id`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `service_sales_master`
--
ALTER TABLE `service_sales_master`
  ADD PRIMARY KEY (`Bill_No`);

--
-- Indexes for table `sub_services`
--
ALTER TABLE `sub_services`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
