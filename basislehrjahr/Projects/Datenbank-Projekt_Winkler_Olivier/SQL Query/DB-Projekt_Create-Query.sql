CREATE Table Museum (
MuseumsID integer(50) primary key auto_increment NOT NULL, 
Namen varchar(50), 
Strasse varchar(50), 
PLZ integer, 
Ortschaft varchar(50),
Budget decimal
);

CREATE Table Ausstellungen (
AusstellungenID integer(50) primary key auto_increment NOT NULL,
Titel varchar(50),
Anfangsdatum date,
Enddatum date,
MuseumsID integer,
CONSTRAINT FK_MuseumsID foreign key (MuseumsID) REFERENCES Museum (MuseumsID)
);

CREATE Table Kuenstler (
KuenstlerID integer(50) primary key auto_increment NOT NULL,
Vorname varchar(50),
Nachname varchar(50)
);

CREATE Table Art (
ArtID integer(50) primary key auto_increment NOT NULL,
Namen varchar(50)
);

CREATE Table Kunstgegenstand (
KunstgegenstandID integer(50) primary key auto_increment NOT NULL,
Bezeichnung varchar(50),
Fertigstellung date,
KuenstlerID integer,
CONSTRAINT FK_KuenstlerID foreign key (KuenstlerID) REFERENCES Kuenstler (KuenstlerID),
ArtID integer,
CONSTRAINT FK_ArtID foreign key (ArtID) REFERENCES Art (ArtID)
);

CREATE Table AusstellungenKunstgegenstand (
AusstellungenID integer,
CONSTRAINT FK_AusstellungenID foreign key (AusstellungenID) references ausstellungen (AusstellungenID),
KunstgegenstandID integer,
constraint FK_KunstgegenstandID foreign key (KunstgegenstandID) references kunstgegenstand (KunstgegenstandID)
);
