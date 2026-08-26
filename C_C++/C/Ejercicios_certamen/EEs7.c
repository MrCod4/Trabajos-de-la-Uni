//5. Factorial recursivo
//Escribe una función recursiva que calcule y retorne el factorial de un número entero.
//Requisitos:
//- Utilizar recursión con un caso base y llamadas sucesivas.
//- Invocar la función desde main() y mostrar el resultado

#include <stdio.h>

int Factorial(int n){
    if(n == 0 || n == 1){
        return 1;
    }
    else{
        return n * Factorial(n - 1);
    }
}

int main(){

    int num, factorial;

    printf("Ingrese su numero: ");
    scanf("%d", &num);

    factorial = Factorial(num);

    printf("El factorial de %d es: %d", num, factorial);


}