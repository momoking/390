-- SOEN390 Database Datadump
-- Date Created:       March 1st 2013
-- Date Last Modified: March 1st 2013
--
-- Purpose: Used for populating stable dropdown tables (Citizenship, Gender, MaritalStatus, Mothertongue, Region, etc).
--          Does NOT populate unstable data (clients, household, events, waiting lists, etc).
--
-- Instructions to Import into DB:
-- 1. Connect to phpMyAdmin.
-- 2. Select the soen390 DB.
-- 3. Navigate to the 'Import' Tab.
-- 4. Click on the 'Browse' button where it asks for you to import a file, select the attached file.
-- 5. Click 'GO' (no other configuration necessary).
--
-- This file should be run everytime the database needs to be flushed.
--
--

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;


--
-- Dumping data for table `citizenship`
--

INSERT IGNORE INTO `citizenship` (`CitizenshipName`) VALUES
('Citizen'),
('Permanent Resident'),
('Refugee'),
('Student Visa'),
('Undeclared');

--
-- Dumping data for table `gender`
--

INSERT IGNORE INTO `gender` (`GenderName`) VALUES
('F'),
('M');

--
-- Dumping data for table `maritalstatus`
--

INSERT IGNORE INTO `maritalstatus` (`MaritalStatusName`) VALUES
('Married'),
('CommonLaw'),
('Single'),
('Widowed'),
('Divorced'),
('Undeclared');

--
-- Dumping data for table `mothertongue`
--

INSERT IGNORE INTO `mothertongue` (`LanguageName`) VALUES
('English'),
('French'),
('Spanish'),
('Russian'),
('Romanian'),
('Croatian'),
('Hungarian'),
('Chinese'),
('Arab'),
('Farsi'),
('Bulgarian'),
('Japanese'),
('Portuguese'),
('Other');

--
-- Dumping data for table `region`
--

INSERT IGNORE INTO `region` (`ForwardSortationArea`, `RegionName`) VALUES
('H4G', 'Verdun'),
('H4H', 'Verdun'),
('H4J', 'Cartierville'),
('H4K', 'Cartierville'),
('H4L', 'St-Laurent'),
('H4M', 'St-Laurent'),
('H4N', 'St-Laurent'),
('H4P', 'C-D-N'),
('H4R', 'St-Laurent'),
('H4V', 'NDG'),
('H4W', 'Cote St-Luc'),
('H4X', 'Montreal West'),
('H5N', 'Ville Edmard'),
('H6N', 'Montreal West'),
('H7C', 'St-Vincent de Paul'),
('H7E', 'St-Vincent de Paul'),
('H7G', 'Pont Viau (Laval)'),
('H7K', 'Auteuil'),
('H7M', 'Laval'),
('H7N', 'Laval'),
('H7P', 'Fabrevville'),
('H7R', 'Laval West'),
('H7S', 'Comedy N-E'),
('H7T', 'Comedy N-W'),
('H7V', 'Comedy East'),
('H7W', 'Comedy Sud'),
('H8L', 'St-Laurent'),
('H8N', 'Lasalle'),
('H8P', 'Lasalle'),
('H8R', 'Lasalle'),
('H8S', 'Lachine'),
('H8T', 'Lachine'),
('H8Y', 'Roxboro'),
('H8Z', 'Pierrefonds'),
('H9A', 'Dollard-des-Ormeaux'),
('H9B', 'Dollard-des-Ormeaux'),
('H9H', 'Kirkland'),
('H9J', 'Kirkland'),
('H9S', 'Dorval');

--
-- Dumping data for table `servicelanguage`
--

INSERT IGNORE INTO `servicelanguage` (`LanguageName`) VALUES
('English'),
('French'),
('Spanish');

--
-- Dumping data for table `workstatus`
--


INSERT IGNORE INTO `workstatus` (`WorkStatusName`) VALUES
('Pension'),
('Unemployment'),
('Welfare'),
('Low Income'),
('Student'),
('None'),
('Undeclared');

--
-- Dumping data for table `origin`
--


INSERT IGNORE INTO `origin` (`OriginName`) VALUES
('North American'),
('Hispanic'),
('European'),
('African'),
('Middle East'),
('Far East');


--
-- Dumping data for table `incometype`
--


INSERT IGNORE INTO `incometype` (`IncomeTypeName`) VALUES
('Wage'),
('Self Employment'),
('Business Income'),
('None'),
('Heritage'),
('Other');
