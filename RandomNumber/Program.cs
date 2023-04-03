Random rnd = new Random();

int MyRandomNum;

int randSum = 0;

for( int i = 0;i < 3; i++ )
{

    MyRandomNum = rnd.Next(0, 11);
    randSum = randSum + MyRandomNum;
    Console.WriteLine($"My random number is: {MyRandomNum}");
}

Console.WriteLine($"random sum total:{randSum}");