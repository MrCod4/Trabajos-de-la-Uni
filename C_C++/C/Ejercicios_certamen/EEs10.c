//9. Inversión de un vector
//Crea una función que reciba un vector y su tamaño, y que invierta el orden de sus elementos de forma in situ.
//Requisitos:
//- Utilizar un bucle que recorra el vector desde ambos extremos, intercambiando elementos mediante índices.
//- Imprimir el vector antes y después de la inversión

#include <stdio.h>
#define max 100

void inversion(int n,int v[max]){
    for(int i=(n-1);i>=0;i--){
        printf("[%d] ", v[i]);
    }
}

int main(){

    int num;

    printf("Ingrese cuantos datos quiere en el vector: ");
    scanf("%d", &num);

    int vector[max];

    for(int pene=0;pene<num;pene++){
        printf("\nIngrese el dato numero %d del vector: ", pene+1);
        scanf("%d", &vector[pene]);
    }

    printf("\n-----Vectores-----\n");
    printf("Valores de el vector : \n");

    for(int pene=0;pene<num;pene++){
        printf("[%d] ", vector[pene]);
    }

    printf("\nValores invertidos del vector: \n");

    inversion(num, vector);

    return 0;
}