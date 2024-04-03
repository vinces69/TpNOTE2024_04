-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mer. 03 avr. 2024 à 13:17
-- Version du serveur :  5.7.19
-- Version de PHP :  5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bdd_musiquev2`
--

-- --------------------------------------------------------

--
-- Structure de la table `album`
--

DROP TABLE IF EXISTS `album`;
CREATE TABLE IF NOT EXISTS `album` (
  `IDALBUM` int(11) NOT NULL AUTO_INCREMENT,
  `IDARTISTE` int(11) NOT NULL,
  `NOMALBUM` varchar(255) NOT NULL,
  `DESCALBUM` longtext,
  `POCHETTEALBUM` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDALBUM`),
  KEY `I_FK_ALBUM_ARTISTE` (`IDARTISTE`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `album`
--

INSERT INTO `album` (`IDALBUM`, `IDARTISTE`, `NOMALBUM`, `DESCALBUM`, `POCHETTEALBUM`) VALUES
(1, 1, 'Metallica', 'L\'album marque une évolution importante dans le style du groupe. Les tempos sont plus lents, les morceaux plus courts et leurs structures beaucoup plus simples, aspirant ainsi à du simple rock. C\'est principalement un album de heavy metal, et il n\'y a plus beaucoup de traces de thrash metal.', 'https://m.media-amazon.com/images/I/61Na6eN05jS._SL1500_.jpg'),
(2, 2, 'Back to black', NULL, NULL),
(3, 1, 'Ride the lightning', 'Ride the Lightning est considéré comme l\'un des classiques du thrash metal et comme une transition musicale entre les débuts de Metallica, Kill \'em All et Master of Puppets, plus mélodique et progressif', 'https://m.media-amazon.com/images/I/71cr-UivXLL._UF1000,1000_QL80_.jpg'),
(4, 1, 'Master of Puppets', 'Master of Puppets a reçu des critiques dithyrambiques par la critique musicale et a été inclus dans les meilleures listes d\'albums par certains magazines. Sa puissance, sa virtuosité et ses paroles politiques et colériques ont attiré les éloges de la critique en dehors de la communauté metal. L\'album est largement considéré comme le plus gros effort du groupe à l\'époque, et devenu l\'un des albums de thrash metal les plus influents de tous les temps.', 'https://m.media-amazon.com/images/I/71sK5UnvqEL._UF1000,1000_QL80_.jpg'),
(5, 1, 'And Justice for All', 'Le titre de l\'album est une allusion aux quatre derniers mots du serment d\'allégeance au drapeau des États-Unis. Les chansons de …And Justice For All ont pour thèmes la douleur (Harvester of Sorrow), l\'injustice (…And Justice for All), la folie (The Frayed Ends of Sanity) et la mort (To Live Is to Die).', 'https://m.media-amazon.com/images/I/71UuU-ehbuL._UF1000,1000_QL80_.jpg'),
(6, 1, 'Kill\'em all', 'Cet album marque le début d\'une des légendes du thrash metal. Plus rapide que ses successeurs, cet album est considéré comme incontournable par les fans. Le tempo de la plupart des chansons de l\'album est très rythmé et ultra rapide.', 'https://m.media-amazon.com/images/I/612BO0E30rL._UF1000,1000_QL80_.jpg'),
(7, 1, 'Hardwired... to self destruct ', '8 ans après Death Magnetic, le retour du groupe est un événement très attendu qui fait déjà beaucoup de bruit', 'https://m.media-amazon.com/images/I/610irGu-6VS._UF1000,1000_QL80_.jpg');

-- --------------------------------------------------------

--
-- Structure de la table `artiste`
--

DROP TABLE IF EXISTS `artiste`;
CREATE TABLE IF NOT EXISTS `artiste` (
  `IDARTISTE` int(11) NOT NULL AUTO_INCREMENT,
  `LABELARTISTE` varchar(255) NOT NULL,
  `GROUPEARTISTE` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`IDARTISTE`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `artiste`
--

INSERT INTO `artiste` (`IDARTISTE`, `LABELARTISTE`, `GROUPEARTISTE`) VALUES
(1, 'Metallica', NULL),
(2, 'AC/DC', NULL),
(3, 'Alestorn', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `posseder`
--

DROP TABLE IF EXISTS `posseder`;
CREATE TABLE IF NOT EXISTS `posseder` (
  `IDUTILISATEUR` int(11) NOT NULL,
  `IDALBUM` int(11) NOT NULL,
  `FAVORIS` tinyint(1) DEFAULT NULL,
  `DATEACHAT` date DEFAULT NULL,
  PRIMARY KEY (`IDUTILISATEUR`,`IDALBUM`),
  KEY `I_FK_POSSEDER_UTILISATEURS` (`IDUTILISATEUR`),
  KEY `I_FK_POSSEDER_ALBUM` (`IDALBUM`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `IDUTILISATEUR` int(11) NOT NULL AUTO_INCREMENT,
  `NOMUTILISATEUR` varchar(255) NOT NULL,
  `PRENOMUTILISATEUR` varchar(255) NOT NULL,
  `MAILUTILISATEUR` varchar(255) NOT NULL,
  `LOGINUTILISATEUR` varchar(255) NOT NULL,
  `MDPUTILISATEUR` varchar(255) NOT NULL,
  PRIMARY KEY (`IDUTILISATEUR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `album`
--
ALTER TABLE `album`
  ADD CONSTRAINT `ALBUM_ibfk_1` FOREIGN KEY (`IDARTISTE`) REFERENCES `artiste` (`IDARTISTE`);

--
-- Contraintes pour la table `posseder`
--
ALTER TABLE `posseder`
  ADD CONSTRAINT `POSSEDER_ibfk_1` FOREIGN KEY (`IDUTILISATEUR`) REFERENCES `utilisateurs` (`IDUTILISATEUR`),
  ADD CONSTRAINT `POSSEDER_ibfk_2` FOREIGN KEY (`IDALBUM`) REFERENCES `album` (`IDALBUM`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
