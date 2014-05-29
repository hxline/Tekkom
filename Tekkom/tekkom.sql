/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.1.72-community : Database - tekkom
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`tekkom` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `tekkom`;

/*Table structure for table `objek` */

DROP TABLE IF EXISTS `objek`;

CREATE TABLE `objek` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `objek` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

/*Data for the table `objek` */

insert  into `objek`(`id`,`objek`) values (1,'air'),(2,'kue'),(3,'roti'),(4,'mobil'),(5,'motor'),(6,'becak'),(7,'mi');

/*Table structure for table `pelengkap` */

DROP TABLE IF EXISTS `pelengkap`;

CREATE TABLE `pelengkap` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `pel` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

/*Data for the table `pelengkap` */

insert  into `pelengkap`(`id`,`pel`) values (1,'goreng'),(2,'matang'),(3,'rebus'),(4,'bakar'),(5,'baru'),(6,'rusak'),(7,'enak');

/*Table structure for table `predikat` */

DROP TABLE IF EXISTS `predikat`;

CREATE TABLE `predikat` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `predikat` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `predikat` */

insert  into `predikat`(`id`,`predikat`) values (1,'makan'),(2,'minum'),(3,'main'),(4,'belajar'),(5,'pergi'),(6,'naik');

/*Table structure for table `subjek` */

DROP TABLE IF EXISTS `subjek`;

CREATE TABLE `subjek` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `subjek` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

/*Data for the table `subjek` */

insert  into `subjek`(`id`,`subjek`) values (1,'saya'),(2,'agan'),(3,'kamu'),(4,'aku'),(5,'anda'),(6,'kalian'),(7,'mereka');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
