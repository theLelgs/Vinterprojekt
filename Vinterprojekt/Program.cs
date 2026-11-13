StatboostMove Overdrive = new()
{
    Power=0,
    StatboostPairings=new Dictionary<string, int>(){{"speed", 1}}
};
Pokemon test = new()
{
    Moves=[Overdrive],
    Speed=100
};


test.HP=100;
Console.WriteLine(test.HP);
test.HP-=10;
Console.WriteLine(test.HP);
Console.WriteLine(test.Speed);
test.UseMove(test.Moves[0], test, test);
Console.WriteLine(test.Speed);
Console.WriteLine("");
Console.ReadLine();