#include <stdio.h>

void MinMax(int v[], int n, int *min, int *max){

    *max = v[0];
    *min = v[0];

    for(int i=1;i<n;i++){
        if(v[i] < *min){
            *min = v[i];
        }
        if(v[i] > *max){
            *max = v[i];
        }
    }
}

int main(){

    int tamano;

    printf("Ingrese la cantidad de datos: ");
    scanf("%d", &tamano);

    int vector[tamano];

    for(int i=0;i<tamano;i++){
        printf("Ingrese el dato numero %d: ", i+1);
        scanf("%d", &vector[i]);
    }

    int maximo = 0, minimo = 0;

    MinMax(vector, tamano, &minimo, &maximo);

    printf("\nEl valor minimo es: %d", minimo);
    printf("\nEl valor maximo es: %d", maximo);

    return 0;
}