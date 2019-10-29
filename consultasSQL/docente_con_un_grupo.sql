SELECT usuario.ci, usuario.primer_nombre, usuario.segundo_nombre
FROM ((pertenece
INNER JOIN usuario ON usuario.ci = pertenece.ci)
INNER JOIN rol ON rol.id_rol = usuario.id_rol)
WHERE rol.nombre_rol = 'Docente'
GROUP BY usuario.ci
HAVING COUNT(pertenece.id_pertenece) = 1;