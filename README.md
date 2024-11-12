# Merge Two Sorted Arrays

## Descripción

Dado dos arrays ordenados de enteros positivos:

- Un array `A` de longitud `N`.
- Un array `B` de longitud `2N`, en el que los primeros `N` elementos están ocupados con números y los últimos `N` espacios están vacíos.

La tarea es escribir una función que fusione el array `A` en el array `B`, manteniendo `B` ordenado.

## Restricciones

- **Tiempo**: La solución debe tener un tiempo de ejecución proporcional a `O(N)` o mejor.
- **Espacio**: La solución debe usar un espacio proporcional a `O(1)`.

## Ejemplo

### Entrada:

A = [1, 7, 9]
B = [2, 4, 8, , , ]


### Resultado:

B (after merge) = [1, 2, 4, 7, 8, 9]
