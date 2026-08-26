#include <stdio.h>
#include <string.h>
#include <windows.h>

typedef struct{
    char nombre[50];
    int edad;
    float promedio;
}alumnos;

int main(){

    alumnos Clase1[5];

    for(int i=0;i<5;i++){
        printf("\nIngrese el nombre del anlumno %d: ", i+1);
        fgets(Clase1[i].nombre, sizeof(Clase1[i].nombre), stdin);
        Clase1[i].nombre[strlen(Clase1[i].nombre)-1] = '\0';
    }

    printf("Cargando los datos espere...\n");

    Sleep(2000);

    printf("Archibos cargados correctamente\n");

    printf("\n------------------------------------------------\n");

    for(int i=0;i<5;i++){

        printf("\nIngrese la edad del alumno %s: ", Clase1[i].nombre);
        scanf("%d", &Clase1[i].edad);

        printf("\nIngrese el promedio del alumno %s: ", Clase1[i].nombre);
        scanf("%f", &Clase1[i].promedio);
    }

    printf("Cargando los datos espere...\n");

    Sleep(2000);

    printf("Archibos cargados correctamente\n");

    printf("\n----------------------------------------------------------\n");

    printf("%-20s %-10s %-10s\n","Nombre","Edad","Promedio");

    for(int i=0;i<5;i++){
        printf("%-20s %-10d %-10.2f\n", Clase1[i].nombre, Clase1[i].edad, Clase1[i].promedio);
    }

    

    return 0;

}