Console.WriteLine("Apple Stock Question");

/// <summary>
/// the indices are the time in minutes past trade opening time, which
/// was 9:30 local time
/// the values are the price (in USD) of one share of Apple stock
/// at that time
/// </summary>
int[] stock_prices = new int[]{10,7,5,8,11,9};
Console.WriteLine(Get_Max_Profit(stock_prices));

int Get_Max_Profit(int[] stock_prices)
{
    var profit = 0;
    // loop from 0 to list length -1
    // traverse whole list looking for values higher than current node
    // Start from first index
    for (int i = 0; i < stock_prices.Length-1; ++i)
    {
        Console.WriteLine("i = {0}, stock_price[i] = {1}",i,stock_prices[i]);
        int node = stock_prices[i];
        int localMax = stock_prices[i+1];
        
        

    // find comparative max in remaining nodes
        if(localMax - node > profit)
        {
        // find diff of max and index
            profit = localMax - node;
        }
    }
        
    // save profit.
    return profit;
}

