## Onion Architecture

## ¿Qué es Onion Architecture?
La mayoría de las arquitecturas tradicionales plantean cuestiones fundamentales de acoplamiento estrecho y separación de preocupaciones. Onion Architecture fue introducido por Jeffrey Palermo para proporcionar una mejor manera de construir aplicaciones en perspectiva de una mejor teestabilidad, mantenibilidad y confiabilidad. Onion Architecture aborda los desafíos que enfrentan las arquitecturas de 3 y n niveles, y proporciona una solución para problemas comunes. Las capas de arquitectura Onion interactúan entre sí mediante las interfaces. Los programadores de C# se sienten atraídos por Onion Architecture debido a los flujos de dependencia.

## Principios
Onion Architecture se basa en el principio de inversión de control. Onion Architecture se compone de múltiples capas concéntricas que interactúan entre sí hacia el núcleo que representa el dominio. La arquitectura no depende de la capa de datos como en las arquitecturas clásicas de varios niveles, sino de los modelos de dominio reales.

## ¿Cuáles son algunos problemas con onion architecture?
Según la arquitectura tradicional, la capa de interfaz de usuario interactúa con la lógica empresarial, y la lógica empresarial habla con la capa de datos, y todas las capas se mezclan y dependen en gran medida unas de otras. En arquitecturas de 3 y n niveles, ninguna de las capas es independiente; este hecho plantea una separación de preocupaciones. Tales sistemas son muy difíciles de entender y mantener. El inconveniente de esta arquitectura tradicional es el acoplamiento innecesario.

![image](https://user-images.githubusercontent.com/60909590/191528169-81241866-ee89-409c-a5b9-aff640f5c338.png)

Onion Architecture resolvió estos problemas definiendo capas desde el núcleo hasta la infraestructura. Aplica la regla fundamental moviendo todo el acoplamiento hacia el centro. Esta arquitectura está indudablemente sesgada hacia la programación orientada a objetos, y pone los objetos antes que todos los demás. En el centro de Onion Architecture se encuentra el modelo de dominio, que representa los objetos de negocio y comportamiento. Alrededor de la capa de dominio hay otras capas, con más comportamientos.

## ¿Cuáles son las capas de la arquitectura Onion?
Onion Architecture utiliza el concepto de capas, pero son diferentes de las capas de arquitectura de 3 y n niveles. Veamos qué representa y debe contener cada una de estas capas.

## Capa de dominio
En la parte central de la arquitectura Onion, existe la capa de dominio; esta capa representa los objetos de negocio y comportamiento. La idea es tener todos los objetos de tu dominio en este núcleo. Contiene todos los objetos de dominio de aplicación. Además de los objetos de dominio, también podría tener interfaces de dominio. Estas entidades de dominio no tienen ninguna dependencia. Los objetos de dominio también son planos como deberían ser, sin ningún código pesado o dependencias.

## Capa de repositorio
Esta capa crea una abstracción entre las entidades de dominio y la lógica empresarial de una aplicación. En esta capa, normalmente agregamos interfaces que proporcionan un comportamiento de guardado y recuperación de objetos normalmente al involucrar una base de datos. Esta capa consiste en el patrón de acceso a datos, que es un enfoque más flexible para el acceso a los datos. También creamos un repositorio genérico y agregamos consultas para recuperar datos del origen, asignar los datos del origen de datos a una entidad empresarial y persistir los cambios en la entidad empresarial al origen de datos.

## Capa de servicios
La capa Servicio contiene interfaces con operaciones comunes, como Agregar, Guardar, Editar y Eliminar. Además, esta capa se utiliza para comunicarse entre la capa de interfaz de usuario y la capa de repositorio. La capa de servicio también podría contener lógica empresarial para una entidad. En esta capa, las interfaces de servicio se mantienen separadas de su implementación, teniendo en cuenta el acoplamiento suelto y la separación de preocupaciones.

## Capa de interfaz de usuario
Es la capa más externa y mantiene las preocupaciones periféricas como la interfaz de usuario y las pruebas. Para una aplicación web, representa la API web o el proyecto de prueba unitaria. Esta capa tiene una implementación del principio de inyección de dependencias para que la aplicación construya una estructura poco acoplada y pueda comunicarse con la capa interna a través de interfaces.

## Implementación de Onion Architecture
Las directrices de Onion Architecture no proporcionan ninguna dirección sobre cómo se deben implementar las capas. El arquitecto debe decidir la implementación y es libre de elegir cualquier nivel de clase, paquete, módulo o cualquier otra cosa que se requiera agregar a la solución.

## Beneficios e inconvenientes de la arquitectura Onion
Los siguientes son los beneficios de implementar Onion Architecture:

Las capas de Onion Architecture están conectadas a través de interfaces. Los implantes se proporcionan durante el tiempo de ejecución.
La arquitectura de la aplicación se basa en un modelo de dominio.
Todas las dependencias externas, como el acceso a la base de datos y las llamadas a servicios, se representan en capas externas.
No hay dependencias de la capa interna con capas externas.
Los acoplamientos son hacia el centro.
Arquitectura flexible y sostenible y portátil.
No es necesario crear proyectos comunes y compartidos.
Se puede probar rápidamente porque el núcleo de la aplicación no depende de nada.
Algunos inconvenientes de Onion Architecture de la siguiente manera:

No es fácil de entender para los principiantes, la curva de aprendizaje implica. Los arquitectos en su mayoría se equivocan dividiendo las responsabilidades entre capas.
Interfaces muy utilizadas

## Conclusión
Onion Architecture es ampliamente aceptado en la industria. Es muy poderoso y está estrechamente relacionado con otros dos estilos arquitectónicos: capas y hexagonales. Onion Architecture es más atractivo para los programadores de C# que para los programadores de Java. Sin embargo, depende de la comunidad de arquitectos considerar y argumentar en la discusión sobre si aplicar o no la arquitectura.


## Fuente
https://www.codeguru.com/csharp/understanding-onion-architecture/
