#include <stdio.h> 
#include <stdlib.h>
#include <string.h>


int main(){
	char txt[80]= "hola",txt2[30];
	
	
	gets(txt2);// gets obtiene un string
							//atof convierte string a flotane
	if (strcmp(txt,txt2) ==0){
		//sprintf(variablestring,"texto",variables);
		sprintf(txt,"La palabra introducida es correcta");	//sprintf, guarda texto y variables
															//en un string
		printf("%s",txt);//imprime
	
	} else{
		
		sprintf(txt,"La palabra introducida es incorrecta");	//sprintf, guarda texto y variables
															//en un string
		printf("%s",txt);//imprime
	}
	
	
	
}
		

