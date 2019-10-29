SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre, COUNT(registro.valor)
FROM ((((tipo_registro
INNER JOIN registro ON registro.id_tipo_registro = tipo_registro.id_tipo_registro)
INNER JOIN pertenece ON pertenece.id_pertenece = registro.id_pertenece)
INNER JOIN usuario ON usuario.ci = pertenece.ci)
INNER JOIN rol ON rol.id_rol = usuario.id_rol)
WHERE tipo_registro.nom_registro = 'Inasistencia' AND rol.nombre_rol = 'Alumno/a'
GROUP BY usuario.ci
HAVING COUNT(registro.valor)
ORDER BY COUNT(registro.id_registro) DESC
LIMIT 10;