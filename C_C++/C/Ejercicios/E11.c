#include <stdio.h>
#include <string.h>
    
int main(){    
    //Para leer archivos:

    FILE *pfile = fopen("Testo.txt","r");

    char buffer[1024] = {0};

    if(pfile == NULL){
        printf("Error al abrir el archivo. \n");
        return 1;
    }

    while(fgets(buffer, sizeof(buffer), pfile) != NULL){
        printf("%s", buffer);
    }

    fclose(pfile);
    return 0;
}