SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre
FROM ((grupo
INNER JOIN tiene ON tiene.id_grupo = grupo.id_grupo)
INNER JOIN pertenece ON pertenece.id_tiene = tiene.id_tiene)
INNER JOIN usuario ON usuario.ci = pertenece.ci
INNER JOIN rol ON rol.id_rol = usuario.id_rol
WHERE rol.nombre_rol = 'Alumno/a'
GROUP BY usuario.ci
HAVING COUNT(grupo.id_grupo) > 1;