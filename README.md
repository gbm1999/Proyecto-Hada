# Proyecto-Hada

# 1. Propuesta del proyecto
En un primer momento, y entre todas las opciones disponibles, nuestra decisión fue la de crear
una página de compra-venta de artículos. De esta forma podríamos aprender multitud de
aspectos del desarrollo web, como pueden ser el manejo de usuarios y el control de objetos en
una base de datos entre otros.
Una vez aclarado el proyecto nos pusimos manos a la obra, y comenzamos a diseñar una base
de datos, cosa que consideramos de lo más esencial en este proyecto, y el manejo de múltiples
ENCAD que iban a ser necesarios en el proyecto.
Aunque con el tiempo se han ido modificando los aspectos del proyecto.
# 2. Vistas y Desarrollo de todos los integrantes
A continuación se detallan el desarrollo de cada uno de los integrantes del grupo con sus
palabras, con la intención de que se reflejen el flujo de trabajo, problemas y opinión de cada
desarrollador por separado.
# Daniel Domenech:
“ En la primera fase del proyecto a penas participé, simplemente tuve parte en la propuesta
grupal y en las primeras reuniones. A partir de la primera entrega me puse con 2 vistas de la
página web, en concreto las vistas de profile y monedero, aunque también revisé los aspectos
de otras vistas. Ya en la tercera entrega hubo que implementar las funcionalidades de la
página web, desde esta fase mi compañero Francisco y yo tuvimos que tomar las riendas del
proyecto, pues estábamos muy mal organizados y no conseguíamos avanzar. Tras organizar el
trabajo de cada integrante y tener una reunión conseguimos encauzar un poco el proyecto, sin
embargo surgieron los problemas, tras terminar la parte que me correspondía de las
funcionalidades ( Login, Register, Encriptación y redes sociales ), tuve que ponerme con otras
partes de la página web y errores que iban surgiendo, dado que algunos compañeros no
conseguían avanzar por ellos mismos y el proyecto no se entregaba a tiempo.
Por el resto en cuanto a desarrollo no he tenido demasiados problemas, me ha parecido super
interesante el desarrollo web y me he quedado con las ganas de aprender algunos otros
aspectos como posicionamiento web o JavaScript, aunque me hubiese gustado que el proyecto
quedase mejor, estoy contento con el resultado. Aunque no tanto con cómo ha evolucionado
el grupo de trabajo, si no fuese por el sobreesfuerzo de algunos miembros del grupo, no
hubiésemos conseguido sacar esta práctica adelante.
Me gustaría destacar que el mayor problema de todos no ha sido ninguno con el desarrollo, si
no que conforme avanzaba la práctica el grupo estaba más perdido, no fue hasta que Francisco
y yo nos pusimos a dirigir el proyecto que la cosa empezó a seguir hacia delante. Por lo general
la actitud de Germán ha dejado bastante que desear, no queriendo hacer su trabajo (de hecho
no ha hecho su función de coordinador en todo el proyecto) y poniendo escusas.“
# Jorge Belló:
En el reparto de funciones, yo tuve la parte de ShowArticle, donde se muestran los detalles de
un artículo cuando haces click sobre él en la vista de Artículos. Tras añadir todas las
funcionalidades ( que se muestre la información de artículo en los textboxes designados )
implementé el botón de modificar, que recoge los datos intercambiados en los textboxes y
edita el artículo en la base de datos. Para terminar, he añadido el botón Borrar, que permite
eliminar un artículo y actualizar la Base de datos, al borrarse, la página te redirige a la vista
anterior de Artículos.Para poder pulsar estos botones es necesario estar logueado y ser el
creador del artículo.
Los principales problemas a la hora del desarrollo que he tenido han sido dos, el primero de
ellos ha sido cómo pasar de la vista de Artículos a la del artículo concreto, es decir , recoger la
información necesaria para buscar el artículo en la Base de Datos, tras un tiempo investigando
y con la ayuda de algunos de mis compañeros conseguimos solucionarlo con un QueryString.
Por último, a la hora de modificar el artículo tuve un problema y es que los métodos no me
recogían los datos nuevos modificados, si no los antiguos, pero tras bastante tiempo
investigando conseguí arreglarlo haciendo que no se recargase la página.
# Izan Ayllón:
Por mi parte, me he encargado de todo lo relacionado con la base de datos, tanto del diseño como las modificaciones posteriores conforme se iban necesitando según las nuevas especificaciones del proyecto. Por otro lado, me encargué de la vista de Monedero, y tras añadir toda la funcionalidad, tuvimos que añadir alguna manera para no permitir acceder a esta vista si no eres un usuario que ha iniciado sesión, para esto investigué e implementé PopUp con Ajax, de esta manera podía comprobar si el usuario estaba Iniciado Sesión para no permitirle la entrada de una forma más estética que simplemente redirigirle. Por último, en la última fase de la entrega no se me asignaron tareas, sin embargo tal y como pasaba el tiempo
se iban necesitando modificaciones y arreglos de fallos, así que he ido modificando o creando
ENCAD nuevos que eran necesarios (como Administrados / Moderador) junto a sus
funcionalidades y otros aspectos que se iban necesitando sobre la marcha. También he
rellenado bastantes cosas de la base de datos, ya que con lo que añadió mi compañero se
quedaba muy vacía.
Francisco Arena:
Durante la Última entrega he realizado la implementación de la creación de categorías, la vista
de todas las categorías con un ListView de la base de datos y la vista de categoría concreta,
además he realizado cambios en el diseño en muchas otras vistas, realicé la presentación y la
realización„ de varios css, de realizar la internacionalización de la pagina web.
# Germán Berná:
En artículos se han añadido distintas funcionalidades. Ahora cuando se busca una artículo por
su nombre aparecerán todos los artículos que tengan en común la palabra que se ha buscado.
Además se han añadido que se muestren los artículos recientemente creados para mostrar los
artículos más recientes a la venta. Varias dificultades que se han encontrado han sido para
mostrar los artículos en cada página según corresponda por el número de página, al final se ha
optado por hacer un pequeño algoritmo que se encargará de esta función. Este algoritmo
consiste en mostrar los 12 articulos correspondientes que se calculan mediante una variable
Session[“count”] y además se recorre cada ImageButton mediante un findControl que buscará
dentro del placeContent correspondiente.
Profile
Para el perfil del usuario hemos realizado diversos cambios. Uno de ellos es poder introducir y
mostrar la imagen del usuario. Además podemos modificar los datos con validación de datos
para email(se introduce email con sus carácteres), contraseña(está dentro del rango y utiliza
los caracteres necesarios) y para edad(introduce un numero).
Además ahora consta de una sección donde podrá ver los artículos que oferta.
Problemas que hemos encontrado ha sido para poder mostrar la imagen y cargarla hicimos
varias conversiones y al final pudimos solucionarlo.
Problemas que hemos tenido entre nuestro equipo ha sido la comunicación entre los
integrantes pero al final hemos sabido organizarnos y hemos podido llevar todas las tareas
propuestas para cada intregante a cabo con éxito.
# 3. Sobre las Actas
Sólo la última de las reuniones ha sido documentada, ya que hasta dicha reunión el antiguo
coordinador no documentó ninguna, esta última fue documentada por Daniel y está adjuntada
junto a esta documentación
