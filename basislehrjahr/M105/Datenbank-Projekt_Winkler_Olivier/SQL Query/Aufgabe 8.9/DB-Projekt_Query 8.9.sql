SELECT kunstgegenstand.Bezeichnung, museum.Namen FROM kunstgegenstand
INNER JOIN ausstellungenkunstgegenstand ON kunstgegenstand.KunstgegenstandID = ausstellungenkunstgegenstand.KunstgegenstandID
INNER JOIN ausstellungen ON ausstellungen.AusstellungenID = ausstellungenkunstgegenstand.AusstellungenID
INNER JOIN museum ON ausstellungen.MuseumsID = museum.MuseumsID WHERE Namen != 'Museum.BL';