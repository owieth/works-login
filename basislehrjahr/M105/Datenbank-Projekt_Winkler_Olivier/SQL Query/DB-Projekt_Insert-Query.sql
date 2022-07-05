load data local infile
'C:/CSV/DB-Projekt_Museum.csv'
INTO Table uebung_museum.museum
fields terminated by ';' ;

load data local infile
'C:/CSV/DB-Projekt_Art.csv'
INTO Table uebung_museum.art
fields terminated by ';' ;

load data local infile
'C:/CSV/DB-Projekt_Kuenstler.csv'
INTO Table uebung_museum.kuenstler
fields terminated by ';' ;

load data local infile
'C:/CSV/DB-Projekt_Kunstgegenstand.csv'
INTO Table uebung_museum.kunstgegenstand
fields terminated by ';' ;

load data local infile
'C:/CSV/DB-Projekt_Ausstellung.csv'
INTO Table uebung_museum.ausstellungen
fields terminated by ';' ;

load data local infile
'C:/Users/olivier.winkler/Desktop/DB-Projekt_AusstellungenKunstgegenstand.csv'
INTO Table uebung_museum.ausstellungenkunstgegenstand
fields terminated by ';' ;