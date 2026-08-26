#include <stdio.h>
#include <string.h>

int main(){
    //Para escribir en un archivo:

    FILE *pfile = fopen("Testo.txt","w");
    char texto[]= "Pene pene, escroto pene";

    if(pfile == NULL){
        printf("Error al abrir el archivo. \n");
        return 1;
    }

    fprintf(pfile, "%s", texto);

    printf("\nSe escribio en el archibo correctamente.\n");

    fclose(pfile);

    return 0;
}