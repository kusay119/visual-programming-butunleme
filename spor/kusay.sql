-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 13 يناير 2023 الساعة 02:15
-- إصدار الخادم: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kusay`
--

-- --------------------------------------------------------

--
-- بنية الجدول `adminuser`
--

CREATE TABLE `adminuser` (
  `user` text NOT NULL,
  `pass` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- إرجاع أو استيراد بيانات الجدول `adminuser`
--

INSERT INTO `adminuser` (`user`, `pass`) VALUES
('admin', '12345'),
('admin', '12345');

-- --------------------------------------------------------

--
-- بنية الجدول `ekle`
--

CREATE TABLE `ekle` (
  `id` int(11) NOT NULL,
  `adi` text NOT NULL,
  `soyadi` text NOT NULL,
  `yas` int(11) NOT NULL,
  `zaman` text NOT NULL,
  `ay` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- إرجاع أو استيراد بيانات الجدول `ekle`
--

INSERT INTO `ekle` (`id`, `adi`, `soyadi`, `yas`, `zaman`, `ay`) VALUES
(2, 'muhammed', 'KORC', 2000, 'öğleden sonra', '2 yıl');

-- --------------------------------------------------------

--
-- بنية الجدول `login`
--

CREATE TABLE `login` (
  `username` text NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- إرجاع أو استيراد بيانات الجدول `login`
--

INSERT INTO `login` (`username`, `password`) VALUES
('admin', '12345'),
('admin', '12345'),
('kusay', '12345');

-- --------------------------------------------------------

--
-- بنية الجدول `odeme`
--

CREATE TABLE `odeme` (
  `id` int(11) NOT NULL,
  `adi` text NOT NULL,
  `soyadi` text NOT NULL,
  `od` int(11) NOT NULL,
  `odk` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- إرجاع أو استيراد بيانات الجدول `odeme`
--

INSERT INTO `odeme` (`id`, `adi`, `soyadi`, `od`, `odk`) VALUES
(0, 'muhammed', 'korc', 22500, 312),
(2, 'korc', 'nagsan', 1230, 1300);

-- --------------------------------------------------------

--
-- بنية الجدول `personel`
--

CREATE TABLE `personel` (
  `adi` text NOT NULL,
  `soyadi` text NOT NULL,
  `ucret` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- إرجاع أو استيراد بيانات الجدول `personel`
--

INSERT INTO `personel` (`adi`, `soyadi`, `ucret`) VALUES
('muhammed', 'korc', 1500);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ekle`
--
ALTER TABLE `ekle`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `odeme`
--
ALTER TABLE `odeme`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ekle`
--
ALTER TABLE `ekle`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `odeme`
--
ALTER TABLE `odeme`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
