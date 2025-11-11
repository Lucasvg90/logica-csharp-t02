using static System.Console;

int a = 25;
int b = 29;

bool maiorQue = a > b;
bool menorQue = a < b;
bool ingual = a == b;
bool diferente = a != b;

WriteLine($"{a} é maior do que {b}? {maiorQue}\n" +
$"{a} é menor do que {b}? {menorQue}\n" +
$"{a} é ingual a {b}? {ingual}\n" +
$"{a} é diferente de {b}? {diferente}\n");