let $datos := doc("datos.xml")
return count($datos/datos/proyectos/proyecto[ciudad eq 'Londres'])
