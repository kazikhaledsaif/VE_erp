CREATE DATABASE  IF NOT EXISTS `ekhteeardb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `ekhteeardb`;
-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: localhost    Database: ekhteeardb
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `agent`
--

DROP TABLE IF EXISTS `agent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `agent` (
  `AgentId` int(11) NOT NULL AUTO_INCREMENT,
  `AgentName` varchar(45) DEFAULT NULL,
  `CompanyName` varchar(45) DEFAULT NULL,
  `PhoneNumber` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`AgentId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agent`
--

LOCK TABLES `agent` WRITE;
/*!40000 ALTER TABLE `agent` DISABLE KEYS */;
INSERT INTO `agent` VALUES (1,'Saif','NAN','000929292929'),(2,'something','nai','nai'),(3,'saif','saaa','02020200222'),(4,'New1','mak','202020022');
/*!40000 ALTER TABLE `agent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `company`
--

DROP TABLE IF EXISTS `company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `company` (
  `CompanyId` int(11) NOT NULL,
  `CompanyType` varchar(45) DEFAULT NULL,
  `CompanyName` varchar(45) DEFAULT NULL,
  `CompanyAddress` varchar(45) DEFAULT NULL,
  `CompanyPhone` varchar(45) DEFAULT NULL,
  `CompanyWebsite` varchar(45) DEFAULT NULL,
  `CompanyEmail` varchar(45) DEFAULT NULL,
  `CompanyLogo` longblob,
  PRIMARY KEY (`CompanyId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `company`
--

LOCK TABLES `company` WRITE;
/*!40000 ALTER TABLE `company` DISABLE KEYS */;
/*!40000 ALTER TABLE `company` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `creditor`
--

DROP TABLE IF EXISTS `creditor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `creditor` (
  `CreditorId` int(11) NOT NULL AUTO_INCREMENT,
  `CreditorDue` decimal(18,2) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `AgentId` int(11) DEFAULT NULL,
  PRIMARY KEY (`CreditorId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `creditor`
--

LOCK TABLES `creditor` WRITE;
/*!40000 ALTER TABLE `creditor` DISABLE KEYS */;
INSERT INTO `creditor` VALUES (2,43.00,'2018-03-26',2),(3,250.00,'2018-03-26',2);
/*!40000 ALTER TABLE `creditor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `customer` (
  `CustomerId` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(45) DEFAULT NULL,
  `CompanyName` varchar(45) DEFAULT NULL,
  `PhoneNumber` varchar(45) DEFAULT NULL,
  `CustomerType` varchar(45) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  PRIMARY KEY (`CustomerId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'saif 1','asdasa','dasdas','Agent','2018-03-23');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `debtor`
--

DROP TABLE IF EXISTS `debtor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `debtor` (
  `DebtorId` int(11) NOT NULL AUTO_INCREMENT,
  `DebtorDue` decimal(18,2) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `CustomerId` int(11) DEFAULT NULL,
  PRIMARY KEY (`DebtorId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `debtor`
--

LOCK TABLES `debtor` WRITE;
/*!40000 ALTER TABLE `debtor` DISABLE KEYS */;
/*!40000 ALTER TABLE `debtor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `extracost`
--

DROP TABLE IF EXISTS `extracost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `extracost` (
  `CostId` int(11) NOT NULL AUTO_INCREMENT,
  `CostType` varchar(45) DEFAULT NULL,
  `Amount` decimal(18,2) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  PRIMARY KEY (`CostId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `extracost`
--

LOCK TABLES `extracost` WRITE;
/*!40000 ALTER TABLE `extracost` DISABLE KEYS */;
INSERT INTO `extracost` VALUES (1,'work',1300.00,'2012-12-18');
/*!40000 ALTER TABLE `extracost` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `inventory` (
  `InventoryId` int(11) NOT NULL AUTO_INCREMENT,
  `AgentId` int(11) DEFAULT NULL,
  `TotalBill` decimal(18,2) DEFAULT NULL,
  `CashPaid` decimal(18,2) DEFAULT NULL,
  `Due` decimal(18,2) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  PRIMARY KEY (`InventoryId`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT INTO `inventory` VALUES (1,1,10000.00,10000.00,0.00,'0001-01-12'),(2,1,4.00,4.00,0.00,'2018-03-23'),(3,1,244.00,244.00,0.00,'2018-03-23'),(4,2,2.00,2.00,0.00,'2018-03-23'),(5,2,46.00,3.00,43.00,'2018-03-26'),(6,2,253.00,3.00,250.00,'2018-03-26');
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventorydetails`
--

DROP TABLE IF EXISTS `inventorydetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `inventorydetails` (
  `InventoryDetailsId` int(11) NOT NULL AUTO_INCREMENT,
  `InventoryId` int(11) DEFAULT NULL,
  `ProductId` int(11) DEFAULT NULL,
  `InventoryQuantity` decimal(18,2) DEFAULT NULL,
  `Cost` decimal(18,2) DEFAULT NULL,
  PRIMARY KEY (`InventoryDetailsId`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventorydetails`
--

LOCK TABLES `inventorydetails` WRITE;
/*!40000 ALTER TABLE `inventorydetails` DISABLE KEYS */;
INSERT INTO `inventorydetails` VALUES (1,1,4,0.00,22.00),(3,2,4,-12.00,20.00),(4,2,4,-2.00,2.00),(5,2,5,12.00,132.00),(6,2,5,1.00,11.00),(7,2,4,2.00,4.00),(8,3,4,1.00,2.00),(9,3,5,0.00,242.00),(10,4,4,1.00,2.00),(36,5,4,112112.00,224224.00),(37,5,4,12.00,24.00),(38,5,4,23.00,46.00),(39,6,5,23.00,253.00);
/*!40000 ALTER TABLE `inventorydetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ledger`
--

DROP TABLE IF EXISTS `ledger`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ledger` (
  `LedgerId` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerId` int(11) DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  `Debit` decimal(18,0) DEFAULT NULL,
  `Credit` decimal(18,0) DEFAULT NULL,
  `Balance` decimal(18,0) DEFAULT NULL,
  PRIMARY KEY (`LedgerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ledger`
--

LOCK TABLES `ledger` WRITE;
/*!40000 ALTER TABLE `ledger` DISABLE KEYS */;
/*!40000 ALTER TABLE `ledger` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `product` (
  `ProductId` int(11) NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(45) DEFAULT NULL,
  `ProductType` varchar(45) DEFAULT NULL,
  `BuyingRate` decimal(18,2) DEFAULT NULL,
  `SellingRate` decimal(18,2) DEFAULT NULL,
  `Quantity` decimal(18,2) DEFAULT NULL,
  `SKU` varchar(45) DEFAULT NULL,
  `Unit` varchar(45) DEFAULT NULL,
  `MinimumQuantity` decimal(18,2) DEFAULT NULL,
  `Vat` decimal(18,2) DEFAULT NULL,
  `SaleWithVat` decimal(18,2) DEFAULT NULL,
  `ProductImage` mediumblob,
  PRIMARY KEY (`ProductId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (4,'dfs','dfdfgd',2.00,2.00,113651.00,'1000004','Boxes',22.00,2.00,2.04,NULL),(5,'www','ww',11.00,11.00,1179.00,'1000005','Pcs',33.00,11.00,12.21,NULL);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `refund`
--

DROP TABLE IF EXISTS `refund`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `refund` (
  `RefundId` int(11) NOT NULL AUTO_INCREMENT,
  `WholesaleId` int(11) DEFAULT NULL,
  `ProductId` int(11) DEFAULT NULL,
  `Quantity` decimal(18,2) DEFAULT NULL,
  `CustomerId` int(11) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  PRIMARY KEY (`RefundId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `refund`
--

LOCK TABLES `refund` WRITE;
/*!40000 ALTER TABLE `refund` DISABLE KEYS */;
/*!40000 ALTER TABLE `refund` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `retail`
--

DROP TABLE IF EXISTS `retail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `retail` (
  `RetailId` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerId` int(11) DEFAULT NULL,
  `Discount` decimal(18,2) DEFAULT NULL,
  `TotalBill` decimal(18,2) DEFAULT NULL,
  `Paid` decimal(18,2) DEFAULT NULL,
  `Due` decimal(18,2) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  PRIMARY KEY (`RetailId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `retail`
--

LOCK TABLES `retail` WRITE;
/*!40000 ALTER TABLE `retail` DISABLE KEYS */;
/*!40000 ALTER TABLE `retail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `retaildetails`
--

DROP TABLE IF EXISTS `retaildetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `retaildetails` (
  `RetailDetailsId` int(11) NOT NULL AUTO_INCREMENT,
  `RetailId` int(11) DEFAULT NULL,
  `ProductId` int(11) DEFAULT NULL,
  `Quantity` decimal(18,2) DEFAULT NULL,
  `Price` decimal(18,2) DEFAULT NULL,
  PRIMARY KEY (`RetailDetailsId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `retaildetails`
--

LOCK TABLES `retaildetails` WRITE;
/*!40000 ALTER TABLE `retaildetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `retaildetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `user` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `UserType` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'admin','admin',NULL,'admin');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wholesale`
--

DROP TABLE IF EXISTS `wholesale`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `wholesale` (
  `WholesaleId` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerId` int(11) DEFAULT NULL,
  `Discount` decimal(18,2) DEFAULT NULL,
  `TotalBill` decimal(18,2) DEFAULT NULL,
  `Paid` decimal(18,2) DEFAULT NULL,
  `Due` decimal(18,2) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  PRIMARY KEY (`WholesaleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wholesale`
--

LOCK TABLES `wholesale` WRITE;
/*!40000 ALTER TABLE `wholesale` DISABLE KEYS */;
/*!40000 ALTER TABLE `wholesale` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wholesaledetails`
--

DROP TABLE IF EXISTS `wholesaledetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `wholesaledetails` (
  `WholesaleId` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerId` int(11) DEFAULT NULL,
  `Discount` decimal(18,2) DEFAULT NULL,
  `TotalBill` decimal(18,2) DEFAULT NULL,
  `Paid` decimal(18,2) DEFAULT NULL,
  `Due` decimal(18,2) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  PRIMARY KEY (`WholesaleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wholesaledetails`
--

LOCK TABLES `wholesaledetails` WRITE;
/*!40000 ALTER TABLE `wholesaledetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `wholesaledetails` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-02-24 19:48:26
