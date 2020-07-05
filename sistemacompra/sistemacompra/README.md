# sistemacompras
Sistema para la compra y pago de productos

# Errores Comunes y Soluciones
1.- No existe Framework Bonifu
2.- Configurar la base de datos
3.- Agregar Forms nuevos

# Soluciones
1.-En la carpeta Dependencias  podras encontrar Bunifu_UI_v1.5.3.dll  esta libreria se utiliza para el 
diseño UI del proyecto, para solucionar el problema 
En el Explorador de Soluciones da  vlick con el segundo boton del raton en Referencias
elegir Agregar Referencia 
da click en Examinar e ingresa a la carpeta Dependencias Selecciona Bunifu_UI_v1.5.3.dll  y da click en Aceptar

2.- En la carpeta existe el script SQLServer_purchases.sql el cual funciona con Microsoft Sql Server
3.- En la carpeta vista existen Forms Nuevos, Padres, Secundarios  los cuales contienen un patron de diseño
Para crear un nuevo formulario da click con el segundo boton del raton en alguna carpeta  en el explorador de Soluciones 
Elige la opcion agregar //Elemento Existente
Entra a la carpeta vista 
y luego la carpeta frmNuevos o frmPadres  dependiendo a que modelo de formulario quieras usar
elige el formulario que quieras  con la extension .cs 
