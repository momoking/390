-- SOEN390 Database Datadump
-- Date Created:       March 1st 2013
-- Date Last Modified: March 1st 2013
--
-- Purpose: Used for populating unstable data. Currently, only clients, dependents, households and notes are considered.
-- Things currently not considered: Flags, Events, Appointments.
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
-- Dumping data for table `Client`
--

INSERT IGNORE INTO `client` (`ID`, `FirstName`, `LastName`, `DoB`, `Medicare`, `Gender`, `Origin`, `Citizenship`, `MotherTongue`, `ServiceLanguage`, `MaritalStatus`, `WorkStatus`, `AnnualIncome`, `ReasonForServiceUsage`) VALUES
(1, 'Gertrude', 'Stutz', '1985-05-05','STUG85550599', 'F', 'North American', 'Citizen', 'English', 'English', 'Single', 'Low Income', 15332.85, 'Lost her job a few years ago and is having troubles supporting herself.'),
(2, 'Randall','Wilkins','1978-11-21','WILR78112199','M','European','Citizen','English','English','Divorced','Low Income', 12004.11, ''),
(3, 'Megan','Chang','1990-05-22','CHAM90552299','F','Far East','Student Visa','Chinese','English','Married','Low Income', 13423.53, '' ),
(4, 'Desiree','Lowe','1989-07-12','LOWD89571299','F','North American','Citizen','French','French','Single','Pension', 14232.23, ''),
(5, 'Malcolm','Lucio','1990-12-30','LUCM90123099','M','Hispanic','Permanent Resident','French','French','Divorced','None', 16343.42, ''),
(6, 'Yi Min','Liang','1983-04-06','LIAYC890406','M','Far East','Citizen','Chinese','English','Divorced','Unemployment', 17294.89, 'Needs support while looking for a new job.'),
(7, 'Michelle','Pierce','1974-11-08', 'PIEM74610899', 'F','African','Citizen','English','French','CommonLaw','Student', 18534.00, 'Needs support while studying.'),
(8, 'Heather','Berger','1985-09-22', 'BERH85592299', 'F','North American','Permanent Resident','English','English','CommonLaw','None', 12555.33, 'Was referred to the mission from a friend.'),
(9, 'Coby','Collins','1976-12-23', 'COLC76122399' , 'M','Middle East','Student Visa','Spanish','Spanish','Married','Student', 13222.44, 'Needs support while studying.'),
(10, 'Hamano','Takisawa','1988-05-25', 'TAKH88552599', 'F','Far East','Permanent Resident','English','English','Married','Student', 19434.43, '');


INSERT IGNORE INTO `client` (`ID`, `FirstName`, `LastName`, `DoB`, `Medicare`, `Gender`, `Origin`, `Citizenship`, `MotherTongue`, `ServiceLanguage`, `MaritalStatus`, `WorkStatus`, `AnnualIncome`, `ReasonForServiceUsage`, `WelfareNumber`) VALUES
(11, 'Serena', 'Gray', '1974-06-25', 'GRAS74562599', 'F', 'North American', 'Citizen', 'English', 'English', 'Married', 'Welfare', 12753.23, 'Needs support for her and her kids.', 'GRAS 2556 74A4-04');



--
-- Dumping data for table `Dependant`
--

INSERT IGNORE INTO `dependant` (`DependantID`, `FirstName`, `LastName`, `Medicare`, `Gender`, `WorkStatus`) VALUES
(1, 'Ross', 'Stutz', 'STUR74571599', 'F', 'None'),
(2, 'Shen', 'Chang',  'CHAS06010499', 'M', 'None'),
(3, 'Yuan', 'Chang', 'CHAY95602099', 'F', 'None'),
(4, 'Albina', 'Lowe', 'LOWA04520599', 'F', 'None'),
(5, 'Hamilton', 'Lowe', 'LOWH86121399', 'M', 'Low Income'),
(6, 'Barrett', 'Jones', 'JONB85512599', 'F', 'Student'),
(7, 'Reuben', 'Rouse', 'ROUR83022199', 'M', 'Unemployment'),
(8, 'Margaretta', 'Lucio', 'LUCM93572299', 'F', 'None'),
(9, 'Inez', 'Lucio', 'LUCI72082299', 'M', 'Unemployment'),
(10, 'Zia', 'Liang', 'LIAZ87602599', 'F', 'Student'),
(11, 'Blair', 'Berger', 'BERB09110599', 'M', 'None'),
(12, 'Karly', 'Berger', 'BERK81531399', 'F', 'Low Income'),
(13, 'James', 'Collins', 'COLJ861103', 'M', 'Low Income'),
(14, 'Graiden', 'Collins', 'COLG68521799', 'F', 'None'),
(15, 'Zephania', 'Collins', 'COLZ00520999', 'F', 'None'),
(16, 'Alexis', 'Collins', 'COLA85571799', 'F', 'Unemployment');


