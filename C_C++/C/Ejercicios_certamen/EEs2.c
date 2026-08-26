#include <stdio.h>
#include <stdbool.h>
#include <string.h>

bool EsAprovado(float nota){
    return nota >= 4.0;
}

int main(){

    int n;
    char nombre[50] = "";

    printf("Porfavor ingrese su nombre: ");
    fgets(nombre, sizeof(nombre), stdin);
    nombre[strlen(nombre) - 1] = '\0';

    printf("Hola %s Ingrese la cantidad de notas: ", nombre);
    scanf("%d", &n);

    float notasa[n];
    float promedio;
    float suma = 0;
    int totalA = 0;


    for(int i = 0; i < n; i++){

        do{
            printf("Insete la nota de la asignatura %d: ", i+1);
            scanf("%f", &notasa[i]);

            if(notasa[i] > 7.0 || notasa[i] < 1.0){
                printf("Porfavor ingrese una nota valida (1.0 - 7.0)\n");
            }

        }while(notasa[i] > 7.0 || notasa[i] < 1.0);
        
        if(EsAprovado(notasa[i])){
            printf("Asignatura %d: APROBADA\n", i+1);
            totalA += 1;
        }else{
            printf("Asignatura %d: REPROBADA\n", i+1);
        }

        suma += notasa[i];


    }

    promedio = suma/n;

    printf("\n--------------------------------\n");
    printf("\nNotas aprobadas: %d", totalA);
    printf("\nAsignaturas reprobadas: %d", n - totalA);
    printf("\nPromedio de asignaturas: %.1f", promedio);

    if(EsAprovado(promedio)){
        printf("\n%s Has pasado de curso", nombre);
    }else{
        printf("\n%s eres un SACOWEA", nombre);
    }

    return 0;


}