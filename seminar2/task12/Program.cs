int chooseNum(int num){
if(num>=100){
    int result = num%100-(num%100)%10;
    return result;
}
else return 0;
}

Console.WriteLine(chooseNum(Convert.ToInt32(Console.Read())));