INSERT IGNORE INTO `dependant` (`DependantID`, `FirstName`, `LastName`, `Medicare`, `Gender`, `WorkStatus`, `WelfareNumber`) VALUES
(17, 'Kyle', 'Rouse', 'ROUK86062499', 'M', 'Welfare', 'ROUK 2406 86A4-04');



--
-- Dumping data for table `Client_Dependant`
--
INSERT IGNORE INTO `client_dependant` (`ClientID`, `DependantID`) VALUES
(1, 1),
(2, 1),
(2, 2),
(3, 3),
(3, 4),
(3, 5),
(4, 6),
(4, 7),
(4, 8),
(5, 9),
(7, 10),
(7, 11),
(8, 12),
(8, 13),
(8, 14),
(8, 15),
(10, 16);


--
-- Dumping data for table `Household`
--

INSERT IGNORE INTO `household` (`HouseholdID`, `StreetNumber`, `StreetName`, `AppartmentNumber`, `PostalCode`, `Region`, `PhoneNumber`, `FirstVisit`, `LastUpdate`, `NextUpdate`) VALUES
(10000000, '416', 'Easy Plaza', '5', 'H4G9E2', 'Verdun', '514-609-4019', '2008-05-01', '2010-04-24', '2010-10-24'),
(10000001, '6839', 'Eget Street', '', 'H4M3E5', 'St-Laurent', '514-739-4553', '2002-11-19', '2011-02-21', '2011-08-21'), 
(10000002, '603', 'Arcu. Avenue', '', 'H4X1K4', 'Montreal West', '514-611-0257', '2006-02-06', '2010-09-23', '2011-03-23'), 
(10000003, '2340', 'Orci Avenue', '3', 'H8N8B2', 'Lasalle', '514-673-2014', '2008-09-22', '2012-01-03', '2010-07-03'), 
(10000004, '504', 'Ultrices Street', '10', 'H8Y0D3', 'Roxboro', '514-279-1448', '2006-03-14', '2010-08-06', '2011-02-06'), 
(10000005, '12', 'Magna Avenue', '2', 'H8Z4J1', 'Pierrefonds', '514-204-3730', '2000-04-24', '2011-05-03', '2011-11-03'), 
(10000006, '5023', 'Duis Street', '', 'H9B7D3', 'Dollard-des-Ormeaux', '514-852-8528', '2003-04-06', '2011-04-08', '2011-10-08'), 
(10000007, '834', 'Arcu Ave', '4', 'H4P4P6', 'C-D-N', '514-468-3157', '2000-05-26', '2010-06-24', '2010-12-24'), 
(10000008, '105', 'Odio Rd', '', 'H4K1Q5', 'Cartierville', '514-627-4045', '2007-07-29', '2011-01-12', '2010-07-12'), 
(10000009, '923', 'Hendrerit St', '8', 'H4H3M5', 'Verdun', '514-688-5499', '2009-12-21', '2012-02-14', '2012-08-14'), 
(10000010, '4239', 'Commodo Rd', '13', 'H4L8K3', 'St-Laurent', '514-527-4770', '2011-08-02', '2012-03-04', '2012-09-04'); 


--
-- Dumping data for table `Client_Household`
--

INSERT IGNORE INTO `client_household` (`ClientID`, `HouseholdID`) VALUES
(1, 10000000),
(2, 10000001),
(3, 10000002),
(4, 10000003),
(5, 10000004),
(6, 10000005),
(7, 10000006),
(8, 10000007),
(9, 10000008),
(10, 10000009),
(11, 10000010);


--
-- Dumping data for table `Note`
--

