SELECT  kunstgegenstand.KunstgegenstandID, kunstgegenstand.Bezeichnung, MIN(kunstgegenstand.Veröffentlichung) AS 'Ältestes Kunstwerk' FROM kunstgegenstand
INNER JOIN ausstellungenkunstgegenstand ON kunstgegenstand.KunstgegenstandID = ausstellungenkunstgegenstand.KunstgegenstandID
INNER JOIN ausstellungen ON ausstellungenkunstgegenstand.AusstellungenID = ausstellungen.AusstellungenID
GROUP BY Bezeichnung
having count(ausstellungenkunstgegenstand.KunstgegenstandID) >= 2
ORDER BY Veröffentlichung limit 1;















