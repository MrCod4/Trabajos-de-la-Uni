#include <stdio.h>
#include <string.h>


int main(){
    char nombre[50];

    printf("Ingrese su nombre: ");
    fgets(nombre, sizeof(nombre), stdin);
    nombre[strlen(nombre) - 1] = '\0';

    printf("\nSu nombre tiene %d caracteres", strlen(nombre));

    printf("\n---------------------------------\n");

    char copia[50];
    strcpy(copia, nombre);

    printf("\nNombre copia: %s", copia);
    printf("\nEl nombre copia tiene %d caracteres.", strlen(copia));


    return 0;

}