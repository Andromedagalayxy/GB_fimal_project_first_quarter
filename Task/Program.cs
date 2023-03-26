using System;

class program 
{
  static void Main(string [] args) 
  {
      Console.WriteLine("How many array cells do you want to create?");
      
      string input;
      int cells_count, cell_lenght, cell_count, count, k;
      string [] myarray;
      string [] taskarray;
      
      input = Console.ReadLine();
      cells_count = Convert.ToInt32(input);
      
      myarray = new string [cells_count];
      
      
      for (int i = 0; i<cells_count; i++)
      {
          Console.WriteLine("Enter cell name");
          input = Console.ReadLine();
          myarray[i] = input;
      }
      
      for (int i = 0; i<cells_count; i++)
      {
          Console.WriteLine($"Element myarray [{i}] = {myarray[i]}");
      }
      
      cell_count = 0;
      
      for (int i = 0; i<cells_count; i++)
      {
          cell_lenght = myarray[i].Length;
          if (cell_lenght < 4) 
          {
              cell_count++;
          }
      } 
      
      taskarray = new string [cell_count];
      count = 0;
      k = 0;
      
      for (int i = 0; i<cells_count; i++)
      {
          if (count < cell_count)
          {
              cell_lenght = myarray[i].Length;
              
              if (cell_lenght < 4) 
              {
                  taskarray[k] = myarray[i];
                  count++;
                  k++;
              }
          }
          else if (count == cell_count) break;
      }
      
      for (int i = 0; i<cell_count; i++)
      {
          Console.WriteLine($"Element task array [{i}] = {taskarray[i]}");
      }
  }
}