-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.11-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for preorder
CREATE DATABASE IF NOT EXISTS `preorder` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `preorder`;

-- Dumping structure for table preorder.admin
CREATE TABLE IF NOT EXISTS `admin` (
  `kd_admin` char(50) NOT NULL DEFAULT '',
  `pwd` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `hp` varchar(50) NOT NULL,
  `jabatan` varchar(50) NOT NULL,
  PRIMARY KEY (`kd_admin`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table preorder.admin: ~0 rows (approximately)
DELETE FROM `admin`;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` (`kd_admin`, `pwd`, `username`, `nama`, `email`, `hp`, `jabatan`) VALUES
	('AD001', 'root', 'root', '', '', '', ''),
	('AD002', 'ragil', 'ragil', 'Ragil', 'asd', 'sd', 'ss');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;

-- Dumping structure for table preorder.barang
CREATE TABLE IF NOT EXISTS `barang` (
  `kd_barang` char(10) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `kuantitas` int(11) NOT NULL DEFAULT 0,
  `harga` int(20) NOT NULL DEFAULT 0,
  `warna` char(50) NOT NULL,
  `ukuran` char(50) NOT NULL,
  `gambar` blob DEFAULT NULL,
  PRIMARY KEY (`kd_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table preorder.barang: ~7 rows (approximately)
DELETE FROM `barang`;
/*!40000 ALTER TABLE `barang` DISABLE KEYS */;
INSERT INTO `barang` (`kd_barang`, `nama`, `kuantitas`, `harga`, `warna`, `ukuran`, `gambar`) VALUES
	('1', 'ak', 1, 1, '1', '1', NULL),
	('32432', '23423', 234, 23423, '234', '23432', NULL),
	('3434', '121', 123, 123, '123', '213', NULL),
	('34r', '34', 34, 2, '34', '34', NULL),
	('645', '456', 56, 4564, '546', '56', NULL),
	('AD004', 'Talenan ku', 100, 699, 'Kayuu', 'MDMu', NULL),
	('ADP001', 'Sendok', 12, 5000, 'Silver', 'SML', NULL);
/*!40000 ALTER TABLE `barang` ENABLE KEYS */;

-- Dumping structure for table preorder.detail_pesanan
CREATE TABLE IF NOT EXISTS `detail_pesanan` (
  `kd_detail` char(10) NOT NULL,
  `kd_barang` char(10) DEFAULT NULL,
  `Qty` int(11) NOT NULL,
  `Subtotal` int(11) DEFAULT NULL,
  `kd_pesanan` char(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`kd_detail`),
  KEY `FK_detail_pesanan_barang` (`kd_barang`),
  KEY `FK_detail_pesanan_pesanan` (`kd_pesanan`),
  CONSTRAINT `FK_detail_pesanan_barang` FOREIGN KEY (`kd_barang`) REFERENCES `barang` (`kd_barang`),
  CONSTRAINT `FK_detail_pesanan_pesanan` FOREIGN KEY (`kd_pesanan`) REFERENCES `pesanan` (`kd_pesanan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table preorder.detail_pesanan: ~0 rows (approximately)
DELETE FROM `detail_pesanan`;
/*!40000 ALTER TABLE `detail_pesanan` DISABLE KEYS */;
INSERT INTO `detail_pesanan` (`kd_detail`, `kd_barang`, `Qty`, `Subtotal`, `kd_pesanan`) VALUES
	('PN001X1', 'ad004', 2, 1398, 'PN001'),
	('PN002X1', 'ad004', 1, 699, 'PN002'),
	('PN003X1', 'ad004', 1, 699, 'PN003');
/*!40000 ALTER TABLE `detail_pesanan` ENABLE KEYS */;

-- Dumping structure for table preorder.pembeli
CREATE TABLE IF NOT EXISTS `pembeli` (
  `kd_pembeli` char(10) NOT NULL,
  `nama_pembeli` varchar(50) DEFAULT NULL,
  `telp_pembeli` char(50) DEFAULT NULL,
  `alamat_pembeli` varchar(50) DEFAULT '',
  `kecamatan` varchar(50) DEFAULT '',
  `kabupaten` varchar(50) DEFAULT '',
  `provinsi` varchar(50) DEFAULT '',
  `kode_pos` char(50) DEFAULT NULL,
  PRIMARY KEY (`kd_pembeli`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table preorder.pembeli: ~6 rows (approximately)
DELETE FROM `pembeli`;
/*!40000 ALTER TABLE `pembeli` DISABLE KEYS */;
INSERT INTO `pembeli` (`kd_pembeli`, `nama_pembeli`, `telp_pembeli`, `alamat_pembeli`, `kecamatan`, `kabupaten`, `provinsi`, `kode_pos`) VALUES
	('', '', '', '', '', '', '', ''),
	('34', '3', '', '', '', '', '', ''),
	('dia', 'dia', '56', '56', '56', '56', '56', '56'),
	('fg', 'fg', '', '', '', '', '', '');
/*!40000 ALTER TABLE `pembeli` ENABLE KEYS */;

-- Dumping structure for table preorder.pembelian
CREATE TABLE IF NOT EXISTS `pembelian` (
  `kd_pembelian` char(10) NOT NULL,
  `tgl_pembelian` datetime NOT NULL,
  `nama_barang` varchar(100) NOT NULL,
  `jumlah_barang` int(11) NOT NULL,
  `harga_beli` int(11) NOT NULL,
  `kd_produsen` char(10) NOT NULL,
  `kd_barang` char(10) NOT NULL,
  `kd_pesanan` char(10) NOT NULL,
  `kd_admin` char(10) NOT NULL,
  PRIMARY KEY (`kd_pembelian`),
  KEY `FK_pembelian_produsen` (`kd_produsen`),
  KEY `FK_pembelian_barang` (`kd_barang`),
  KEY `FK_pembelian_admin` (`kd_admin`),
  CONSTRAINT `FK_pembelian_admin` FOREIGN KEY (`kd_admin`) REFERENCES `admin` (`kd_admin`),
  CONSTRAINT `FK_pembelian_barang` FOREIGN KEY (`kd_barang`) REFERENCES `barang` (`kd_barang`),
  CONSTRAINT `FK_pembelian_produsen` FOREIGN KEY (`kd_produsen`) REFERENCES `produsen` (`kd_produsen`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table preorder.pembelian: ~0 rows (approximately)
DELETE FROM `pembelian`;
/*!40000 ALTER TABLE `pembelian` DISABLE KEYS */;
/*!40000 ALTER TABLE `pembelian` ENABLE KEYS */;

-- Dumping structure for table preorder.pesanan
CREATE TABLE IF NOT EXISTS `pesanan` (
  `kd_pesanan` char(50) NOT NULL,
  `total` int(11) NOT NULL DEFAULT 0,
  `tgl_pesanan` datetime DEFAULT NULL,
  `cara_bayar` char(50) DEFAULT '',
  `jatuh_tempo` datetime DEFAULT NULL,
  `catatan` varchar(50) DEFAULT NULL,
  `uang_muka` int(11) NOT NULL DEFAULT 0,
  `sisa_bayar` int(11) NOT NULL DEFAULT 0,
  `kd_pembeli` char(50) DEFAULT '',
  `sts_pesanan` char(50) DEFAULT NULL,
  `kd_admin` char(10) NOT NULL,
  PRIMARY KEY (`kd_pesanan`),
  KEY `FK_pesanan_admin` (`kd_admin`),
  CONSTRAINT `FK_pesanan_admin` FOREIGN KEY (`kd_admin`) REFERENCES `admin` (`kd_admin`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table preorder.pesanan: ~1 rows (approximately)
DELETE FROM `pesanan`;
/*!40000 ALTER TABLE `pesanan` DISABLE KEYS */;
INSERT INTO `pesanan` (`kd_pesanan`, `total`, `tgl_pesanan`, `cara_bayar`, `jatuh_tempo`, `catatan`, `uang_muka`, `sisa_bayar`, `kd_pembeli`, `sts_pesanan`, `kd_admin`) VALUES
	('PN001', 1398, '2020-01-01 00:00:00', 'Tunai', '2020-01-01 00:00:00', NULL, 100, 1298, 'dia', 'Tunda', 'AD001'),
	('PN002', 699, '2020-01-01 00:00:00', 'Transfer', '2020-01-01 00:00:00', NULL, 99, 600, 'fg', 'Tunda', 'AD001'),
	('PN003', 699, '2020-01-01 00:00:00', 'Tunai', '2020-01-01 00:00:00', NULL, 6, 693, '34', 'Tunda', 'AD001');
/*!40000 ALTER TABLE `pesanan` ENABLE KEYS */;

-- Dumping structure for table preorder.produsen
CREATE TABLE IF NOT EXISTS `produsen` (
  `kd_produsen` char(50) NOT NULL,
  `nama_produsen` varchar(50) NOT NULL,
  `alamat_produsen` varchar(50) NOT NULL,
  `telp_produsen` varchar(50) NOT NULL,
  PRIMARY KEY (`kd_produsen`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table preorder.produsen: ~0 rows (approximately)
DELETE FROM `produsen`;
/*!40000 ALTER TABLE `produsen` DISABLE KEYS */;
/*!40000 ALTER TABLE `produsen` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
