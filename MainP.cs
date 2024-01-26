using System;
class HelloWorld {
static void Main()
{
  Console.WriteLine("Введите тип массива: one, two, stairs");
  string type = Console.ReadLine();
  if (type =="one")
  {
      Console.Write("Введите длину массива ");
      int length = int.Parse(Console.ReadLine());
      Console.Write("Массив заполняется пользователем?(true/false) ");
      bool choice = bool.Parse(Console.ReadLine());
      int[] mass1 = new int[length];
      OneDims mass = new OneDims(length, choice);
  }
  if (type =="two")
  {
      Console.Write("Введите количество строк массива ");
      int m1 = int.Parse(Console.ReadLine());
      Console.Write("Введите количество столбцов массива ");
      int m2 = int.Parse(Console.ReadLine());
      Console.Write("Массив заполняется пользователем?(true/false) ");
      bool choice = bool.Parse(Console.ReadLine());
      TwoDims mass = new TwoDims(m1,m2, choice);
    
  }
  if (type == "stairs")
  {
      Console.Write("Введите количество строк массива ");
      int m1 = int.Parse(Console.ReadLine());
      Console.Write("Массив заполняется пользователем?(true/false) ");
      bool choice = bool.Parse(Console.ReadLine());
      Steps mass = new Steps(m1, choice);
  }
 }
}



