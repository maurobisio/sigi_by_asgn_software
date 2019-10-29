SELECT tipo_incidencia.id_tipo_incidencia, tipo_incidencia.nom_tipo, COUNT(incidencia.id_incidencia)
FROM (incidencia
INNER JOIN tipo_incidencia ON tipo_incidencia.id_tipo_incidencia = incidencia.id_tipo_incidencia)
WHERE YEAR(incidencia.fecha) = '2019'
GROUP BY tipo_incidencia.id_tipo_incidencia
HAVING COUNT(incidencia.id_incidencia)