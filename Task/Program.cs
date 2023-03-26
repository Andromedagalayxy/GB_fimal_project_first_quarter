using System;

class program 
{
  static void Main(string [] args) 
  {
      Console.WriteLine("How many array cells do you want to create?");
      
      int cells_count, cell_lenght, cell_count, count, k;
      
      string [] taskarray;
      string [] inarray;

      inarray = ArrayIn();
      
      ArrayOut(inarray);
      
      cell_count = 0;
      
      for (int i = 0; i<inarray.Length; i++)
      {
          cell_lenght = inarray[i].Length;
          if (cell_lenght < 4) 
          {
              cell_count++;
          }
      } 
      
      taskarray = new string [cell_count];
      count = 0;
      k = 0;
      
      for (int i = 0; i<inarray.Length; i++)
      {
          if (count < cell_count)
          {
              cell_lenght = inarray[i].Length;
              
              if (cell_lenght < 4) 
              {
                  taskarray[k] = inarray[i];
                  count++;
                  k++;
              }
          }
          else if (count == cell_count) break;
      }
      
      ArrayOut2(taskarray);
  }

  static void ArrayOut(string[] inarray)
  {
   for (int i = 0; i<inarray.Length; i++)
      {
          Console.WriteLine($"Element myarray [{i}] = {inarray[i]}");
      }
  }

  static string [] ArrayIn()
  {
    int cells_count;
    cells_count = 0;
    string input;
    string [] arrayin;

    input = Console.ReadLine();

    cells_count = Convert.ToInt32(input);

    arrayin = new string [cells_count];

    for (int i = 0; i<cells_count; i++)
      {
          Console.WriteLine("Enter cell name");
          input = Console.ReadLine();
          arrayin[i] = input;
      }
      return arrayin;
  }

  static void ArrayOut2(string [] taskarray)
  {
     for (int i = 0; i<taskarray.Length; i++)
      {
          Console.WriteLine($"Element task array [{i}] = {taskarray[i]}");
      }
  }

  static int NewArrayLenght () 
  {
    
  }
}