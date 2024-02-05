let $datos := doc("datos.xml")
for $proyecto in $datos/datos/proyectos/proyecto[ciudad eq 'Paris']
where some $suministro in $datos/datos/suministros/suministra
      satisfies ($suministro/numproyecto eq $proyecto/@numproyecto and $suministro/cantidad > 350)
return $proyecto/nombreproyecto/text()