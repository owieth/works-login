SELECT art.Namen, SUM(datediff(ausstellungen.Enddatum, ausstellungen.Anfangsdatum)) AS 'Ausstellungsdauer' FROM art
INNER JOIN kunstgegenstand ON art.ArtID = kunstgegenstand.ArtID
INNER JOIN ausstellungenkunstgegenstand ON kunstgegenstand.KunstgegenstandID = ausstellungenkunstgegenstand.KunstgegenstandID
INNER JOIN ausstellungen ON ausstellungenkunstgegenstand.AusstellungenID = ausstellungen.AusstellungenID
group by art.Namen;