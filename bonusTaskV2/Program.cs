Console.Clear();
Console.Write("insert set of integers divided by Space symbol: ");
int[] numbers = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int max=0;
int sec=0;
for (int i=0; i<numbers.Length; i++){
    if(numbers[i]>max){
        sec=max;
        max=numbers[i];
    }
    else if (numbers[i]>sec)sec=numbers[i];

}
Console.WriteLine($"the second most great integer is {sec}");