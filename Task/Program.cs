class program 
{
  static void Main(string [] args) 
  {
      int tl, tel; //taskarray_lenght, taskarray_element_lenght
      string [] tda, tea; //the desired array (taskarray), the entered array (arrayin)

      tel = 0;

      Console.WriteLine("How many array cells do you want to create?");
      
      tea = Input();
      
      Output(tea);
      
      tl = LenghtForNextArray(tea);
      
      tda = new string [tl];

      tda = ArrayConversion(tea,tda,tl,tel);
      
      OutoutOfTheDesiredArray(tda);
  }

static string [] Input()
  {
    int cc; //cells_count
    string e; //enter (input)
    string [] wa; //working array

    cc = 0;
    
    e = Console.ReadLine();
    cc = Convert.ToInt32(e);
    wa = new string [cc];

    for (int i = 0; i<cc; i++)
      {
          Console.WriteLine($"Enter cell [{i}] ");
          e = Console.ReadLine();
          wa[i] = e;
      }
      return wa;
  }

  static void Output(string[] tea)
  {
   for (int i = 0; i<tea.Length; i++)
      {
          Console.WriteLine($"An element in the entered array [{i}] = {tea[i]}");
      }
  }

  static int LenghtForNextArray (string [] tea) 
  {
    int cell_lenght = 0;
    int cell_count = 0;

    for (int i = 0; i<tea.Length; i++)
      {
          cell_lenght = tea[i].Length;
          if (cell_lenght < 4) 
          {
              cell_count++;
          }
      } 
      
      return cell_count;
  }

static string [] ArrayConversion (string [] tea, string [] tda, int tl, int tel)
  {
    int count, k;

    k = 0;
    count = 0;
    
    for (int i = 0; i<tea.Length; i++)
      {
          if (count < tl)
          {
              tel = tea[i].Length;
              
              if (tel < 4) 
              {
                  tda[k] = tea[i];
                  count++;
                  k++;
              }
          }
          else if (count == tl) break;
      }

      return tda;
  }

  static void OutoutOfTheDesiredArray(string [] tda)
  {
     for (int i = 0; i<tda.Length; i++)
      {
          Console.WriteLine($"Element task array [{i}] = {tda[i]}");
      }
  }
}