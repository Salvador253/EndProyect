-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-11-2020 a las 02:27:07
-- Versión del servidor: 10.4.14-MariaDB
-- Versión de PHP: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `xray`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id1` int(20) NOT NULL,
  `nombrehe` varchar(255) NOT NULL,
  `encargado` varchar(255) NOT NULL,
  `equipo` varchar(255) NOT NULL,
  `no_serie` int(10) NOT NULL,
  `marca` varchar(255) NOT NULL,
  `modelo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `costos`
--

CREATE TABLE `costos` (
  `id2` int(10) NOT NULL,
  `precio` int(15) NOT NULL,
  `equipo` varchar(255) NOT NULL,
  `no_serie` int(10) NOT NULL,
  `estado` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `id3` int(20) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `apellido` varchar(255) NOT NULL,
  `n_contacto` int(10) NOT NULL,
  `correo` varchar(255) NOT NULL,
  `especialidad` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresas`
--

CREATE TABLE `empresas` (
  `id4` int(20) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `nom_titular` varchar(255) NOT NULL,
  `marca` varchar(255) NOT NULL,
  `contacto` int(10) NOT NULL,
  `correo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `equipos`
--

CREATE TABLE `equipos` (
  `id5` int(10) NOT NULL,
  `equipo` varchar(255) NOT NULL,
  `marca` varchar(255) NOT NULL,
  `modelo` varchar(255) NOT NULL,
  `estado` varchar(255) NOT NULL,
  `tipo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `equipos`
--

INSERT INTO `equipos` (`id5`, `equipo`, `marca`, `modelo`, `estado`, `tipo`) VALUES
(1, 'Radiografia Digital', 'PHILIPS', 'DigitalDiagnos C90', 'En Renta', 'de planta'),
(2, 'Radiografia Digital', 'PHILIPS', 'DigitalDiagnost C50', 'Disponible', 'De Planta'),
(3, 'Radiografia Digital', 'PHILIPS', 'DuraDiagnost', 'En Renta', 'De Planta'),
(4, 'Radiografia Digital', 'PHILIPS', 'DuraDiagnost F30', 'Disponible', 'De Planta'),
(5, 'Radiografia Movil', 'PHILIPS', 'MobileDiagnost wDR', 'Disponible', 'movil'),
(6, 'Fluoroscopio', 'PHILIPS', 'CombiDiagnost R90', 'Vendido', 'Fijo'),
(7, 'Fluoroscopio', 'PHILIPS', 'ProxiDiagnost N90', 'Disponible', 'Fijo'),
(8, 'Rayos X RF de alta frecuencia digital Radio-Fluoroscopia (RFX)', 'WDM', 'HF52-2', 'Disponible', 'fijo'),
(9, 'Unidad de rayos X portatil digital', 'WDM', 'Mobil fine', 'disponible', 'mobil'),
(10, 'Sistema de Rayos-X digital', 'New Oriental', '1000S', 'disponible', 'fijo'),
(11, 'Portátil de rayos-X Sistema', 'EPX-Seriese', 'EPX-F2400', 'disponible', 'mobil'),
(12, 'Dental X-Ray\r\n', 'DENSPAY', 'CYG001', 'Disponible', 'Mobil'),
(13, 'Máquina de rayos X Dental móvil', 'HF', 'CK-DX10A', 'Disponible', 'mobil');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id6` bigint(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id1`);

--
-- Indices de la tabla `costos`
--
ALTER TABLE `costos`
  ADD PRIMARY KEY (`id2`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`id3`);

--
-- Indices de la tabla `empresas`
--
ALTER TABLE `empresas`
  ADD PRIMARY KEY (`id4`);

--
-- Indices de la tabla `equipos`
--
ALTER TABLE `equipos`
  ADD PRIMARY KEY (`id5`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id6`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id1` int(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `costos`
--
ALTER TABLE `costos`
  MODIFY `id2` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `id3` int(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `empresas`
--
ALTER TABLE `empresas`
  MODIFY `id4` int(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `equipos`
--
ALTER TABLE `equipos`
  MODIFY `id5` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id6` bigint(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
