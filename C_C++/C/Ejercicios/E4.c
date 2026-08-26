#include <stdio.h>

int main(){
    int ma[3][3];
    int dia = 0;

    for(int i = 0; i < 3; i++){
        for(int j = 0; j < 3; j++){
            printf("Ingrese la pocicion [%d][%d] la matriz: \n", i,j);
            scanf("%d", &ma[i][j]);
        }
    }

    for(int i = 0; i < 3; i++){
        dia += ma[i][i];
    }

    printf("La suma de la diagonal principal es: %d\n", dia);

    

}

