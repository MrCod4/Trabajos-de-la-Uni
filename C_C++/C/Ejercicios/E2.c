#include <stdio.h>

int main(){

    int filas[2][2], colum[2][2], suma[2][2];

    for(int i = 0; i < 2; i++){
        for(int j = 0; j < 2; j++){
            printf("Filas[%d][%d]: ", i, j);
            scanf("%d", &filas[i][j]);
        }
    }

    for(int i = 0; i < 2; i++){
        for(int j = 0; j < 2; j++){
            printf("colum[%d][%d]: ", i, j);
            scanf("%d", &colum[i][j]);
        }
    }

    printf("\nMatriz resultante (fila + culumna): \n");
    for(int i = 0; i < 2; i++){
        for(int j = 0; j < 2; j++){
            suma[i][j] = filas[i][j] + colum[i][j];

            printf("%d\t", suma[i][j]);
        }
        printf("\n");
    }
    
    return 0;
}