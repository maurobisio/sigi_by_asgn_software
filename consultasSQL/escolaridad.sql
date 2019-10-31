SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre, materia.nom_materia, grupo.nombre_grupo, AVG(registro.valor)
FROM (((((((tipo_registro
INNER JOIN registro ON registro.id_tipo_registro = tipo_registro.id_tipo_registro)
INNER JOIN pertenece ON pertenece.id_pertenece = registro.id_pertenece)
INNER JOIN usuario ON usuario.ci = pertenece.ci)
INNER JOIN rol ON rol.id_rol = usuario.id_rol)
INNER JOIN tiene ON pertenece.id_tiene = tiene.id_tiene)
INNER JOIN materia ON materia.id_materia = tiene.id_materia)
INNER JOIN grupo ON grupo.id_grupo = tiene.id_grupo)
WHERE tipo_registro.nom_registro = 'Calificación' AND rol.nombre_rol = 'Alumno/a' AND usuario.ci = '5'
GROUP BY pertenece.id_pertenece
HAVING AVG(registro.valor)