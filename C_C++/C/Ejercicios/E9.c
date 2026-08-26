#include <stdio.h>
#include <string.h>

int main(){

    FILE*f=fopen("datos.txt", "r"); 

    char texto[100];

    fgets(texto, sizeof(texto), f);

    printf("Datos del [datos.txt]: %s", texto);
    printf("\nCaracteres del texto: %d", strlen(texto));

    fclose(f);

    return 0;
}