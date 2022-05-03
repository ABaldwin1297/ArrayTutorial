// Arrays Tutorial

int[] nbrs = { 7, 11, 42, 99, 32, -14, 1, 72, -54, -45 };

var sum = 0;
var index = 0;

while(index < 10) 
{
    if(nbrs[index] % 2 == 0) {
        Console.WriteLine($"{nbrs[index]} is even.");
    }
    sum = sum + nbrs[index];
    index = index + 1;
}

Console.WriteLine($"The average is {sum/10}"); // answer 15




