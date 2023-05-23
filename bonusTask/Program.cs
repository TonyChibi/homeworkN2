
Console.Clear();
bool cond=true;
int max=0;
int second=0;
do{
    Console.Write("insert an integer or 'stop' to end the program:  ");
    string insert = Console.ReadLine()!;
    if (insert.ToLower()=="stop"){
        cond=false;
        Console.WriteLine($"the final second silver integer is {second}");
    }
    else{
        int num= int.Parse(insert);
        if (num>max){
            second=max;
            max=num;}
        else if (num>second) second=num;

        Console.WriteLine($"the current second greatest integer is {second}");
    }
}while(cond);