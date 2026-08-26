//8. Operaciones con matrices: suma y resta
//Escribe dos funciones: una que realice la suma y otra que realice la resta de dos matrices de las mismas
//dimensiones.
//Requisitos:
//- Representar las matrices mediante arreglos bidimensionales.
//- Recorrer las matrices usando índices para efectuar la operación.
//- Mostrar los resultados en main().

#include <stdio.h>
#define MAX 100

void suma(int f, int c, int v[MAX][MAX],int w[MAX][MAX], int sr[MAX][MAX]){

    for(int i=0;i<f;i++){
        for(int j=0;j<c;j++){

            sr[i][j] = v[i][j] + w[i][j];

        }
    }

}

void resta(int f, int c, int v[MAX][MAX],int w[MAX][MAX], int sr[MAX][MAX]){

    for(int i=0;i<f;i++){
        for(int j=0;j<c;j++){

            sr[i][j] = v[i][j] - w[i][j];

        }
    }

}

int main(){
    int fila, col;

    printf("Ingrese el numero de filas que desea: ");
    scanf("%d", &fila);

    printf("\nIngrese el numero de columnas que desea: ");
    scanf("%d", &col);

    //Es nesesario poner en los datos de la matriz #define MAX 100, porque sino esa mamada jode, no se porque xd

    int vectorA[MAX][MAX];
    int vectorB[MAX][MAX];
    int sumaresta[MAX][MAX];
    int desicion;

    for(int i=0;i<fila;i++){
        for(int j=0;j<col;j++){
            printf("\nIngrese el dato del vector A en la pocicion [%d][%d]: ", i+1 , j+1);
            scanf("%d", &vectorA[i][j]);
        }
    }

    for(int i=0;i<fila;i++){
        for(int j=0;j<col;j++){
            printf("\nIngrese el dato del vector B en la pocicion [%d][%d]: ", i+1 , j+1);
            scanf("%d", &vectorB[i][j]);
        }
    }

    do{

    printf("\n---Desicion---\n");
    printf("\n1.Para Suma");
    printf("\n2.Para resta\n");
    printf("\nIngrese la operacion que quiere hacer: ");
    scanf("%d", &desicion);

    if(desicion == 1){
        suma(fila, col, vectorA, vectorB, sumaresta);
    }
    if(desicion == 2){
        resta(fila, col, vectorA, vectorB, sumaresta);
    }
    else{
        printf("\nEse no pendejo\n");
    }

    }while(desicion > 2 || desicion < 1);


    printf("\n----Tablas----\n");
    printf("Vector A: \n");
    for(int i=0;i<fila;i++){
        for(int j=0;j<col;j++){
            printf("[%d]", vectorA[i][j]);
        }
        printf("\n");
    }

    printf("\nVector B: \n");
    for(int i=0;i<fila;i++){
        for(int j=0;j<col;j++){
            printf("[%d]", vectorB[i][j]);
        }
        printf("\n");
    }

    printf("Resultado de la operacion seleccionada: \n");
    for(int i=0;i<fila;i++){
        for(int j=0;j<col;j++){
            printf("[%d]", sumaresta[i][j]);
        }
        printf("\n");
    }

    return 0;
}