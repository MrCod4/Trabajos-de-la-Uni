#include <stdio.h>
#include <string.h>
#include <windows.h>

typedef struct{
    char titulo[50];
    char autor[50];
    int anio;
}libros;

int main(){
    libros registro[5];

    for(int i=0;i<5;i++){
        printf("Ingrese el titulo del libro %d: ",i+1);
        fgets(registro[i].titulo, sizeof(registro[i].titulo), stdin);
        registro[i].titulo[strlen(registro[i].titulo) - 1] = '\0';
    }

    for(int i=0;i<5;i++){
        printf("Ingrese el autor del libro %d: ", i+1);
        fgets(registro[i].autor, sizeof(registro[i].autor), stdin);
        registro[i].autor[strlen(registro[i].autor) - 1] = '\0';
    }

    for(int i=0;i<5;i++){
        printf("Ingrese el anio de publicacion del libro %d: ", i+1);
        scanf("%d", &registro[i].anio);

        getchar();
    }

    FILE*r=fopen("registro.txt", "w");

    for(int i=0;i<5;i++){
        fprintf(r, "\n========= Libro %d ===========\n", i+1);
        fprintf(r, "\nTitulo de libro %d: %s", i+1, registro[i].titulo);
        fprintf(r, "\nAutor de libro %d: %s", i+1, registro[i].autor);
        fprintf(r, "\nAnio de publicacion del libro %d: %d", i+1, registro[i].anio);
    }

    fclose(r);

    int antiguo = registro[0].anio;
    int poss = 0;
    int contador = 0;
    char libroc[50];
    char autorc[50];

    for(int i=0;i<5;i++){
        if(registro[i].anio < antiguo){
            poss = i;
            antiguo = registro[i].anio;
        }
    }

    for(int i=0;i<5;i++){
        if(registro[i].anio > 2000){
            contador+=1;
        }
    }

    printf("\n--------------------------------------------------\n");
    printf("El libro mas antiguo es: %s", registro[poss].titulo);
    printf("\nEl autor del libro mas antiguo es: %s", registro[poss].autor);
    printf("\nAnioo de publicacion: %d", antiguo);
    printf("\n%d libros fueron publicados despues de los 2000", contador);

    printf("\nBuscador: ");
    fgets(libroc, sizeof(libroc), stdin);
    libroc[strlen(libroc) -1 ] = '\0';

    printf("\nLibros encontrados del autor %s: \n", autorc);

    for(int i=0;i<5;i++){
        if(strcmp(registro[i].autor, autorc) == 0){
            strcpy(libroc,registro[i].titulo);
            printf("%s\n", libroc);
        }
    }

    return 0;
}