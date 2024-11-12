# Merge Two Sorted Arrays

## Descripci�n

Dado dos arrays ordenados de enteros positivos:

- Un array `A` de longitud `N`.
- Un array `B` de longitud `2N`, en el que los primeros `N` elementos est�n ocupados con n�meros y los �ltimos `N` espacios est�n vac�os.

La tarea es escribir una funci�n que fusione el array `A` en el array `B`, manteniendo `B` ordenado.

## Restricciones

- **Tiempo**: La soluci�n debe tener un tiempo de ejecuci�n proporcional a `O(N)` o mejor.
- **Espacio**: La soluci�n debe usar un espacio proporcional a `O(1)`.

## Ejemplo

### Entrada:

A = [1, 7, 9]
B = [2, 4, 8, , , ]


### Entrada:

B (after merge) = [1, 2, 4, 7, 8, 9]
