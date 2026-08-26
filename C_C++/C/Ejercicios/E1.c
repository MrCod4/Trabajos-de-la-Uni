#include <stdio.h>

int main(){

    int n;

    printf("Cuantas Notas va a promediar?");
    scanf("%d", &n);

    float notas[n];
    float suma, promedio;

    for(int i = 0; i < n; i++){

        do{

        printf("Ingresa la nota %d: ", i+1);
        scanf("%f", &notas[i]);

         if (notas[i] > 7.0 || notas[i] < 1.0 ) {
            printf("Porfavor Ingrese una nota valida\n");
         }

        }while(notas[i] > 7.0 || notas[i] < 1.0 );

        suma = suma + notas[i];
    }

    promedio = suma/n;
    
    printf("\n--- Resultados ---\n");

    if(promedio >= 4.0){
        printf("Usted aprobo con nota %.2f", promedio);
    }else{
        printf("Usted reprobo con nota %.2f", promedio);
    }

    return 0;

}