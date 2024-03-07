// See https://aka.ms/new-console-template for more information

Console.WriteLine("======================Exercise 00======================");

int size = 1001;

int[] myArray = new int[size];
for(int i = 0; i < size; i++){
    myArray[i] = i;

    if(i % 2 == 1){
        Console.WriteLine("Odd!");
    }
    if(i % 2 == 0){
        Console.WriteLine("Even!");
    };
};

// foreach(var element in myArray){
//         Console.WriteLine(element.ToString());
// }

Console.WriteLine("======================Exercise 01======================");

int[] numbers = {5,19,3,2,9,12,4,1,15,3,6,11};

int total = 0;
for(int i = 0; i < numbers.Length; i++){
    total += numbers[i];
};
int average = total/numbers.Length;
Console.WriteLine(average);

Console.WriteLine("======================Exercise 02======================");

string[] weekdays = {"sunday","monday","tuesday","wednesday","thursday","friday","saturday"};

for(int i = 0; i < weekdays.Length; i++){
    Console.WriteLine(weekdays[i]);
};
Console.WriteLine("=====");
Array.Reverse(weekdays);
for(int i = 0; i < weekdays.Length; i++){
    Console.WriteLine(weekdays[i]);
};
Console.WriteLine("======================Exercise 03======================");

int[] myNumbers = {5,12,9,34,16,7};

int maxNum = 0;
for(int i = 0; i < myNumbers.Length; i++){
    if(myNumbers[i] > maxNum){
        maxNum = myNumbers[i];
    }
};
Console.WriteLine(maxNum);