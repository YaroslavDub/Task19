// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество элементов массива");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int [i];
int count = 0;
bool res = true;
while (count < i) {
Console.WriteLine($"Введите {count+1} элемент массива");
array[count] = Convert.ToInt32(Console.ReadLine());
count += 1;
}
count = 0;
while (count < i/2) {
if (array[count] != array[i-1-count]) {
res = false;
}
count +=1 ;
}
if (res) {
Console.WriteLine("Массив является палиндромом");
}
else {
Console.WriteLine("Массив не является палиндромом");
}
for (int z = 0; z < i-1;) {
Console.Write (array[z] + ", ");
z += 1;
}
Console.WriteLine(array[i-1]);
