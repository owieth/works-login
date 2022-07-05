load data local infile
'C:/Users/olivier.winkler/Desktop/CSV-Dateien/Person.csv'
into table person
fields terminated by ';';

load data local infile
'C:/Users/olivier.winkler/Desktop/CSV-Dateien/Funktion.csv'
into table funktion
fields terminated by ';';

load data local infile
'C:/Users/olivier.winkler/Desktop/CSV-Dateien/Genre.csv'
into table genre
fields terminated by ';';


load data local infile
'C:/Users/olivier.winkler/Desktop/CSV-Dateien/Originalsprache.csv'
into table originalsprache
fields terminated by ';';

load data local infile
'C:/Users/olivier.winkler/Desktop/CSV-Dateien/Film.csv'
into table film
fields terminated by ';';

load data local infile
'C:/Users/olivier.winkler/Desktop/CSV-Dateien/Person und Funktion.csv'
into table personfunktion
fields terminated by ';';
