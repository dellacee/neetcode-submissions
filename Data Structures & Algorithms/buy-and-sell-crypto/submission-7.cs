public class Solution {
    public int MaxProfit(int[] prices){
        int result = 0;
        for (int i = 0; i < prices.Length ; i++){
            int buy = prices[i];
            for (int j = i +1 ; j< prices.Length ; j++){
                int sell = prices[j];
                int profit = sell - buy ;
                if (result < profit){
                    result = profit ;
                }
            }

        }
        return result;
    }
}