// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Insira a largura: ");
string larg = Console.ReadLine();
int largura = int.Parse(larg);

Console.WriteLine("Insira a altura: ");
string alt = Console.ReadLine();
int altura = int.Parse(alt);

Console.WriteLine("A área do triangulo é: " + (altura * largura));
*/


/*
Console.WriteLine("Insira o montante: R$");
string mont = Console.ReadLine();
float montante = float.Parse(mont);
0
float dolar = montante / 5.17f;
float euro = montante / 6.14f;
float pesoArgentino = montante / 0.05f;

Console.WriteLine("Conversão do montante: ");
Console.WriteLine($"Dolar: $ {dolar.ToString("0.00")}");
Console.WriteLine($"Euro: $ {euro.ToString("0.00")}");
Console.WriteLine($"Peso Argentino: {pesoArgentino.ToString("0.00")} ARS");
*/


/*
Console.WriteLine("Insira um número: ");
string numero1 = Console.ReadLine();
int num1 = int.Parse(numero1);

Console.WriteLine("Insira um número: ");
string numero2 = Console.ReadLine();
int num2 = int.Parse(numero2);

if(num1 > num2){
    Console.WriteLine("Maior número: " + num1 + "\nMenor número: " + num2);
}else{
    Console.WriteLine("Maior número: " + num2 + "\nMenor número: " + num1);
}
*/


/*
Console.WriteLine("Informe sua idade: ");
string idade = Console.ReadLine();
int idd = int.Parse(idade);

if(idd <= 13 && idd > 0){
    Console.WriteLine("Catarento detectado");
}else if(idd > 13 && idd <= 18){
    Console.WriteLine("Aborecente detectado");
}else if(idd > 18 && idd <= 60){
    Console.WriteLine("Adulto detectado");
}else if(idd > 60){
    Console.WriteLine("Idoso detectado");
}else if(idd < 0){
    Console.WriteLine("Idade invalida!!!");
    
    Console.WriteLine("Informe uma idade valida: ");
    string idade2 = Console.ReadLine();
    int idd2 = int.Parse(idade2);
    do
    {
        if(idd2 <= 13 && idd2 > 0){
            Console.WriteLine("Catarento detectado");
        }else if(idd2 > 13 && idd2 <= 18){
            Console.WriteLine("Aborecente detectado");
        }else if(idd2 > 18 && idd2 <= 60){
            Console.WriteLine("Adulto detectado");
        }else if(idd2 > 60){
            Console.WriteLine("Idoso detectado");
        } 
    }while (idd2 < 0);
}
*/


