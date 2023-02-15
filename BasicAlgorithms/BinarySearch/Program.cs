// Бинарный поиск
int[] RandomIntArray(int N, int min, int max) //гГенерирует массив длиной N, с мин значением min и макс зн max
{
    int[] arr=new int[N];
    Random random=new Random();
    for(int i=0;i<arr.Length;i++)
        arr[i]=random.Next(min,max+1); //
    return arr;
}

void PrintArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
        System.Console.Write($"{arr[i],5}"); //выводит 5 знакомест
}

int BinSearch(int[] arr,int find)
{
    int i;
    int left=0;
    int right=arr.Length-1;
    i=left+(right-left)/2; // положение после деления массива пополам
    while(arr[i]!=find && left<right)
    {
        if (find>arr[i]) //сравниваем элемент массива с искомым числом
        {
                left=i+1; // левую часть отбрасываем
        }
        else
        {
            right=i; // правую отпрасываем
        }
        i=left+(right-left)/2; // находим новую середину
    }
    if (arr[i]!=find) return -1; // если не нашел число равное искомому
    else return i; //возвращаем найденный элемент равный искомому числу
}

int f=20; //искомое число
int[] a=RandomIntArray(6,0,100);
PrintArray(a);
Array.Sort(a);//сортировка массива
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine(BinSearch(a,f));