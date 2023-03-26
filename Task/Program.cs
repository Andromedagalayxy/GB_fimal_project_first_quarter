class program 
{
  static void Main(string [] args) 
  {
      int taskarray_lenght, taskarray_element_lenght;
      string [] taskarray;
      string [] inarray;

      taskarray_element_lenght = 0;

      Console.WriteLine("How many array cells do you want to create?");
      
      inarray = ArrayIn();
      
      ArrayOut(inarray);
      
      taskarray_lenght = TaskArrayLenght(inarray);
      
      taskarray = new string [taskarray_lenght];

      taskarray = TaskArraySort(inarray,taskarray,taskarray_lenght,taskarray_element_lenght);
      
      ArrayOut2(taskarray);
  }

static string [] ArrayIn()
  {
    int cells_count;
    string input;
    string [] arrayin;

    cells_count = 0;
    
    input = Console.ReadLine();
    cells_count = Convert.ToInt32(input);
    arrayin = new string [cells_count];

    for (int i = 0; i<cells_count; i++)
      {
          Console.WriteLine($"Enter cell [{i}] ");
          input = Console.ReadLine();
          arrayin[i] = input;
      }
      return arrayin;
  }

  static void ArrayOut(string[] inarray)
  {
   for (int i = 0; i<inarray.Length; i++)
      {
          Console.WriteLine($"Element myarray [{i}] = {inarray[i]}");
      }
  }

  static int TaskArrayLenght (string [] inarray) 
  {
    int cell_lenght = 0;
    int cell_count = 0;

    for (int i = 0; i<inarray.Length; i++)
      {
          cell_lenght = inarray[i].Length;
          if (cell_lenght < 4) 
          {
              cell_count++;
          }
      } 
      
      return cell_count;
  }

static string [] TaskArraySort(string [] inarray, string [] taskarray, int taskarray_lenght, int taskarray_element_lenght)
  {
    int count, k;

    k = 0;
    count = 0;
    
    for (int i = 0; i<inarray.Length; i++)
      {
          if (count < taskarray_lenght)
          {
              taskarray_element_lenght = inarray[i].Length;
              
              if (taskarray_element_lenght < 4) 
              {
                  taskarray[k] = inarray[i];
                  count++;
                  k++;
              }
          }
          else if (count == taskarray_lenght) break;
      }

      return taskarray;
  }

  static void ArrayOut2(string [] taskarray)
  {
     for (int i = 0; i<taskarray.Length; i++)
      {
          Console.WriteLine($"Element task array [{i}] = {taskarray[i]}");
      }
  }
}