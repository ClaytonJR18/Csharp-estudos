/* 

int[] numeros = new int[4]; //{0, 0, 0, 0}

Console.WriteLine(numeros[1]);

numeros[0] = 69;
numeros[1] = 19;
numeros[2] = 18;
numeros[3] = 14;

Console.WriteLine(numeros[0]);

for (int i = 0; i < 4; i++)
{
    Console.WriteLine(numeros[i]);
}

*/

//------------------------------------------------------------------------------------------------

/* 

string[] linguagens = new string[5] {"C#","Java","Python","C++","Go"};

foreach (string linguagem in linguagens)
{
    if(linguagem == "C#")
    {
        Console.WriteLine("minha linguagem favorita: " + linguagem);
    }
    else
    {
        Console.WriteLine(linguagem);
    }
    
}

*/


//---------------------------------------------------------------------------------------------------

/*
 
int[,] matriz = new int[4, 2] { {69,30}, {96,157}, {33,777}, {10,19 } };

//Console.WriteLine(matriz[0,1]);

matriz[0, 1] = 69;

//Console.WriteLine(matriz[0,1]);

foreach (int i in matriz)
{
    Console.WriteLine(i);
}

*/


//----------------------------------------------------------------------------------------


/*

object[,] pessoas = new object[4, 3] { { "Clayton", 19, "Taubaté"},
                                       { "Maria", 19, "Taubaté"},
                                       { "Fulano", 17, "Caçapava"},
                                       { "Ciclano", 20, "Pindamonhangaba"} 
};

for(int linha = 0; linha <4 ; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        Console.WriteLine(pessoas[linha, coluna]);
    } 
}

*/

//--------------------------------------------------------------------------

/*
List<string> linguagens = new List<string>();

linguagens.Add("Java");
linguagens.Add("C#");
linguagens.Add("Python");
linguagens.Add("Go"); 
linguagens.Add("JavaScript");
linguagens.Add("Cobol");

linguagens.RemoveAt(2);

// Testar os métodos na lista

foreach (string s in linguagens)
{
    Console.WriteLine(s);
}
*/

//--------------------------------------------------------------------------


/*
Dictionary<int,string> alunos = new Dictionary<int,string>();

alunos.Add(1, "Clayton");
alunos.Add(2, "Maria");
alunos.Add(3, "João");


foreach(KeyValuePair<int, string> aluno in alunos)
{
    Console.WriteLine("chave = {0}, valor = {1} ", aluno.Key, aluno.Value);
}
*/

//-------------------------------------------------------------------------------------------------

int numero1 = 10;

int numero2 = 2;

int resultado = 0;

try
{
    resultado = numero1 / numero2;
    Console.WriteLine("{0} / {1} = {2}", numero1, numero2, resultado);
    throw new Exception("ERRO TESTE");
}
catch (Exception ex)
{
    Console.WriteLine("ERRO: {0}", ex.Message);
    Console.WriteLine("TIPO: {0}", ex.GetType());
}
finally
{
    Console.WriteLine("FINALLY!");
}











