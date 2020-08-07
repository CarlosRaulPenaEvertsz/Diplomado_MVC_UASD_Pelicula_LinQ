# Diplomado_MVC_UASD_Pelicula_LinQ  (Tarea 2-5 Parte primera)

Tarea 2-5:

Los errores encontrados y acciones tomadas, en el ejemplo de la tarea 2-5 fueron los siguientes:

1) Como el campo de duracion se necesitaba punto decimal en algunos caso, 
   se sustituyo de datatype int por double.

2) En la primera parte del ejemplo se omitió retornar el objeto "peliculas" en return View(). Por esta
   situación, los datos no eran recibidos por la view que lista las peliculas. Se resolvió tan pronto
   se le agregó el parametro de retorno.

3) En el ejemplo no indicaba desplegar el titulo asignado a la variable ViewBag.Title.
   Se le coloco como titulo del tab(<title>), asi como encabezado (<h1>).

