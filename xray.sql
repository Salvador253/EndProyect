-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-11-2020 a las 04:38:00
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
-- Estructura de tabla para la tabla `catalogo`
--

CREATE TABLE `catalogo` (
  `id_catalogo` int(15) NOT NULL,
  `no_serie` int(11) NOT NULL,
  `equipo` varchar(255) NOT NULL,
  `id_empresa` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `precio` int(11) NOT NULL,
  `id1` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `catalogo`
--

INSERT INTO `catalogo` (`id_catalogo`, `no_serie`, `equipo`, `id_empresa`, `nombre`, `precio`, `id1`) VALUES
(1, 7, 'Fluroscopia', 4, 'GE', 1234, 3),
(2, 1, 'Radiografia', 5, 'TCH', 6789, 1);

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

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id1`, `nombrehe`, `encargado`, `equipo`, `no_serie`, `marca`, `modelo`) VALUES
(1, 'Ramirez', '5', 'Gammacamara', 4, 'TEch', '567hg'),
(2, 'Ramiro', '6', 'Gammacamara', 1, 'PHU', 'dgfn66'),
(3, 'Ramiro', '6', 'Gammacamara', 2, 'Phillips', '6789K'),
(4, 'Lusi Gomez', '8', 'Fluroscopio', 4, 'TCh', '35'),
(5, 'Luis', '7', 'Rayo x', 12, 'GE', '67-k'),
(6, 'Yesenia', '8', 'Rayos X', 4, 'Dragger', '89-17k');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cli_equi`
--

CREATE TABLE `cli_equi` (
  `id3` int(12) NOT NULL,
  `id1` int(10) NOT NULL,
  `nombrehe` varchar(255) NOT NULL,
  `no_serie` int(20) NOT NULL,
  `equipo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `cli_equi`
--

INSERT INTO `cli_equi` (`id3`, `id1`, `nombrehe`, `no_serie`, `equipo`) VALUES
(1, 2, 'Gonzalez', 1, 'Radiografia'),
(2, 4, 'Bolaños', 8, 'Rayos X RF');

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

--
-- Volcado de datos para la tabla `costos`
--

INSERT INTO `costos` (`id2`, `precio`, `equipo`, `no_serie`, `estado`) VALUES
(1, 4567, 'Radiografia', 4, 'Disponible'),
(2, 45678, 'Gammacamara', 1, 'Ocupado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `n_contacto` int(20) NOT NULL,
  `nombre_em` varchar(255) NOT NULL,
  `apellido` varchar(255) NOT NULL,
  `correo` varchar(255) NOT NULL,
  `especialidad` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`n_contacto`, `nombre_em`, `apellido`, `correo`, `especialidad`) VALUES
(2, 'Antonio ', 'Aguilar', 'antoniAg@gmail.com', 'Biomédico '),
(3, 'Rubén ', 'Merino', 'rubenmeri99@gmail.com\n', 'Biomédico'),
(4, 'Karen ', 'Rubio', 'karenmich@gmail.com\n', 'Mecatronica'),
(5, 'Roger ', 'Martínez ', 'roger1910@gmail.com\n', 'Biomédico');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresas`
--

CREATE TABLE `empresas` (
  `id_empresa` int(20) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `nom_titular` varchar(255) NOT NULL,
  `marca` varchar(255) NOT NULL,
  `contacto` int(10) NOT NULL,
  `correo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `empresas`
--

INSERT INTO `empresas` (`id_empresa`, `nombre`, `nom_titular`, `marca`, `contacto`, `correo`) VALUES
(2, 'Phillips', 'Willson', 'Phil', 456789, 'phillips@hotmail.com'),
(3, 'Dragger SA', 'Augustus', 'Dragger', 345678, 'dragger.info@support.com'),
(4, 'General Electric', 'Alexander', 'GE', 345678, 'general_elec@info.com'),
(5, 'TecnoX', 'Julio', 'TCX', 234567, 'algo@alguien.tv');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa_empleado`
--

CREATE TABLE `empresa_empleado` (
  `id_ee` int(11) NOT NULL,
  `id_empresa` int(11) NOT NULL,
  `n_contacto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `empresa_empleado`
--

INSERT INTO `empresa_empleado` (`id_ee`, `id_empresa`, `n_contacto`) VALUES
(1, 2, 4),
(2, 4, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `equipos`
--

CREATE TABLE `equipos` (
  `no_serie` int(10) NOT NULL,
  `equipo` varchar(255) NOT NULL,
  `marca` varchar(255) NOT NULL,
  `modelo` varchar(255) NOT NULL,
  `estado` varchar(255) NOT NULL,
  `tipo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `equipos`
--

INSERT INTO `equipos` (`no_serie`, `equipo`, `marca`, `modelo`, `estado`, `tipo`) VALUES
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
(13, 'Máquina de rayos X Dental móvil', 'HF', 'CK-DX10A', 'Disponible', 'mobil'),
(14, '', 'Phillips', 'Proxy Diagnost N90', 'Disponible', 'Fijo'),
(15, 'Equipo Dental', 'Ritter', 'RT-89', 'Vendido', 'Fijo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id6` bigint(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `permiso` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id6`, `nombre`, `password`, `permiso`) VALUES
(1, 'Salvador', '56112', '0'),
(2, 'Lupita', '56112', '1'),
(3, 'Genaro', '67', '1'),
(4, 'Hola', '2356', '1'),
(5, 'Luis', '1234', '1'),
(6, 'Dolphin56', '6789', '1');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `catalogo`
--
ALTER TABLE `catalogo`
  ADD PRIMARY KEY (`id_catalogo`),
  ADD KEY `no_serie` (`no_serie`),
  ADD KEY `id1` (`id1`),
  ADD KEY `id_empresa` (`id_empresa`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id1`),
  ADD KEY `no_serie` (`no_serie`);

--
-- Indices de la tabla `cli_equi`
--
ALTER TABLE `cli_equi`
  ADD PRIMARY KEY (`id3`),
  ADD KEY `id1` (`id1`),
  ADD KEY `no_serie` (`no_serie`);

--
-- Indices de la tabla `costos`
--
ALTER TABLE `costos`
  ADD PRIMARY KEY (`id2`),
  ADD KEY `no_serie` (`no_serie`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`n_contacto`);

--
-- Indices de la tabla `empresas`
--
ALTER TABLE `empresas`
  ADD PRIMARY KEY (`id_empresa`);

--
-- Indices de la tabla `empresa_empleado`
--
ALTER TABLE `empresa_empleado`
  ADD PRIMARY KEY (`id_ee`),
  ADD KEY `id_empresa` (`id_empresa`),
  ADD KEY `n_contacto` (`n_contacto`);

--
-- Indices de la tabla `equipos`
--
ALTER TABLE `equipos`
  ADD PRIMARY KEY (`no_serie`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id6`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `catalogo`
--
ALTER TABLE `catalogo`
  MODIFY `id_catalogo` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id1` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `cli_equi`
--
ALTER TABLE `cli_equi`
  MODIFY `id3` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `costos`
--
ALTER TABLE `costos`
  MODIFY `id2` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `n_contacto` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `empresas`
--
ALTER TABLE `empresas`
  MODIFY `id_empresa` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `empresa_empleado`
--
ALTER TABLE `empresa_empleado`
  MODIFY `id_ee` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `equipos`
--
ALTER TABLE `equipos`
  MODIFY `no_serie` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id6` bigint(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `catalogo`
--
ALTER TABLE `catalogo`
  ADD CONSTRAINT `catalogo_ibfk_1` FOREIGN KEY (`id_empresa`) REFERENCES `empresas` (`id_empresa`) ON UPDATE CASCADE,
  ADD CONSTRAINT `catalogo_ibfk_2` FOREIGN KEY (`no_serie`) REFERENCES `equipos` (`no_serie`) ON UPDATE CASCADE,
  ADD CONSTRAINT `catalogo_ibfk_3` FOREIGN KEY (`id1`) REFERENCES `clientes` (`id1`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `cli_equi`
--
ALTER TABLE `cli_equi`
  ADD CONSTRAINT `cli_equi_ibfk_1` FOREIGN KEY (`no_serie`) REFERENCES `equipos` (`no_serie`) ON UPDATE CASCADE,
  ADD CONSTRAINT `cli_equi_ibfk_2` FOREIGN KEY (`id1`) REFERENCES `clientes` (`id1`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `costos`
--
ALTER TABLE `costos`
  ADD CONSTRAINT `costos_ibfk_1` FOREIGN KEY (`no_serie`) REFERENCES `equipos` (`no_serie`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `empresa_empleado`
--
ALTER TABLE `empresa_empleado`
  ADD CONSTRAINT `empresa_empleado_ibfk_1` FOREIGN KEY (`id_empresa`) REFERENCES `empresas` (`id_empresa`) ON UPDATE CASCADE,
  ADD CONSTRAINT `empresa_empleado_ibfk_2` FOREIGN KEY (`n_contacto`) REFERENCES `empleados` (`n_contacto`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
