 


create table Person (
PersonID integer(11) primary key auto_increment not null,
Namen varchar (50)
);

create table Funktion (
FunktionID integer(11) primary key auto_increment not null,
Bezeichnung varchar(50)
);

create table Genre (
GenreID integer(11) primary key auto_increment not null,
Bezeichnung varchar(50)
);

create table Originalsprache (
SpracheID integer(11) primary key auto_increment not null,
Originalsprache varchar(50)
);

create table Film (
FilmID integer(11) primary key auto_increment not null,
Filmname varchar(50),
Erscheinungsdatum date,
Laufzeit time,
Budget decimal,
SpracheID integer(11),
constraint FK_SpracheID foreign key (SpracheID) references originalsprache(SpracheID),
GenreID integer(11),
constraint FK_GenreID foreign key (GenreID) references Genre (GenreID)
);

create table PersonFunktion (
FilmID integer(11),
constraint FK_FilmID foreign key (FilmID) references Film (FilmID),
FunktionID integer(11),
constraint FK_FunktionID foreign key (FunktionID) references Funktion (FunktionID),
PersonID integer(11),
constraint FK_PersonID foreign key (PersonID) references Person (PersonID)
);
