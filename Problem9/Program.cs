int a, b, c;
for (a = 1000; a >= 1; a--)
{
    for (b = a-1; b >= 1; b--)
    {
        c = 1000 - a - b;
        if (a * a + b * b == c * c)
        
            if (a + b + c == 1000)
            {
                Console.WriteLine(a + " " + b + " " + c);
                Console.WriteLine(a * b * c);
                break;
            }
        }
    }
}
