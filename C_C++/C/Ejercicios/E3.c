#include <stdio.h>

int main(){

    int n;

    printf("Cuantas variables quires: \n");
    scanf("%d", &n);

    int num[n];
    int totalp = 0;

    for(int i = 0; i < n; i++){

        printf("\ningrese el elemento numero %d: ", i + 1);
        scanf("%d", &num[i]);

        if(num[i] % 2 == 0){
            printf("\nEl numero %d es par\n", i + 1);
            totalp += 1;
        }else{
            printf("\nEl numero %d es impar\n", i + 1);
        }
    }

    printf("\nTotal de numeros Pares: %d", totalp);
    printf("\nTotal de numeros Impares: %d", n - totalp);

    return 0;
}