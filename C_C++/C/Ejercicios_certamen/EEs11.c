//Crea funciones de multiplicacion, division, suma y resta entre matrices.

#include <stdio.h>
#define max 100

void suma(int f, int c, int v[max][max], int w[max][max], int srmd[max][max]){
    for(int i=0;i<f;i++){
        for(int j=0;j<c;j++){
            srmd[i][j] = v[i][j] + w[i][j]; 
        }
    }
}

void resta(int f, int c, int v[max][max], int w[max][max], int srmd[max][max]){
    for(int i=0;i<f;i++){
        for(int j=0;j<c;j++){
            srmd[i][j] = v[i][j] - w[i][j]; 
        }
    }
}

void mult(int f, int c, int v[max][max], int w[max][max], int srmd[max][max]){
    for(int i=0;i<f;i++){
        for(int j=0;j<c;j++){
            srmd[i][j] = v[i][j] * w[i][j]; 
        }
    }
}

void div(int f, int c, int v[max][max], int w[max][max], int srmd[max][max]){
    for(int i=0;i<f;i++){
        for(int j=0;j<c;j++){
            srmd[i][j] = v[i][j] / w[i][j]; 
        }
    }
}

void imprimirM(int f, int c, int v[max][max]){
    for(int i=0;i<f;i++){
        for(int j=0;j<c;j++){
            printf("[%d]", v[i][j]); 
        }
        printf("\n");
    }
}




int main(){
    int filas;
    int col;
    int desicion;

    printf("Ingrese la cantidad de filas que desea: ");
    scanf("%d", &filas);

    printf("\nIngrese la cantidad de columnas que desea: ");
    scanf("%d", &col);

    int matriz1[max][max];
    int matriz2[max][max];
    int matR[max][max];

    for(int i=0;i<filas;i++){
        for(int j=0;j<col;j++){
            printf("\nIngrese el dato de la matriz 1 en la pocicion [%d][%d]: ", i+1, j+1);
            scanf("%d", &matriz1[i][j]);
        }
    }

    
    for(int i=0;i<filas;i++){
        for(int j=0;j<col;j++){
            printf("\nIngrese el dato de la matriz 2 en la pocicion [%d][%d]: ", i+1, j+1);
            scanf("%d", &matriz2[i][j]);
        }
    }

    do {

    printf("\n-----Desicion-----\n");
    printf("Debe elegir un numero: \n");
    printf("1. Para suma\n");
    printf("2. Para resta\n");
    printf("3. Para multiplicacion\n");
    printf("4. Para divicion\n");
    printf("Ingrese el numero de su decicion: ");
    scanf("%d", &desicion);

    if(desicion < 1 || desicion > 4){
        printf("Porfavor ingrese un valor valido");
    }

    }while(desicion < 1 || desicion > 4);

    switch(desicion){
        case 1:
        suma(filas, col, matriz1, matriz2, matR);
        break;
        case 2:
        resta(filas, col, matriz1, matriz2, matR);
        break;
        case 3:
        mult(filas, col, matriz1, matriz2, matR);
        break;
        case 4:
        div(filas, col, matriz1, matriz2, matR);
        break;
    }

    printf("\n-----Matrices-----\n");

    printf("Matriz 1: \n");
    imprimirM(filas, col, matriz1);

    printf("Matriz 1: \n");
    imprimirM(filas, col, matriz2);

    printf("Matriz Resultante: \n");
    imprimirM(filas, col, matR);

    return 0;
}


