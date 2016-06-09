-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Inang: 127.0.0.1
-- Waktu pembuatan: 09 Jun 2016 pada 23.46
-- Versi Server: 5.5.34
-- Versi PHP: 5.4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Basis data: `pos_andy`
--
CREATE DATABASE IF NOT EXISTS `pos_andy` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `pos_andy`;

-- --------------------------------------------------------

--
-- Struktur dari tabel `ms_ekspedisi`
--

CREATE TABLE `ms_ekspedisi` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama_ekspedisi` varchar(200) NOT NULL,
  `created_dt` datetime NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `last_modified_dt` datetime DEFAULT NULL,
  `modified_by` varchar(100) DEFAULT NULL,
  `is_deleted` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `nama_ekspedisi` (`nama_ekspedisi`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ms_ekspedisi`
--

INSERT INTO `ms_ekspedisi` (`id`, `nama_ekspedisi`, `created_dt`, `created_by`, `last_modified_dt`, `modified_by`, `is_deleted`) VALUES
(1, 'JNE', '2016-06-04 00:00:00', 'andy', NULL, NULL, 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `ms_invoice`
--

CREATE TABLE `ms_invoice` (
  `invoice_id` int(11) NOT NULL AUTO_INCREMENT,
  `invoice_name` varchar(100) NOT NULL,
  `buyer_name` varchar(200) NOT NULL,
  `buyer_address` varchar(200) NOT NULL,
  `company_name` varchar(200) DEFAULT NULL,
  `buyer_contact_no` varchar(100) NOT NULL,
  `payment_method` varchar(100) NOT NULL,
  `purchase_total` int(11) NOT NULL,
  `invoice_dt` datetime NOT NULL,
  `created_by` varchar(100) NOT NULL,
  PRIMARY KEY (`invoice_id`),
  UNIQUE KEY `invoice_name` (`invoice_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ms_invoice`
--

INSERT INTO `ms_invoice` (`invoice_id`, `invoice_name`, `buyer_name`, `buyer_address`, `company_name`, `buyer_contact_no`, `payment_method`, `purchase_total`, `invoice_dt`, `created_by`) VALUES
(1, 'INV201606040001', '', '', NULL, '', '', 0, '2016-06-04 00:00:00', 'andy'),
(2, 'INV201606050001', 'a', 's', 'b', 'b', 'b', 1234, '2016-06-05 00:13:29', 'andy'),
(3, 'INV201606050002', 'Johny', 'Jl. Pancasila No 5', 'PT. Mitrausaha Group', '0812910231', 'JNE', 572000, '2016-06-05 00:30:41', 'andy'),
(4, 'INV201606050003', 'Johny', 'Jl. Pancasila No 5', 'PT. Mitrausaha Group', '0812910231', 'JNE', 3302000, '2016-06-05 00:37:12', 'andy'),
(5, 'INV201606050004', 'Johny', 'Jl. Pancasila No 5', 'PT. Mitrausaha Group', '0812910231', 'JNE', 3302000, '2016-06-05 00:37:49', 'andy'),
(6, 'INV201606050005', 'Johny', 'Jl. Pancasila No 5', 'PT. Mitrausaha Group', '0812910231', 'JNE', 3302000, '2016-06-05 00:38:14', 'andy'),
(7, 'INV201606050006', 'Johny', 'Jl. Pancasila No 5', 'PT. Mitrausaha Group', '0812910231', 'JNE', 1739000, '2016-06-05 00:39:40', 'andy'),
(8, 'INV201606050007', 'Johny', 'Jl. Pancasila No 5', 'PT. Mitrausaha Group', '0812910231', 'JNE', 572000, '2016-06-05 00:45:53', 'andy'),
(9, 'INV201606050008', 'Johny', 'Jl. Pancasila No 5', 'PT. Mitrausaha Group', '0812910231', 'JNE', 572000, '2016-06-05 00:47:10', 'andy'),
(10, 'INV201606050009', 'Johny', 'Jl. Pancasila No 5', 'PT. Mitrausaha Group', '0812910231', 'JNE', 572000, '2016-06-05 00:47:17', 'andy'),
(11, 'INV201606050010', 'Johny', 'Jl. Pancasila No 5', 'PT. Mitrausaha Group', '0812910231', 'JNE', 2118125, '2016-06-05 00:51:07', 'andy'),
(12, 'INV201606050011', 'Johny', 'Jl. Pancasila No 5', 'PT. Mitrausaha Group', '0812910231', 'JNE', 1638000, '2016-06-05 00:53:21', 'andy'),
(13, 'INV201606050012', 'Vivi', 'oaskd', 'asd', '123123', 'JNE', 598000, '2016-06-05 00:55:56', 'andy'),
(14, 'INV201606050013', 'Andy', 'test', 'test', '081203808', 'JNE', 241150, '2016-06-05 21:32:24', 'andy'),
(15, 'INV201606090001', '', '', '', '', 'JNE', 1638000, '2016-06-09 22:20:17', 'andy'),
(16, 'INV201606090002', '', '', '', '', 'JNE', 1638000, '2016-06-09 22:20:21', 'andy'),
(17, 'INV201606090003', '', '', '', '', 'JNE', 1638000, '2016-06-09 22:20:25', 'andy'),
(18, 'INV201606090004', '', '', '', '', 'JNE', 546000, '2016-06-09 22:21:12', 'andy'),
(19, 'INV201606090005', '', '', '', '', 'JNE', 546000, '2016-06-09 22:21:19', 'andy'),
(20, 'INV201606090006', '', '', '', '', 'JNE', 546000, '2016-06-09 22:21:24', 'andy'),
(21, 'INV201606090007', '', '', '', '', 'JNE', 546000, '2016-06-09 22:21:29', 'andy'),
(22, 'INV201606090008', '', '', '', '', 'JNE', 546000, '2016-06-09 22:22:02', 'andy'),
(23, 'INV201606090009', '', '', '', '', 'JNE', 546000, '2016-06-09 22:22:30', 'andy'),
(24, 'INV201606090010', '', '', '', '', 'JNE', 546000, '2016-06-09 22:23:18', 'andy'),
(25, 'INV201606090011', '', '', '', '', 'JNE', 546000, '2016-06-09 22:23:25', 'andy'),
(26, 'INV201606090012', '', '', '', '', 'JNE', 546000, '2016-06-09 22:23:33', 'andy'),
(27, 'INV201606090013', '', '', '', '', 'JNE', 546000, '2016-06-09 22:25:26', 'andy'),
(28, 'INV201606090014', '', '', '', '', 'JNE', 546000, '2016-06-09 22:26:49', 'andy'),
(29, 'INV201606090015', '', '', '', '', 'JNE', 546000, '2016-06-09 22:26:53', 'andy'),
(30, 'INV201606090016', '', '', '', '', 'JNE', 546000, '2016-06-09 22:27:06', 'andy'),
(31, 'INV201606090017', '', '', '', '', 'JNE', 546000, '2016-06-09 22:27:43', 'andy'),
(32, 'INV201606090018', '', '', '', '', 'JNE', 513500, '2016-06-09 22:35:45', 'andy'),
(33, 'INV201606090019', '', '', '', '', 'JNE', 200000, '2016-06-09 22:36:24', 'andy'),
(34, 'INV201606090020', '', '', '', '', 'JNE', 26000, '2016-06-09 23:19:34', 'andy'),
(35, 'INV201606090021', '', '', '', '', 'JNE', 85625, '2016-06-09 23:21:49', 'andy'),
(36, 'INV201606090022', '', '', '', '', 'JNE', 392250, '2016-06-09 23:26:08', 'andy');

-- --------------------------------------------------------

--
-- Struktur dari tabel `ms_invoice_detail`
--

CREATE TABLE `ms_invoice_detail` (
  `invoice_id` int(11) NOT NULL,
  `invoice_name` varchar(100) NOT NULL,
  `item_name` varchar(200) NOT NULL,
  `vendor_name` varchar(100) NOT NULL,
  `item_total` int(11) NOT NULL,
  `is_TO` int(11) NOT NULL,
  `is_DP` int(11) NOT NULL,
  `is_Palet` int(11) NOT NULL,
  `invoice_dt` datetime NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `last_modified_dt` datetime DEFAULT NULL,
  `modified_by` varchar(100) DEFAULT NULL,
  `is_void` int(11) NOT NULL DEFAULT '0',
  `void_dt` datetime DEFAULT NULL,
  `void_by` varchar(100) DEFAULT NULL,
  `void_remarks` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ms_invoice_detail`
--

INSERT INTO `ms_invoice_detail` (`invoice_id`, `invoice_name`, `item_name`, `vendor_name`, `item_total`, `is_TO`, `is_DP`, `is_Palet`, `invoice_dt`, `created_by`, `last_modified_dt`, `modified_by`, `is_void`, `void_dt`, `void_by`, `void_remarks`) VALUES
(8, 'INV201606050007', 'Test Tambah', 'PT Anugrah', 1, 0, 0, 0, '2016-06-05 00:46:00', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(9, 'INV201606050008', 'Test Tambah', 'PT Anugrah', 1, 0, 0, 0, '2016-06-05 00:47:12', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(10, 'INV201606050009', 'Test Tambah', 'PT Anugrah', 1, 0, 0, 0, '2016-06-05 00:47:17', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(11, 'INV201606050010', 'Torso Pria Dewasa Kulit Kepala Rambut Lukis + Sok DM', 'PT Anugrah', 5, 0, 0, 0, '2016-06-05 00:51:07', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(11, 'INV201606050010', '081 BNG FB Pria Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 'PT Anugrah', 1, 0, 0, 0, '2016-06-05 00:51:07', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(11, 'INV201606050010', 'Test Tambah', 'PT Anugrah', 2, 0, 0, 0, '2016-06-05 00:51:07', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(12, 'INV201606050011', '081 BNG FB Pria Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 'PT Anugrah', 3, 0, 0, 0, '2016-06-05 00:53:21', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(13, 'INV201606050012', '081 BNG FB Pria Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 'PT Anugrah', 1, 1, 1, 1, '2016-06-05 00:55:56', 'andy', NULL, NULL, 1, '2016-06-05 18:57:35', 'andy', 'jelek'),
(13, 'INV201606050012', '08 Dewasa Putih Body Dinding', 'PT Anugrah', 2, 1, 1, 1, '2016-06-05 00:55:56', 'andy', NULL, NULL, 1, '2016-06-05 19:03:00', 'andy', 'kurang'),
(14, 'INV201606050013', '01 P Butek Body', 'PT Anugrah', 3, 0, 1, 1, '2016-06-05 21:32:24', 'andy', NULL, NULL, 1, '2016-06-05 21:33:53', 'andy', 'return'),
(14, 'INV201606050013', '01 M Bening + Sok DM', 'PT Anugrah', 2, 0, 1, 1, '2016-06-05 21:32:24', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(26, 'INV201606090012', '081 BNG FB Pria Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 'PT Anugrah', 1, 300, 500, 12, '2016-06-09 22:23:33', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(27, 'INV201606090013', '081 BNG FB Pria Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 'PT Anugrah', 1, 2500, 7000, 30000, '2016-06-09 22:25:26', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(28, 'INV201606090014', '081 BNG FB Pria Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 'PT Anugrah', 1, 500, 1000, 20000, '2016-06-09 22:26:49', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(29, 'INV201606090015', '081 BNG FB Pria Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 'PT Anugrah', 1, 500, 1000, 20000, '2016-06-09 22:26:53', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(30, 'INV201606090016', '081 BNG FB Pria Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 'PT Anugrah', 1, 500, 1000, 20000, '2016-06-09 22:27:06', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(31, 'INV201606090017', '081 BNG FB Pria Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 'PT Anugrah', 1, 1231, 1234, 123123, '2016-06-09 22:27:43', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(32, 'INV201606090018', '032 BNG FB Wanita Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 'PT Anugrah', 1, 0, 0, 123, '2016-06-09 22:35:45', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(33, 'INV201606090019', '01 P Lampu Body + Lampu + Plat Kayu Oval + Dus', 'PT Master', 1, 12000, 0, 0, '2016-06-09 22:36:24', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(34, 'INV201606090020', '08 Dewasa Putih Body Dinding', 'PT Anugrah', 1, 0, 0, 0, '2016-06-09 23:19:45', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(35, 'INV201606090021', 'Torso Pria Dewasa Kulit Kepala Botak Lukis + Sok DM', 'PT Anugrah', 1, 123, 123, 123, '2016-06-09 23:21:52', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(36, 'INV201606090022', '08 Dewasa Putih Body Dinding', 'PT Anugrah', 1, 250, 100, 300, '2016-06-09 23:26:29', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(36, 'INV201606090022', 'Torso Pria Dewasa Kulit Kepala Rambut Lukis + Sok DM', 'PT Anugrah', 2, 250, 100, 300, '2016-06-09 23:26:48', 'andy', NULL, NULL, 0, NULL, NULL, NULL),
(36, 'INV201606090022', '01 M Butek Body + T.Besi + Baju Busa Crem + Sok DM', 'PT Anugrah', 3, 250, 100, 300, '2016-06-09 23:27:02', 'andy', NULL, NULL, 0, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Struktur dari tabel `ms_item`
--

CREATE TABLE `ms_item` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_name` varchar(200) NOT NULL,
  `stock` int(11) NOT NULL,
  `cost_price` int(11) NOT NULL,
  `retail_price` int(11) NOT NULL,
  `wholesale_price` int(11) DEFAULT NULL,
  `wholesale_number` int(11) DEFAULT NULL,
  `vendor_name` varchar(100) NOT NULL,
  `Category` varchar(100) NOT NULL,
  `Satuan` varchar(50) NOT NULL,
  `Isi` int(11) NOT NULL,
  `created_dt` datetime NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `last_modified_dt` datetime DEFAULT NULL,
  `modified_by` varchar(100) DEFAULT NULL,
  `is_deleted` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`item_id`),
  UNIQUE KEY `item_name` (`item_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ms_item`
--

INSERT INTO `ms_item` (`item_id`, `item_name`, `stock`, `cost_price`, `retail_price`, `wholesale_price`, `wholesale_number`, `vendor_name`, `Category`, `Satuan`, `Isi`, `created_dt`, `created_by`, `last_modified_dt`, `modified_by`, `is_deleted`) VALUES
(1, 'Hanger Baju A', 10, 0, 1000, 500, 7, '1', '', '', 0, '2016-05-15 19:31:30', 'andy', NULL, NULL, 1),
(2, 'Gantungan Baju', 500, 0, 2000, 1000, 10, '1', '', '', 0, '2016-05-15 19:32:35', 'andy', NULL, NULL, 1),
(3, '01 P Lampu Body + Lampu + Plat Kayu Oval + Dus', 9, 160000, 208000, 200000, 1, 'PT Master', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(4, '01 P Bening Body + Sok DM', 10, 52500, 68250, 65625, 2, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(5, '01 M Butek Body + T.Besi + Baju Busa Crem + Sok DM', 7, 52000, 67600, 65000, 3, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(6, '01 M Bening + Sok DM', 8, 41000, 53300, 51250, 4, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(7, '01 M Bening', 10, 37500, 48750, 46875, 5, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(8, 'Gantungan ?', 10, 1500, 1950, 1875, 6, 'PT Anugrah', 'Hanger', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(9, '031 BNG FB Wanita Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 10, 395000, 513500, 493750, 7, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(10, '032 BNG FB Wanita Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 9, 395000, 513500, 493750, 8, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(11, '01 M Butek Body + T.Besi + Baju Busa Hitam + Sok DM', 10, 52000, 67600, 65000, 9, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(12, 'Torso Pria Dewasa Kulit Kepala Botak Lukis + Sok DM', 9, 68500, 89050, 85625, 1, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(13, 'Torso Pria Dewasa Kulit Kepala Rambut Lukis + Sok DM', 3, 68500, 89050, 85625, 2, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(14, '08 Dewasa Putih Body Dinding', 8, 20000, 26000, 25000, 3, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-06-05 19:03:00', 'andy', 0),
(15, '01 P Butek Body', 10, 34500, 44850, 43125, 4, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-06-05 21:33:53', 'andy', 0),
(16, 'Sok DM', 10, 3000, 3900, 3750, 5, 'PT Anugrah', 'Parts', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(17, '01 M Butek', 10, 26000, 33800, 32500, 6, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(18, '081 BNG FB Pria Dewasa Tanpa Kepala + Tangan + P Plastik(Betis) + Dus', 0, 420000, 546000, 525000, 7, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-24 22:51:48', 'andy', '2016-06-05 18:57:35', 'andy', 0),
(19, 'Wow keren', 0, 430000, 559000, 537500, 7, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-25 22:44:12', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(20, 'new1', 15, 420000, 546000, 525000, 7, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-25 22:59:21', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(21, 'new2', 25, 420000, 546000, 525000, 7, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-25 23:13:54', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(22, 'new3', 25, 420000, 546000, 525000, 7, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-25 23:13:54', 'andy', '2016-05-26 21:29:29', 'andy', 0),
(23, 'tambahmanual_1', 50, 5000, 7000, 6000, 5, 'PT. MasterSystem', 'Baju', 'Lusin', 12, '2016-05-26 00:55:02', 'andy', NULL, NULL, 0),
(24, 'Test Tambah', 0, 440000, 572000, 550000, 7, 'PT Anugrah', 'Mannequine', 'Lusin', 12, '2016-05-26 21:25:02', 'andy', '2016-05-26 21:29:29', 'andy', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `ms_kategori`
--

CREATE TABLE `ms_kategori` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `category_name` varchar(100) NOT NULL,
  `created_dt` datetime NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `last_modified_dt` datetime DEFAULT NULL,
  `modified_by` varchar(100) DEFAULT NULL,
  `is_deleted` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `nama_kategori` (`category_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ms_kategori`
--

INSERT INTO `ms_kategori` (`id`, `category_name`, `created_dt`, `created_by`, `last_modified_dt`, `modified_by`, `is_deleted`) VALUES
(4, 'Baju', '2016-05-25 23:47:10', 'andy', NULL, NULL, 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `ms_satuan`
--

CREATE TABLE `ms_satuan` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama_satuan` varchar(100) NOT NULL,
  `created_dt` datetime NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `last_modified_dt` datetime DEFAULT NULL,
  `modified_by` varchar(100) DEFAULT NULL,
  `is_deleted` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `nama_satuan` (`nama_satuan`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ms_satuan`
--

INSERT INTO `ms_satuan` (`id`, `nama_satuan`, `created_dt`, `created_by`, `last_modified_dt`, `modified_by`, `is_deleted`) VALUES
(1, 'Lusin', '2016-05-26 00:04:58', 'andy', NULL, NULL, 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `ms_user`
--

CREATE TABLE `ms_user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(100) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `address` varchar(255) NOT NULL,
  `mobile_no` varchar(20) NOT NULL,
  `level` varchar(20) NOT NULL,
  `created_dt` datetime NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `last_modified_dt` datetime DEFAULT NULL,
  `modified_by` varchar(100) DEFAULT NULL,
  `is_active` int(11) NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ms_user`
--

INSERT INTO `ms_user` (`user_id`, `username`, `password`, `first_name`, `last_name`, `address`, `mobile_no`, `level`, `created_dt`, `created_by`, `last_modified_dt`, `modified_by`, `is_active`) VALUES
(1, 'andy', '17c4520f6cfd1ab53d8745e84681eb49', 'andy', '', 'Jalan ....', '081212063245', 'SUPERADMIN', '2016-05-15 16:07:28', 'andy', NULL, NULL, 1),
(2, 'janice', 'superadmin', 'janice', 'janice', 'JL kemang', '018230182', 'SUPERADMIN', '2016-05-15 18:17:58', 'andy', NULL, NULL, 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `ms_vendor`
--

CREATE TABLE `ms_vendor` (
  `vendor_id` int(11) NOT NULL AUTO_INCREMENT,
  `vendor_name` varchar(200) NOT NULL,
  `address` varchar(255) DEFAULT NULL,
  `mobile_no` varchar(20) DEFAULT NULL,
  `email` varchar(40) DEFAULT NULL,
  `created_dt` datetime NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `last_modified_dt` datetime DEFAULT NULL,
  `modified_by` varchar(100) DEFAULT NULL,
  `is_active` int(11) NOT NULL,
  PRIMARY KEY (`vendor_id`),
  UNIQUE KEY `vendor_name` (`vendor_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ms_vendor`
--

INSERT INTO `ms_vendor` (`vendor_id`, `vendor_name`, `address`, `mobile_no`, `email`, `created_dt`, `created_by`, `last_modified_dt`, `modified_by`, `is_active`) VALUES
(1, 'PT. MasterSystem', 'Jl Sudirman', '0210129301', 'mastersystem@gmail.com', '2016-05-15 19:09:01', 'andy', NULL, NULL, 1),
(2, 'PT. Metrodata Invotama', 'jl rasuna said blok c', '0812391023', 'masterdata@gmail.com', '2016-05-15 19:12:50', 'andy', NULL, NULL, 1),
(3, 'PT Anugrah', 'PT Anugrah', 'PT Anugrah', 'PT Anugrah', '2016-05-26 00:00:00', 'andy', NULL, NULL, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
