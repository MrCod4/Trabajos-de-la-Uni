#include <stdio.h>
#include <string.h>
#include <ctype.h>

int main(){
    char n1[50];
    char n2[50];

    printf("Ingrese su nombre: ");
    fgets(n1, sizeof(n1), stdin);
    n1[strlen(n1) - 1] = '\0';

    strcpy(n2, n1);

    printf("\nNombre: %s", n1);
    printf("\nLargo: %d", strlen(n1));
    printf("\nNombre copia: %s\n", n2);

    for(size_t i=0;i<strlen(n1);i++){
        n1[i] = (char) toupper((unsigned char) n1[i]);
        printf("[%u]: %c\n",i+1, n1[i]);
    }

    return 0;
}