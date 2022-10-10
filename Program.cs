// Калинин Павел 10.10.2022 
// Знакомство с языками программирования (семинары)
// Урок 4. Функции продолжение
// Домашняя работа

bool isRepeat = true; 
string s = "";
string taskName = "";


void printArrayInt(int[] ar) {
    foreach(int i in ar) 
        Console.Write($"{i} ");
    Console.WriteLine("");
}
void printArrayDouble(double[] ar) {
    foreach(double d in ar) 
        Console.Write($"{d} ");
    Console.WriteLine("");
}

void fillArrayRundomInt(int[] ar, int aBegin, int aEnd) {
    Random random = new Random(); 
    int len = ar.Length;
    for(int i=0; i<len; i++) 
        ar[i]=random.Next(aBegin,aEnd); 
}

// if(false) { // выборочно отключить для отладки

taskName = "Задание  №1. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    int[] ar = new int[]{0,1,0,1,0,1,0,1};
    Console.WriteLine("Ответ:");
    printArrayInt(ar);
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    

taskName = "Задание  №2. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    int[] ar = new int[]{0,-1,2,-3,4,-5,6,-7,8,-9,0,-1};
    printArrayInt(ar);
    int sumP = 0, sumN = 0;
    Console.WriteLine("Ответ:");
    foreach(int n in ar) {
        if(n>0) sumP+=n; else if(n<0) sumN+=n;
    }
    Console.WriteLine($"Сумма положительных элементов массива равна {sumP}.");
    Console.WriteLine($"Сумма отрицательных элементов массива равна {sumN}.");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    


taskName = "Задание  №3. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\\четных чисел.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    int[] ar = new int[12];
    fillArrayRundomInt(ar,100,999);
    printArrayInt(ar);
    int sumEven = 0, sumOdd = 0;
    Console.WriteLine("Ответ:");
    foreach(int n in ar) {
        if(n%2 == 0) sumEven+=n; else sumOdd+=n;
    }
    Console.WriteLine($"Сумма четных чисел массива равна {sumEven}.");
    Console.WriteLine($"Сумма нечетных чисел массива равна {sumOdd}.");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    

taskName = "Задание  №4. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    int[] ar = new int[123];
    fillArrayRundomInt(ar, 0,100);
    printArrayInt(ar);
    Console.WriteLine("Ответ:");
    int intSum = 0;
    foreach(int n in ar) {
        if(n>=10 && n<=99) intSum++;
    }
    Console.WriteLine($"Кол-во элементов из отрезка [10,99] равно {intSum}.");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    



taskName = "Задание  №5. Найти сумму чисел одномерного массива стоящих на нечетной позиции.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    int[] ar = new int[]{0,1,2,3,4,5,6,7,8,9,0,1};
    printArrayInt(ar);
    Console.WriteLine("Ответ:");
    int len = ar.Length;
    int intSum=0;
    for(int i=1; i<len; i+=2) {
        intSum+=ar[i];
    }
    Console.WriteLine($"Сумма чисел массива стоящих на нечетной позиции равна {intSum}.");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    


taskName = "Задание  №6. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д..";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    int[] ar = new int[]{1,2,3,4,5,6,7,8,9};
    printArrayInt(ar);
    Console.WriteLine("Ответ:");
    int len = ar.Length; 
    int lenHalf = len/2; 
    for(int i=0; i<lenHalf; i++) {
        Console.WriteLine($"Произведение пары чисел на позициях {i} и {len-1-i} равно {ar[i]*ar[len-1-i]}.");
    }
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    

taskName = "Задание  №7. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    double[] ar = new double[]{0.1,2.1,-3.0,4.56,-5.5,6.0,7.123,-8.01,0.9};
    printArrayDouble(ar);
    Console.WriteLine("Ответ:");
    double dMin = ar[0], dMax = dMin;    
    int len = ar.Length; 
    foreach(double d in ar) {
        if(dMax<d) dMax=d; else if(dMin>d) dMin=d;
    }
    Console.WriteLine($"Разница между макс. {dMax} и мин. {dMin} элементами равно {dMax-dMin}.");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}
 

// }

