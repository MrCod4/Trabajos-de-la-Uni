#include <stdio.h>
#include <string.h>
#include <stdbool.h>

int main(){

    FILE * A = fopen("T1.txt", "r");
    char c;
    int P = 0;
    int v = 0;
    bool np = false;

    if(A == NULL){
        printf("Error al abrir el archivo. \n");
        return 1;
    }

    while((c=fgetc(A))!= EOF){
        if(c != '\n' && c != ' ' && c != '\t'){
            if( !np ){
                P+=1;
                np = true;
            }
        }else{
            np = false;
        }

        if(
       c== 'A' || c== 'a'||
       c== 'E' || c== 'e'||
       c== 'I' || c== 'i'||
       c== 'O' || c== 'o'||
       c== 'U' || c== 'u'){

        v+=1;

       }
    }


    fclose(A);

    
    printf("Cantidad de palabras: %d\n", P);
    printf("Cantidad de vocales: %d\n", v);
    return 0;
}
