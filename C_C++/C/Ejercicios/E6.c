#include <stdio.h>
#include <string.h>

int main(){

    char nombre[50];
    char b[50];
    char c[50];

    printf("Ingrese su nombre: ");
    fgets(nombre, sizeof(nombre), stdin);
    nombre[strlen(nombre)-1] = '\0';

    printf("Ingrese su nombre: ");
    fgets(b, sizeof(b), stdin);
    b[strlen(b)-1] = '\0';

    printf("Ingrese su nombre: ");
    fgets(c, sizeof(c), stdin);
    c[strlen(c)-1] = '\0';


    printf("Nombre 1: %s", nombre);
    printf("\nLargo del nombre: %d", strlen(nombre));

    printf("\nNombre 2: %s", b);
    printf("\nLargo del nombre: %d", strlen(b));

    printf("\nNombre 3: %s", c);
    printf("\nLargo del nombre: %d", strlen(c));

    if(strcmp(nombre, b) == 0 && strcmp(nombre, c) == 0){
        printf("\nlos nombres 3 son iguales");
    }else if(strcmp(nombre, b) == 0 || strcmp(nombre, c) == 0){
        printf("\nsolo 2 nombres son iguales");
    }else{
        printf("\nSon diferentes");
    }

    return 0;


}