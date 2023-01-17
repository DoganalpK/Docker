int i = 1;
while (i < 100)
{
    Console.WriteLine($"docker test {i}");
    Thread.Sleep(1000);
    i++;
}