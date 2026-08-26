#include <stdio.h>
#include <string.h>

int main(){

    FILE*A=fopen("Ev.txt", "r");
    FILE*B=fopen("Ev2.txt", "w");

    char texto1[100];
    char texto;

   

    for(int i=0;i<100;i++){
        while((texto = fgetc(A))!=EOF){
           if(texto == 'a' || texto == 'A'){
            texto = 'X';
           }
           texto1[i] = texto;
        }
    }

    fprintf(B,"%s", texto1);


    fclose(A);
    fclose(B);
    return 0;
}