//1. Suma de elementos de un vector
//Escribe una función que reciba un vector de enteros y su tamaño, y retorne la suma de todos sus elementos.
//Requisitos:
//- Recorrer el vector utilizando índices.
//- Invocar la función desde main() y mostrar el resultado.

#include <stdio.h>

int sumaVector(int v[],int n){

    int suma = 0;

    for(int i=0;i<n;i++){
        suma += v[i];
    }

    return suma;
}

int main(){

    int t;
    int resultado = 0;

    printf("Ingrese la cantidad de datos que que quiere sumar: ");
    scanf("%d", &t);

    int vector[t];

    for(int i=0;i<t;i++){
        printf("\nIngrese el dato numero %d: ", i+1);
        scanf("%d", &vector[i]);
    }

    resultado = sumaVector(vector, t);

    printf("\nEl resultado de la suma es : %d", resultado);

    return 0;
}
