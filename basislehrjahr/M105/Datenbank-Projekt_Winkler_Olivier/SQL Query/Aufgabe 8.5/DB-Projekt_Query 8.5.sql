SELECT * FROM museum;
SELECT * FROM ausstellungen;
SELECT * FROM ausstellungenkunstgegenstand;

SELECT museum.Namen, COUNT(ausstellungenkunstgegenstand.KunstgegenstandID) AS 'Die meisten Kunstgegenstände'FROM museum
INNER JOIN ausstellungen ON museum.MuseumsID = ausstellungen.MuseumsID
INNER JOIN ausstellungenkunstgegenstand ON ausstellungen.AusstellungenID = ausstellungenkunstgegenstand.AusstellungenID
GROUP BY museum.Namen; 

