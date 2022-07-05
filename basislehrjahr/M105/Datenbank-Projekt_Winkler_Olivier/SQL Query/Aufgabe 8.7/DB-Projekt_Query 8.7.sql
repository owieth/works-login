SELECT Vorname, Nachname, SUM(datediff(ausstellungen.Enddatum, ausstellungen.Anfangsdatum)) AS 'Ausstellungsdauer in Tagen'FROM kuenstler
INNER JOIN kunstgegenstand ON kuenstler.KuenstlerID = kunstgegenstand.KuenstlerID
INNER JOIN ausstellungenkunstgegenstand ON kunstgegenstand.KunstgegenstandID = ausstellungenkunstgegenstand.KunstgegenstandID
INNER JOIN ausstellungen ON ausstellungenkunstgegenstand.AusstellungenID = ausstellungen.AusstellungenID
group by Nachname;