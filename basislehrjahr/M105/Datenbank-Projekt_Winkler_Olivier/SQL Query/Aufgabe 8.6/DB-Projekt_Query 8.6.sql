SELECT ausstellungen.Titel, COUNT(kunstgegenstand.Bezeichnung) AS 'Kunstgegenstände' FROM ausstellungen
INNER JOIN ausstellungenkunstgegenstand ON ausstellungen.AusstellungenID = ausstellungenkunstgegenstand.AusstellungenID
INNER JOIN kunstgegenstand ON ausstellungenkunstgegenstand.KunstgegenstandID = kunstgegenstand.KunstgegenstandID
group by ausstellungen.Titel;