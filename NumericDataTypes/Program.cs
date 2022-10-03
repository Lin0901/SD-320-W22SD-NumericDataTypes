//Which scenarios should the decimal data type be used
//1. Monetary transactions
//3. Arithmetic that rounds to the decimal place of the most precise number
//4. Calculating trajectories for smashing two objects in space into each other

decimal a = 9.9m;
decimal b = 8.8m;


void AddFloatingPoints()   
{
    Console.WriteLine((double)a + (double)b); 
}