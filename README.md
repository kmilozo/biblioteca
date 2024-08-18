El propósito de mi proyecto es faciltar la gestión de libros de la biblioteca del TECOC lo hice con Windows forms c# y lo organicé asi: 
Se hizo dependencias una de ellas es la carpeta llamada controlllers (controladores) en donde hay clases independientes en las cuales desde ellas se las va hacer consultas a una base de datos conectada al proyecto en la cual se conectó en la clase principal ConectionController.cs, además también para las demás dependencias que se llaman modelo de datos (models) y formularios (forms) tienen sus respectivos controladores.
Sigo con la dependencia que es otra carpeta llamada modelos de datos (models) en donde hay clases en las cuales único que tenemos es la definición de tipos de datos para cada modelo de datos y finalmente paso a la última dependencia la cual son los formularios en donde en cada uno de ellos se hace uso de todos los métodos necesarios para que el aplicativo sea funcional en todo. Ya finalmente lo de la implementación de los principios solid están implementos en todo el proyecto, pero el que más se resalta es el de responsabilidad única los cual se ven en las dependencias las cuales son llamadas Controllers y Models las cual cuales cada una tiene sus respectivas clases.

Los Principios SOLID tienen cinco principios de diseño de clases Orientado a Objetos. Son un conjunto de reglas y mejores prácticas a seguir al diseñar una estructura de clase.
Estos cinco principios nos ayudan a comprender la necesidad de ciertos patrones de diseño y arquitectura de software en general y son:
1.	El Principio de responsabilidad única (Single Responsibility Principle)
El Principio de Responsabilidad Única dice que una clase debe hacer una cosa y, por lo tanto, debe tener una sola razón para cambiar.
2.	El Principio Abierto-Cerrado (Open-Closed Principle)
El principio de apertura y cierre exige que las clases deban estar abiertas a la extensión y cerradas a la modificación.
3.	El Principio de sustitución de Liskov (Liskov Substitution Principle)
El Principio de Sustitución de Liskov establece que las subclases deben ser sustituibles por sus clases base.
4.	El Principio de segregación de interfaz (Interface Segregation Principle)
La segregación significa mantener las cosas separadas, y el Principio de Segregación de Interfaces se trata de separar las interfaces.
5.	El Principio de inversión de dependencia (Dependency Inversion Principle)
El principio de inversión de dependencia establece que nuestras clases deben depender de interfaces o clases abstractas en lugar de clases y funciones concretas.





