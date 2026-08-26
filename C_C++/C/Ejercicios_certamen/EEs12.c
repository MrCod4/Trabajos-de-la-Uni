#include <stdio.h>
#include <windows.h>
#define maximo 100

typedef struct{
    char nombrep[50];
    int codigop;
    float preciop;
}productos;

int main(){

    int n;

    printf("Cuantos productos hay en el archivo? : ");
    scanf("%d",&n);

    productos lista[maximo];
    FILE*p=fopen("Productos.txt","r");
    int contador = 0;
    float ptotal = 0.0;

    if(p != NULL){
        printf("El archivo ha sido abierto correctamenrte\n");
    }
    else{
        perror("Error al abrir el archivo");
        return 1;
    }

    while(contador < n && fscanf(p, "%s %d %f", 
          lista[contador].nombrep, 
          &lista[contador].codigop, 
          &lista[contador].preciop) == 3){

            ptotal += lista[contador].preciop;
            contador++;
          }

    fclose(p);

    printf("Procesando los datos, espere unos segundos......");
    Sleep(5000);
    printf("\n====== Inventario cargado ======\n");
    printf("%-20s %-10s %-10s\n","Producto" , "Codigo" , "Precio");
    printf("\n====================================================\n");

    for(int i=0;i<n;i++){
        printf("%-20s %-10d %-10.2f\n", lista[i].nombrep, lista[i].codigop, lista[i].preciop);
    }

    printf("\n=====================================================\n");
    printf("Total de productos cargados: %d\n", contador);
    printf("Total a pagar: $%.2f", ptotal);


    return 0;
}

