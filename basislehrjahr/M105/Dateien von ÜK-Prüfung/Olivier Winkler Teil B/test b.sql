select count(*) from zutat;

select * from zutat where Zutat LIKE '%Zucker%';

select kuchen.Kuchen, kuchen.Beschreibung, kuchen.DauerInMinuten, rezept.Menge, einheit.Einheit, zutat.Zutat from rezept
inner join zutat on rezept.ZUTAT_ID = zutat.ID_Zutat
inner join einheit on rezept.Einheit_ID = einheit.ID_Einheit
inner join kuchen on rezept.Kuchen_ID = kuchen.ID_Kuchen where kuchen.Kuchen = 'Rüebli-Kuchen'; 

select  distinct kuchen.Kuchen AS 'Kuchen ohne Butter oder Margarine' from kuchen
inner join rezept on kuchen.ID_Kuchen = rezept.Kuchen_ID
inner join zutat on rezept.ZUTAT_ID = zutat.ID_Zutat where Zutat not like 'Butter' or 'Margarine';

select distinct kuchen.Kuchen AS 'Geburtstagskuchen' from kuchen_anlass
inner join kuchen on kuchen_anlass.Kuchen_ID = kuchen.ID_Kuchen
inner join anlass on kuchen_anlass.Anlass_ID;

select zutat.Zutat AS 'Menge', einheit.Einheit from rezept
inner join zutat on rezept.ZUTAT_ID = zutat.ID_Zutat
inner join einheit on rezept.Einheit_ID = einheit.ID_Einheit
inner join kuchen on rezept.Kuchen_ID = kuchen.ID_Kuchen 
where kuchen.Beschreibung like 'Mikrowellenkuchen';

select distinct kuchen.Kuchen as 'Kuchen mit Rahm' from rezept
inner join kuchen on rezept.Kuchen_ID = kuchen.ID_Kuchen
inner join zutat on rezept.ZUTAT_ID = zutat.ID_Zutat;

select count(rezept.ZUTAT_ID) AS 'Anzahl Zutaten'from rezept
inner join zutat on rezept.ZUTAT_ID
inner join kuchen on rezept.Kuchen_ID = kuchen.ID_Kuchen where kuchen.Kuchen = 'Zimtrollen-Kuchen';

select sum(kuchen.DauerInMinuten) AS 'Minuten'from rezept
inner join kuchen on rezept.Kuchen_ID = kuchen.ID_Kuchen
inner join zutat on rezept.ZUTAT_ID = zutat.ID_Zutat where zutat.Zutat Like 'Milch'; 

select zutat.ID_Zutat, rezept.ZUTAT_ID from zutat
inner join rezept on zutat.ID_Zutat = rezept.ZUTAT_ID where zutat.ID_Zutat != rezept.ZUTAT_ID;

select kuchen_anlass.Anlass_ID  AS 'Anlass', anlass.Anlass from kuchen_anlass
inner join kuchen on kuchen_anlass.Kuchen_ID = kuchen.ID_Kuchen
inner join anlass on kuchen_anlass.Anlass_ID = anlass.ID_Anlass 
group by anlass.Anlass
having count(kuchen_anlass.Anlass_ID);

select zutat.ID_Zutat AS 'Anzahl', zutat.Zutat AS 'Zutaten' from rezept
inner join zutat on rezept.ZUTAT_ID = zutat.ID_Zutat
inner join kuchen on rezept.Kuchen_ID = kuchen.ID_Kuchen 
where zutat.Zutat > 8
order by zutat.Zutat; 