SELECT * FROM uebung_museum.museum; #Namen
SELECT * FROM uebung_museum.ausstellungen; #Titel
SELECT * FROM uebung_museum.kunstgegenstand; #Count Anzahl Gegenstände mit Gemälde pro Ausstellung

SELECT museum.Namen, ausstellungen.Titel, COUNT(kunstgegenstand.KunstgegenstandID) AS 'Anzahl Kunstgegenstände' from museum
INNER JOIN ausstellungen ON museum.MuseumsID = ausstellungen.MuseumsID
INNER JOIN ausstellungenkunstgegenstand ON ausstellungen.AusstellungenID = ausstellungenkunstgegenstand.AusstellungenID
INNER JOIN kunstgegenstand ON ausstellungenkunstgegenstand.KunstgegenstandID = kunstgegenstand.KunstgegenstandID
WHERE kunstgegenstand.ArtID = 2
group by museum.Namen
order by kunstgegenstand.KunstgegenstandID desc;