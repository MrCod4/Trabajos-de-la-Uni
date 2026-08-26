#include <stdio.h>

int main(){

    int v[8];

    for(int i=0;i<8;i++){
        printf("\nIngrese Pos[%d]", i+1);
        scanf("%d", &v[i]);
    }

    printf("Vector invertido: \n");

    for(int i=7;i>=0;i--){
        printf("[%d]", v[i]);
    }
}