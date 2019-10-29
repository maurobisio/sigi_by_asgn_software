SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre, AVG(registro.valor)
FROM ((((tipo_registro
INNER JOIN registro ON registro.id_tipo_registro = tipo_registro.id_tipo_registro)
INNER JOIN pertenece ON pertenece.id_pertenece = registro.id_pertenece)
INNER JOIN usuario ON usuario.ci = pertenece.ci)
INNER JOIN rol ON rol.id_rol = usuario.id_rol)
WHERE tipo_registro.nom_registro = 'Calificación' AND rol.nombre_rol = 'Alumno/a'
GROUP BY usuario.ci
HAVING AVG(registro.valor)
ORDER BY AVG(registro.valor) DESC
LIMIT 10;