INSERT IGNORE INTO `note` (`NoteID`, `NoteInfo`, `DateStamp`, `ModifiedBy`) VALUES
(1, 'magna sed dui. Fusce aliquam, enim nec tempus scelerisque, lorem ipsum sodales purus, in molestie','2012-02-24', 'M.M.'),
(2, 'Morbi accumsan laoreet ipsum.','2012-03-02', 'M.M.'),
(3, 'in sodales elit erat vitae risus. Duis a mi','2012-01-26', 'M.M.'),
(4, 'elit. Nulla facilisi. Sed neque. Sed eget','2012-01-27', 'M.M.'),
(5, 'tempor lorem, eget mollis lectus pede et risus. Quisque libero','2012-01-15', 'M.M.'),
(6, 'Sed malesuada augue ut lacus. Nulla tincidunt, neque vitae semper egestas, urna justo faucibus','2012-02-07', 'M.M.'),
(7, 'gravida molestie arcu. Sed eu nibh','2012-01-01', 'M.M.'),
(8, 'pede, malesuada vel,','2012-03-02', 'M.M.'),
(9, 'sem ut dolor dapibus gravida. Aliquam tincidunt, nunc ac mattis ornare, lectus ante dictum','2012-01-15', 'M.M.'),
(10, 'fringilla purus mauris a nunc. In at pede. Cras vulputate velit eu sem. Pellentesque ut','2012-02-14', 'M.M.'),
(11, 'pharetra, felis eget varius ultrices,','2012-02-13', 'M.M.'),
(12, 'risus, at fringilla purus mauris a nunc.','2012-02-17', 'M.M.'),
(13, 'ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Phasellus ornare. Fusce mollis.','2012-02-01', 'M.M.'),
(14, 'Phasellus nulla. Integer vulputate, risus a ultricies adipiscing, enim mi tempor lorem,','2012-02-19', 'M.M.'),
(15, 'Pellentesque habitant','2012-01-06', 'M.M.'),
(16, 'odio semper cursus. Integer mollis.','2012-02-03', 'M.M.'),
(17, 'Cras dictum ultricies ligula. Nullam enim. Sed nulla','2012-01-28', 'M.M.'),
(18, 'Integer mollis. Integer tincidunt aliquam arcu. Aliquam ultrices iaculis odio. Nam interdum enim non nisi.','2012-01-24', 'M.M.'),
(19, 'fringilla est. Mauris eu turpis. Nulla','2012-01-29', 'M.M.'),
(20, 'purus, accumsan interdum libero dui','2012-02-20', 'M.M.'),
(21, 'ac ipsum. Phasellus vitae mauris','2012-03-07', 'M.M.');
--
-- Dumping data for table `Household_Note`
--

INSERT IGNORE INTO `household_note` (`HouseholdID`, `NoteID`) VALUES
(10000000, 1),
(10000000, 2),
(10000000, 3),
(10000001, 4),
(10000002, 5),
(10000002, 6),
(10000003, 7),
(10000003, 8),
(10000004, 9),
(10000004, 10),
(10000005, 11),
(10000005, 12),
(10000005, 13),
(10000006, 14),
(10000007, 15),
(10000009, 16),
(10000009, 17),
(10000009, 18),
(10000009, 19),
(10000010, 20),
(10000010, 21);

--
-- Dumping data for table `FlagType`
--

INSERT IGNORE INTO `flagtype` (`FlagID`, `FlagTitle`, `FlagPriority`) VALUES

(1, 'User is banned', 'HIGH'),
(2, 'Information needs to be updated', 'HIGH');

--
-- Dumping data for table `Flag`
--

INSERT IGNORE INTO `flag` (`ID`, `FlagTypeID`, `FlagInfo`, `DateStamp`) VALUES
(1, 1, 'User did not show up to meeting XYZ. Reason not known yet.', '2012-03-09'),
(2, 2, 'User did not show up to meeting ABC.', '2012-03-10'),
(3, 1, 'It has been more than six months since the last record update.', '2012-03-11');


--
-- Dumping data for table `Household_Flag`
--

INSERT IGNORE INTO `household_flag` (`HouseholdID`, `FlagID`) VALUES

(10000000, 1),
(10000002, 2),
(10000002, 3);
