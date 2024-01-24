// Дан массив из N элементов (вещественные числа). Вычислить:

// номер минимального элемента массива;
// произведение элементов массива, расположенных между первым и вторым отрицательными элементами;
// преобразовать массив так, чтобы сначала располагались все элементы, модуль которых не превышает 1, а потом – элементы, все остальные.

int N;
Console.WriteLine("Введите размер массива");
N = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[N];
Random rand = new Random();

for (int i = 0; i < N; i++)
{
    arr[i] = (double)(rand.Next(100) - 50) / 10;
    Console.Write(arr[i] + "  ");
}

double temp = arr[0];
int index = 0;

for (int i = 1; i < N; i++)
{
    if (arr[i] < temp)
    {
        temp = arr[i];
        index = i;
    }
}

Console.WriteLine("\n\nминимальное значение массива = " + temp);
Console.WriteLine("номер минимального элемента = " + (index + 1));

int first = 0, second = 0;
for (int i = 0; i < N; i++)
{
    if (arr[i] < 0)
    {
        first = i;
        break;
    }
}
for (int i = first + 1; i < N; i++)
{
    if (arr[i] < 0)
    {
        second = i;
        break;
    }
}

temp = 1;
if ((second - first) < 2)
{
    Console.WriteLine("между первыми двумя отрицательными значениями других значений нету\n\n");
}
else
{
    for (int i = first + 1; i < second; i++)
    {
        temp *= arr[i];
    }
    Console.WriteLine("\nпроизведение элементов массива = " + temp);
}

for (int i = 0; i < N; i++)
{
    for (int j = N - 1; j > i; j--)
    {
        if (Math.Abs(arr[i]) > 1 && Math.Abs(arr[j]) < 1)
        {
            double tempSwap = arr[i];
            arr[i] = arr[j];
            arr[j] = tempSwap;
        }
    }
}

for (int i = 0; i < N; i++)
{
    Console.Write(arr[i] + "  ");
}
