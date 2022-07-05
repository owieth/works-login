CREATE DATABASE  IF NOT EXISTS `filmdb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `filmdb`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: filmdb
-- ------------------------------------------------------
-- Server version	5.7.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `film`
--

DROP TABLE IF EXISTS `film`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `film` (
  `FilmID` int(11) NOT NULL AUTO_INCREMENT,
  `Filmname` varchar(50) DEFAULT NULL,
  `Erscheinungsdatum` date DEFAULT NULL,
  `Laufzeit` time DEFAULT NULL,
  `Budget` decimal(10,0) DEFAULT NULL,
  `SpracheID` int(11) DEFAULT NULL,
  `GenreID` int(11) DEFAULT NULL,
  PRIMARY KEY (`FilmID`),
  KEY `FK_SpracheID` (`SpracheID`),
  KEY `FK_GenreID` (`GenreID`),
  CONSTRAINT `FK_GenreID` FOREIGN KEY (`GenreID`) REFERENCES `genre` (`GenreID`),
  CONSTRAINT `FK_SpracheID` FOREIGN KEY (`SpracheID`) REFERENCES `originalsprache` (`SpracheID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `film`
--

LOCK TABLES `film` WRITE;
/*!40000 ALTER TABLE `film` DISABLE KEYS */;
/*!40000 ALTER TABLE `film` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funktion`
--

DROP TABLE IF EXISTS `funktion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `funktion` (
  `FunktionID` int(11) NOT NULL AUTO_INCREMENT,
  `Bezeichnung` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`FunktionID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funktion`
--

LOCK TABLES `funktion` WRITE;
/*!40000 ALTER TABLE `funktion` DISABLE KEYS */;
INSERT INTO `funktion` VALUES (1,'Darsteller\r'),(2,'Director\r'),(3,'Sound\r'),(4,'Kamera\r'),(5,'Editing\r');
/*!40000 ALTER TABLE `funktion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genre`
--

DROP TABLE IF EXISTS `genre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genre` (
  `GenreID` int(11) NOT NULL AUTO_INCREMENT,
  `Bezeichnung` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`GenreID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genre`
--

LOCK TABLES `genre` WRITE;
/*!40000 ALTER TABLE `genre` DISABLE KEYS */;
INSERT INTO `genre` VALUES (1,'Krimi\r'),(2,'Action\r'),(3,'Fantasy\r'),(4,'Komoedie\r'),(5,'Science Fiction\r'),(6,'Drama\r'),(7,'Thriller\r');
/*!40000 ALTER TABLE `genre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `originalsprache`
--

DROP TABLE IF EXISTS `originalsprache`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `originalsprache` (
  `SpracheID` int(11) NOT NULL AUTO_INCREMENT,
  `Originalsprache` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`SpracheID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `originalsprache`
--

LOCK TABLES `originalsprache` WRITE;
/*!40000 ALTER TABLE `originalsprache` DISABLE KEYS */;
INSERT INTO `originalsprache` VALUES (1,'Deutsch\r'),(2,'Englisch\r'),(3,'Franzoesisch\r');
/*!40000 ALTER TABLE `originalsprache` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `person`
--

DROP TABLE IF EXISTS `person`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `person` (
  `PersonID` int(11) NOT NULL AUTO_INCREMENT,
  `Namen` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`PersonID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `person`
--

LOCK TABLES `person` WRITE;
/*!40000 ALTER TABLE `person` DISABLE KEYS */;
INSERT INTO `person` VALUES (1,'Will Smith\r'),(2,'David Ayer\r'),(3,'Karoline Herfurth\r'),(4,'Uma Thurman\r'),(5,'Quentin Tarantino\r'),(6,'Jean Reno\r'),(7,'Luc Besson\r'),(8,'Harrison Ford\r'),(9,'Ridley Scott\r'),(10,'Tim Robbins\r'),(11,'Roger Deakins\r');
/*!40000 ALTER TABLE `person` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personfunktion`
--

DROP TABLE IF EXISTS `personfunktion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `personfunktion` (
  `FilmID` int(11) DEFAULT NULL,
  `FunktionID` int(11) DEFAULT NULL,
  `PersonID` int(11) DEFAULT NULL,
  KEY `FK_FilmID` (`FilmID`),
  KEY `FK_FunktionID` (`FunktionID`),
  KEY `FK_PersonID` (`PersonID`),
  CONSTRAINT `FK_FilmID` FOREIGN KEY (`FilmID`) REFERENCES `film` (`FilmID`),
  CONSTRAINT `FK_FunktionID` FOREIGN KEY (`FunktionID`) REFERENCES `funktion` (`FunktionID`),
  CONSTRAINT `FK_PersonID` FOREIGN KEY (`PersonID`) REFERENCES `person` (`PersonID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personfunktion`
--

LOCK TABLES `personfunktion` WRITE;
/*!40000 ALTER TABLE `personfunktion` DISABLE KEYS */;
/*!40000 ALTER TABLE `personfunktion` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-04-12 14:38:42
