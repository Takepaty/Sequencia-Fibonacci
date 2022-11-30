class Program
{
 static void Main(string[] args)
 {
  int anterior = 0;
  int atual = 1;
  int fibonacci = 0;
  int[] sequenciaFib = new int[20];

  Console.WriteLine("1) Digite um número:");
  int digitado = int.Parse(Console.ReadLine());
  bool encontrado = false;

  for (int i = 0; i < 20; i++)
  {
   fibonacci = anterior + atual;
   anterior = atual;
   atual = fibonacci;
   sequenciaFib[i] = atual;

   if (digitado == sequenciaFib[i])
   {

    encontrado = true;
    break;
   }
  }
  if (encontrado)
   Console.WriteLine($"O número {digitado} digitado está dentro do fibonacci!");
  else
   Console.WriteLine($"O número {digitado} digitado não está dentro da fibonacci!");
 }
}