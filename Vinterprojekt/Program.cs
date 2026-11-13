StatboostMove TestMove = new()
{
    Power=0,
    StatboostPairings=new Dictionary<string, int>(){{"defense", 1}}
};
Move Attackmove = new()
{
    Power=100
};
Pokemon test = new()
{
    Moves=[TestMove],
    Speed=100,
    Defense=100
};


test.GetStats();
test.UseMove(test.Moves[0], test);
test.UseMove(Attackmove, test);
test.GetStats();
Console.ReadLine();