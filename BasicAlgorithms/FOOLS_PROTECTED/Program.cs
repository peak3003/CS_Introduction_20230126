// try{
// int a=Convert.ToInt32(Console.ReadLine());
// }
// catch(Exception(ex))
// {
//   System.Console.WriteLine(ex);
// }

//int a=int.Parse(Console.ReadLine());


// int a;
// int.TryParse(Console.ReadLine(),out a);
// System.Console.WriteLine(a);

int a;
bool f;
do
{
  f = int.TryParse(Console.ReadLine(), out a);
  if (f == false)
  {
    System.Console.WriteLine("ERROR!");
  }
  else
  {
    System.Console.WriteLine(a);
  }
}
while (f == false);