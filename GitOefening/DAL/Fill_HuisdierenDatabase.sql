-- ===========================
-- Drop tables if exists
-- ===========================
DROP TABLE IF EXISTS DIER;
DROP TABLE IF EXISTS SOORT;
DROP TABLE IF EXISTS EIGENAAR;

-- ===========================
-- Create Tables EIGENAAR, 
--    SOORT & DIER
-- ===========================
CREATE TABLE EIGENAAR (
    eigenaarid INT PRIMARY KEY,
    naam VARCHAR(50),
    adres VARCHAR(100),
    woonplaats VARCHAR(50),
    telefoonnummer VARCHAR(20)
);

CREATE TABLE SOORT (
    soortid INT PRIMARY KEY,
    soort VARCHAR(50)
);

CREATE TABLE DIER (
    chipnr INT PRIMARY KEY,
    naam VARCHAR(50),
    eigenaar INT,
    heeftvacht BIT,
    geluid VARCHAR(50),
    aantalpoten INT,
    soortid INT,
    draagthoed BIT,
    heeftHuisje BIT,
    kanVliegen BIT,
    FOREIGN KEY (eigenaar) REFERENCES EIGENAAR(eigenaarid),
    FOREIGN KEY (soortid) REFERENCES SOORT(soortid)
);

-- ===========================
-- Insert EIGENAAR
-- ===========================

INSERT INTO EIGENAAR (eigenaarid, naam, adres, woonplaats, telefoonnummer)
VALUES
(1, 'Jan Jansen', 'Dorpsstraat 12', 'Utrecht', '0612345678'),
(2, 'Piet de Vries', 'Kerklaan 5', 'Amsterdam', '0623456789'),
(3, 'Sara Bakker', 'Lindelaan 22', 'Rotterdam', '0634567890'),
(4, 'Kees van Dam', 'Prinsenweg 7', 'Eindhoven', '0645678901'),
(5, 'Anna de Wit', 'Stationsplein 3', 'Groningen', '0656789012'),
(6, 'Mark de Jong', 'Herenstraat 8', 'Den Haag', '0667890123'),
(7, 'Sophie Mulder', 'Nieuweweg 19', 'Maastricht', '0678901234'),
(8, 'Tom Bakker', 'Lindenlaan 11', 'Nijmegen', '0689012345'),
(9, 'Eva Vos', 'Wilgenstraat 14', 'Leiden', '0690123456'),
(10, 'Lucas Meijer', 'Breestraat 21', 'Arnhem', '0601234567');

-- ===========================
-- 3️⃣ Insert SOORT
-- ===========================

INSERT INTO SOORT (soortid, soort)
VALUES
(1, 'Hond'),
(2, 'Kat'),
(3, 'Vogel'),
(4, 'Paard'),
(5, 'Vogelbekdier'),
(6, 'Slak'),
(7, 'Beer'),
(8, 'Vlinder'),
(9, 'Eekhoorn'),
(10, 'Kikker'),
(11, 'Dolfijn'),
(12, 'Schildpad'),
(13, 'Kangoeroe'),
(14, 'Octopus'),
(15, 'Papegaai');

-- ===========================
-- Insert DIER
-- ===========================

