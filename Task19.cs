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
// Console.WriteLine("Введеите пятизначное число");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n > 10000 && n < 100000) {
//     if (n % 10 == n / 10000 && n % 100 / 10 == n % 1000 % 10){
//     }
//     Console.WriteLine ("Число является палиндромом");
// }
// else if (n < 10000 || n > 100000) {
//     Console.WriteLine ("Это не пятизначное число");
// }
// else {
//     Console.WriteLine ("Число не является палиндромом");
// }