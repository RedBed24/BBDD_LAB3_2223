-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: setlist
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Dumping data for table `albumes`
--

LOCK TABLES `albumes` WRITE;
/*!40000 ALTER TABLE `albumes` DISABLE KEYS */;
INSERT INTO `albumes` VALUES (1,'Los Ángeles',2017,2),(2,'Con derecho a…',2017,3),(3,'Vakuum',2019,4),(4,'Torches',2011,5),(5,'Conchita',2015,17),(6,'Caballo Viejo',1980,16),(7,'Mis Canciones',1989,16),(8,'21',2011,13),(9,'25',2015,13),(10,'19',2008,13),(11,'Imagine',1971,14),(12,'John Lennon/Plastic Ono Band',1970,14),(13,'Amália Rodrigues e os Poetas',1960,12),(14,'Amália Rodrigues in Concert',1957,12),(15,'Cuando el río suena...',2017,3),(16,'El árbol y el bosque',2019,3);
/*!40000 ALTER TABLE `albumes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `artistas`
--

LOCK TABLES `artistas` WRITE;
/*!40000 ALTER TABLE `artistas` DISABLE KEYS */;
INSERT INTO `artistas` VALUES (2,'Rosalia','ESP'),(3,'Rozalén','ESP'),(4,'LEA','ALE'),(5,'Mark Foster','ALE'),(7,'Roberto Sánchez - Sandro','ARG'),(8,'Ivete Sangalo','BRA'),(9,'Ryan Gosling','CAN'),(10,'Georgia  O’Keeffe','EST'),(11,'Victor Vasnetsov','RUS'),(12,'Amalia Rodrigues','POR'),(13,'Adele','ING'),(14,'John Lennon','ING'),(15,'Arturo Michelena','VEN'),(16,'Simón Díaz','VEN'),(17,'Thomas Neuwirth','AUS');
/*!40000 ALTER TABLE `artistas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `canciones`
--

LOCK TABLES `canciones` WRITE;
/*!40000 ALTER TABLE `canciones` DISABLE KEYS */;
INSERT INTO `canciones` VALUES (1,'Catalina ',2,1,1),(2,'De Plata',3,1,2),(3,'Comiéndote a besos',4,2,2),(4,'80 veces',3,2,3),(5,'Dach',2,3,1),(6,'Kennst du das',4,3,3),(7,'Pumped Up Kicks',4,4,1),(8,'Helena Beat',4,4,3),(9,'Heroes',2,5,2),(10,'You Are Unstoppable',3,5,5),(11,'Rolling in the Deep',4,8,1),(12,'Someone Like You',5,8,2),(13,'Chasing Pavements',3,10,2),(14,'Make You Feel My Love',3,10,9),(15,'Imagine',3,11,1),(16,'Jealous Guy',4,11,3);
/*!40000 ALTER TABLE `canciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `conciertos`
--

LOCK TABLES `conciertos` WRITE;
/*!40000 ALTER TABLE `conciertos` DISABLE KEYS */;
INSERT INTO `conciertos` VALUES (1,2,1,'2023-05-01'),(17,14,5,'2023-05-01'),(18,2,13,'2023-05-01'),(19,5,16,'2023-05-01'),(20,13,16,'2023-05-01'),(21,13,11,'2023-05-01'),(22,13,9,'2023-05-01'),(23,13,17,'2023-05-01'),(24,14,6,'2023-05-01');
/*!40000 ALTER TABLE `conciertos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `paises`
--

LOCK TABLES `paises` WRITE;
/*!40000 ALTER TABLE `paises` DISABLE KEYS */;
INSERT INTO `paises` VALUES ('ALE','Alemania'),('ARG','Argentina '),('AUS','Austria'),('BÉL','Bélgica '),('BRA','Brasil'),('CAN','Canadá'),('CHI','Chile'),('COL','Colombia'),('ESP','España'),('EST','Estados Unidos'),('FRA','Francia'),('ING','Inglaterra'),('MEX','Mexico'),('POR','Portugal'),('RUS','Rusia'),('VEN','Venezuela');
/*!40000 ALTER TABLE `paises` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `setlists`
--

LOCK TABLES `setlists` WRITE;
/*!40000 ALTER TABLE `setlists` DISABLE KEYS */;
INSERT INTO `setlists` VALUES (1,1,1),(1,2,0),(17,15,0),(18,2,0),(19,7,0),(19,8,1),(20,13,0),(20,14,1),(21,13,0),(21,14,1),(22,13,0),(22,14,1),(23,13,0),(23,14,1),(24,15,0),(24,16,1);
/*!40000 ALTER TABLE `setlists` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `sitio`
--

LOCK TABLES `sitio` WRITE;
/*!40000 ALTER TABLE `sitio` DISABLE KEYS */;
INSERT INTO `sitio` VALUES (1,'Playa de Cadiz','ESP','festival'),(2,'Boston Arena Matthews Arena ','EST','pabellón'),(3,'Salas O` Brien','EST','sala'),(4,'Estadio Santiago Bernabéu','ESP','estadio'),(5,'Camp Nou','ESP','estadio'),(6,'O2 Arena','ING','sala'),(7,'Manchester Arena','ING','sala'),(8,'Altice Arena','POR','pabellón'),(9,'Pavilhão Rosa Mota','POR','pabellón'),(11,'Vive Latino','MEX','festival'),(12,'Stade de France','FRA','estadio'),(13,'Parc des Princes','FRA','estadio'),(14,'AccorHotels Arena','FRA','sala'),(15,'Madison Square Garden','EST','pabellón'),(16,'Mercedes-Benz Arena','ALE','pabellón'),(17,'Lanxess Arena','ALE','pabellón');
/*!40000 ALTER TABLE `sitio` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-02  8:31:32
