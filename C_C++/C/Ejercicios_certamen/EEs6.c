//4. Transpuesta de una matriz
//Crea una función que reciba una matriz (arreglo bidimensional) y sus dimensiones (filas y columnas) y retorne otra
//matriz que sea su transpuesta.
//Requisitos:
//- Emplear bucles con índices para recorrer la matriz.
//- Imprimir la matriz original y la transpuesta en main().

#include <stdio.h> 
#define max 100

void trans(int f, int c, int v[max][max], int t[max][max]){

    for(int i=0;i<f;i++){
        for(int j=0;j<c;j++){
            t[j][i] = v[i][j];
        }
    }

}

void Imprimir(int f, int c, int v[max][max]){

    for(int i=0;i<f;i++){
        for(int j=0;j<c;j++){
            printf("[%d]", v[i][j]);
        }
        printf("\n");
    }

}

int main(){

    int fila, col;

    printf("ingrese su cantidad de filas: ");
    scanf("%d", &fila);

    printf("Ingrese su cantidad de columnas: ");
    scanf("%d", &col);

    int m[max][max];
    int t[max][max];

    for(int i=0;i<fila;i++){
        for(int j=0;j<col;j++){
            printf("\nIngrese el el dato de la matriz [%d][%d]: ", i+1, j+1);
            scanf("%d", &m[i][j]);
        }
    }

    trans(fila, col, m, t);

    printf("Datos de la matriz: \n");

    Imprimir(fila, col, m);

    printf("Datos de la matriz trans: \n");

    Imprimir(fila, col, t);


    return 0;
}

