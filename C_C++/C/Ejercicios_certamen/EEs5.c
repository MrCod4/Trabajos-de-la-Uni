#include <stdio.h>


void mult(int a[2][2], int b[2][2], int c[2][2]){

    for(int i=0;i<2;i++){
        for(int j=0;j<2;j++){
            c[i][j] = 0;
            for(int k=0;k<2;k++){
                c[i][j] = a[i][k] * b[k][j];
            }
        }
    }
}

int main(){

    int a[2][2];
    int b[2][2];
    int resultado[2][2];

    for(int i=0;i<2;i++){
        for(int j=0;j<2;j++){
            printf("\nIngrese el dato de la matriz A en la posicion [%d][%d]: ", i+1,j+1);
            scanf("%d",&a[i][j]);
        }
    }

    for(int i=0;i<2;i++){
        for(int j=0;j<2;j++){
            printf("\nIngrese el dato de la matriz B en la posicion [%d][%d]: ", i+1,j+1);
            scanf("%d",&b[i][j]);
        }
    }

    mult(a,b,resultado);

    printf("\nMatriz A:\n");
    for(int i=0;i<2;i++){
        for(int j=0;j<2;j++){
            printf("[%d]",a[i][j]);
        }
        printf("\n");
    }

    printf("\nMatriz B:\n");
    for(int i=0;i<2;i++){
        for(int j=0;j<2;j++){
            printf("[%d]",b[i][j]);
        }
        printf("\n");
    }

    printf("\nResultado de multiplicacion:\n");
    for(int i=0;i<2;i++){
        for(int j=0;j<2;j++){
            printf("[%d]",resultado[i][j]);
        }
        printf("\n");
    }




    
}