INSERT INTO DIER
(chipnr, naam, eigenaar, heeftvacht, geluid, aantalpoten, soortid, draagthoed, heeftHuisje, kanVliegen)
VALUES
(1001, 'Bello', 1, 1, 'Blaf', 4, 1, 0, 0, 0),
(1002, 'Minoes', 2, 1, 'Miauw', 4, 2, 0, 0, 0),
(1003, 'Tweety', 3, 0, 'Fluit', 2, 3, 1, 0, 1),
(1004, 'Storm', 6, 1, 'Hinnik', 4, 4, 0, 0, 0),
(1005, 'Fluffy', 2, 1, 'Miauw', 4, 2, 1, 0, 0),
(1006, 'Rex', 9, 1, 'Blaf', 4, 1, 1, 0, 0),
(1007, 'Coco', 3, 0, 'Fluit', 2, 3, 0, 0, 1),
(1008, 'Shadow', 9, 1, 'Blaf', 4, 1, 0, 0, 0),
(1009, 'Snow', 3, 1, 'Miauw', 4, 2, 0, 0, 0),
(1010, 'Goldie', 5, 0, 'Flap', 2, 3, 0, 0, 1),
(1011, 'Platy', 1, 1, 'Kwijt', 4, 5, 0, 0, 0),
(1012, 'Slakie', 9, 0, '', 0, 6, 0, 1, 0),
(1013, 'Baloo', 6, 1, 'Grom', 4, 7, 0, 0, 0),
(1014, 'Monarch', 2, 0, '', 6, 8, 0, 0, 1),
(1015, 'Kiwi', 1, 0, 'Kiwik', 2, 3, 0, 0, 0),
(1016, 'Thunder', 3, 1, 'Hinnik', 4, 4, 1, 0, 0),
(1017, 'Rafiki', 2, 1, 'Blaf', 4, 1, 0, 0, 0),
(1018, 'Lola', 3, 1, 'Miauw', 4, 2, 1, 0, 0),
(1019, 'Peaches', 1, 0, 'Flap', 2, 3, 0, 0, 1),
(1020, 'Aurora', 2, 1, 'Hinnik', 4, 4, 1, 0, 0),
(1021, 'Spike', 3, 1, 'Blaf', 4, 1, 0, 0, 0),
(1022, 'Misty', 5, 1, 'Miauw', 4, 2, 1, 0, 0),
(1023, 'Buttercup', 2, 0, '', 6, 8, 0, 0, 1),
(1024, 'Shelly', 3, 0, '', 0, 6, 0, 1, 0),
(1025, 'Panda', 1, 1, 'Grom', 4, 7, 0, 0, 0),
(1026, 'Platty Jr', 9, 1, 'Kwijt', 4, 5, 0, 0, 0),
(1027, 'Vinnie', 6, 1, 'Blaf', 4, 1, 0, 0, 0),
(1028, 'Shadowcat', 1, 1, 'Miauw', 4, 2, 1, 0, 0),
(1029, 'Robin', 2, 0, 'Flap', 2, 3, 0, 0, 1),
(1030, 'Comet', 3, 1, 'Hinnik', 4, 4, 0, 0, 0),
(1031, 'Slippy', 1, 0, '', 0, 6, 0, 1, 0),
(1032, 'Grizzly', 2, 1, 'Grom', 4, 7, 0, 0, 0),
(1033, 'Platy Senior', 3, 1, 'Kwijt', 4, 5, 0, 0, 0),
(1034, 'Lily', 1, 0, '', 6, 8, 0, 0, 1),
(1035, 'Snappy', 2, 1, 'Blaf', 4, 1, 1, 0, 0),
(1036, 'Cinder', 3, 1, 'Miauw', 4, 2, 0, 0, 0),
(1037, 'Goldwing', 6, 0, '', 2, 3, 0, 0, 1),
(1038, 'Blizzard', 2, 1, 'Hinnik', 4, 4, 1, 0, 0),
(1039, 'Turbo', 3, 0, '', 0, 6, 0, 1, 0),
(1040, 'Kodiak', 10, 1, 'Grom', 4, 7, 0, 0, 0),
(1041, 'Platypus Max', 2, 1, 'Kwijt', 4, 5, 0, 0, 0),
(1042, 'Flutter', 3, 0, '', 6, 8, 0, 0, 1),
(1043, 'Fido', 5, 1, 'Blaf', 4, 1, 0, 0, 0),
(1044, 'Whiskers', 2, 1, 'Miauw', 4, 2, 0, 0, 0),
(1045, 'Skylar', 3, 0, 'Flap', 2, 3, 1, 0, 1),
(1046, 'Spirit Jr', 1, 1, 'Hinnik', 4, 4, 0, 0, 0),
(1047, 'Slither', 2, 0, '', 0, 6, 0, 1, 0),
(1048, 'Bearington', 3, 1, 'Grom', 4, 7, 0, 0, 0),
(1049, 'Platypus Rex', 1, 1, 'Kwijt', 4, 5, 0, 0, 0),
(1050, 'Monarch II', 2, 0, '', 6, 8, 0, 0, 1),
(1051, 'Sparky', 9, 1, 'Blaf', 4, 1, 0, 0, 0),
(1052, 'Whisk', 5, 1, 'Miauw', 4, 2, 0, 0, 0),
(1053, 'Chirpy', 6, 0, 'Flap', 2, 3, 1, 0, 1),
(1054, 'Shadowfax', 7, 1, 'Hinnik', 4, 4, 1, 0, 0),
(1055, 'Percy', 8, 1, 'Kwijt', 4, 5, 0, 0, 0),
(1056, 'Snaily', 9, 0, '', 0, 6, 0, 1, 0),
(1057, 'Grizzly Jr', 10, 1, 'Grom', 4, 7, 0, 0, 0),
(1058, 'Butterfly', 1, 0, '', 6, 8, 0, 0, 1),
(1059, 'Squirry', 5, 1, 'Tsjilp', 4, 9, 0, 0, 0),
(1060, 'Hoppy', 6, 0, 'Kwaak', 4, 10, 0, 0, 0);
