Console.WriteLine("Apple Stock Question");

/// <summary>
/// the indices are the time in minutes past trade opening time, which
/// was 9:30 local time
/// the values are the price (in USD) of one share of Apple stock
/// at that time
/// </summary>
int[] stock_prices = new int[]{10,7,5,8,11,9};
//int[] stock_prices = new int[]{7,4,3,2,1};
Console.WriteLine("Max profit is: {0}", Get_Max_Profit(stock_prices));
Console.WriteLine("Max profit is: {0}", Get_Max_Profit_Greedy(stock_prices));

int Get_Max_Profit(int[] stock_prices)
{
    var profit = stock_prices[1] - stock_prices[0];
    for (int i = 0; i < stock_prices.Length-1; ++i)
    {
        int node = stock_prices[i];
        int j = i+1;
        int lm = Get_Local_Max_Recursive(stock_prices[j..]);
        profit = lm - node;
    }
    return profit;
}

int Get_Max_Profit_Greedy(int[] stock_prices)
{
    int minSoFar = stock_prices[0];
    Console.WriteLine("Min So Far {0}", minSoFar);
    int profit = stock_prices[1] - stock_prices[0];
    Console.WriteLine("Profit So Far {0}", profit);
    for(int i = 1; i < stock_prices.Length; ++i)
    {
        Console.WriteLine("Iteration {0}", i);
        Console.WriteLine("stock_prices[i] = {0}", stock_prices[i]);
        if(profit < (stock_prices[i]-minSoFar))
        {
            profit = (stock_prices[i]-minSoFar);
            Console.WriteLine("Profit So Far {0}", profit);


        }
        if(minSoFar > stock_prices[i]){

            minSoFar = stock_prices[i];
            Console.WriteLine("Min So Far {0}", minSoFar);
        }

    }
    return profit;
}

int Get_Local_Max(int[] sub)
{
    int max = sub[0];
    for(int i = 1; i < sub.Length; ++i)
    {
        if (sub[i] > max)
        {
            max = sub[i];
        }
    }
    return max;
}

int Get_Local_Max_Recursive(int[] sub)
{
    if(sub.Length == 0)
    {
        return 0;
    }
    else
    {
        return Get_Local_Max_Recursive_Next(sub, sub[0]);
    }
}

int Get_Local_Max_Recursive_Next(int[] sub, int max)
{
    if(sub.Length == 0)
        return max;
    if(sub[0] > max){
        max = sub[0];
    }
    return Get_Local_Max_Recursive_Next(sub[1..], max);
}