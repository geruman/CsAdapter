# Adapter
Es un patr�n estructural. [Link descripci�n](https://sourcemaking.com/design_patterns/adapter)

El objetivo de un adapter es proveer a una clase cliente de una interfaz conocida con una implementaci�n de la interfaz que "envuelva" la funcionalidad de una clase para la que el cliente no esta preparado para usar, de esta forma la clase "adaptador" implementa la interfaz conocida y realiza las operaciones necesarias para que el cliente pueda interactuar con la clase desconocida.

## Diagrama de clases
![UML](adapter.jpg)

## SOLID

* Single responsability

Un adapter tiene una sola responsabilidad, la de convertir las llamadas de la interfaz hacia las llamadas de la clase cliente.

* Open/Close principle

Si se necesita nueva funcionalidad entonces puede perfectamente extenderse un adapter o crear uno nuevo que implemente la interfaz conocida por el cliente y de esta manera extender la funcionalidad original.

* Liskov substitution principle

Cualquier implementaci�n de la interfaz conocida por el cliente debe comportarse correctamente, no hay raz�n para creer que este principio se rompa por el uso del patr�n.

* Interface segregation

Adapter se acopla bien al uso de este principio ya que las interfaces deber�an ser reducidas a un tipo de operaci�n (una sola responsabilidad), si observamos que se est� incumpliendo probablemente sea en la definici�n de la interfaz raiz del arbol de herencia y necesitemos refactorizar esa interfaz.

* Dependency inversi�n

El cliente deber�a esperar una interfaz, no una clase concreta, por lo que este principio se cumple. La clase adaptador debe estar bien dise�ada y probablemente hacer uso de dependency inversi�n para que se cumpla completamente este principio.