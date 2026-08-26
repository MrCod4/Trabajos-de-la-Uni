//6. Copia de un vector
//Desarrolla una función que copie el contenido de un vector a otro.
//Requisitos:
//- Recorrer el vector original mediante índices y asignar cada elemento al vector destino.
//- Mostrar ambos vectores en main() para verificar la copia.


#include <stdio.h>

void copy(int t, int v[t], int c[t]){
    for(int i=0;i<t;i++){
        c[i] = v[i];
    }
}

int main(){

    int tamano;

    printf("Ingrese la cantidad de datos que quiere: ");
    scanf("%d", &tamano);

    int vector[tamano];
    int copia[tamano];

    for(int i=0;i<tamano;i++){
        printf("\nIngrese el valor %d del vector: ", i+1);
        scanf("%d", &vector[i]);
    }

    copy(tamano, vector, copia);

    printf("\n-----Vectores-----\n");
    printf("Vector normal:\n");

    for(int i=0;i<tamano;i++){
        printf("[%d] ", vector[i]);
    }

    printf("\nVector copia:\n");

    for(int i=0;i<tamano;i++){
        printf("[%d] ", copia[i]);
    }

    return 0;
}