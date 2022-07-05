SELECT * FROM kuenstler;
SELECT * FROM kunstgegenstand;

SELECT KunstgegenstandID, Bezeichnung, kuenstler.KuenstlerID FROM uebung_museum.kunstgegenstand
INNER JOIN uebung_museum.kuenstler ON uebung_museum.kunstgegenstand.KuenstlerID = uebung_museum.kuenstler.KuenstlerID WHERE uebung_museum.kuenstler.Vorname = 'Olivier';