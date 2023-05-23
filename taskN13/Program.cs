Console.Clear();
Console.Write("insert some integer: ");
int num=int.Parse(Console.ReadLine()!);
int count=10;
int mult=100;
if (num/100==0){Console.WriteLine("Sorry, there is no third character");}
else{
    mult*=10;
    while(num/mult!=0){
        mult*=10;
        count*=10;
    };
    Console.WriteLine((num%count)/(count/10));

};