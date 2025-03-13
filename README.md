## Instrucciones

1. clonar repositorio: `git clone https://github.com/Nicolasdawson/softserve.projectlab.git `
2. hacer checkout de la rama asignada para la semana, por ej `git checkout -b semana-1 origin/semana-1`
3. crear una rama con la semana y el nombre, por ej `git switch -c semana-1/juanito`
4. abrir el proyecto y buscar la palabra clave "TODO", habran instruncciones y ejemplos para hacer los ejercicios.
5. una vez que los ejercicios esten listos. `git push -u origin semana-1/juanito`
6. tambien pueden hacer un PR de la rama para poder revisarla:

* ir al repositorio https://github.com/Nicolasdawson/softserve.projectlab}
* clickear en Pull Requests
* New pull request
* aca como base tienen que seleccionar su rama y compare main

para que esto sea iterativo, van a tener que tomar la rama en la que estan trabajando y hacer merge con la rama de la nueva semana por ej

git checkout -b semana-1 semana-1/juanito

git merge semana-2

antes de hacer merge siempre asegurense de estar en su rama. si quieren usar sourcetree o github desktop no hay problema, para mi algo visual es mucho mejor, pero es importante que sepan que hace cada comando.

## Contexto

La idea de este projecto es crear un sistema de ventas, vamos a tener un `Package` donde vamos a almacenar la venta (piensen en los datos que se muestran en un checkout), lo principal es poder crear el cliente, poder agregar items a la venta y poder cambiar de estado el package una vez completado. Como es un proyecto para el portafolio mientras mas cosas le pueden agregar mejor, por ej customer tiene LineOfCredit, podemos crear un servicio donde mandamos el RUT o CURP y nos responde si el usuario tiene una linea de credito disponible, podemos hacer que el catalogo sea configurable, etc.
