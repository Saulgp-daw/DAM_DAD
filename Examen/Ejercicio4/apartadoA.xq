declare variable $datos external;

for $proveedor in $datos/datos/proveedores/proveedor[estado > 15]
return $proveedor/ciudad