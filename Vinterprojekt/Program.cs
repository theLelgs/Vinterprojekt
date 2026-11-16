//General notes: 
//Going to read pokemons stats/moves learned from textfile/database
//Raylib to visualise the game

StatboostMove TestMove = new(){
    Power=0,
    StatboostPairings=new Dictionary<string, int>(){{"attack", 1}}
};
Move Attackmove = new(){
    Power=10,
    Type="Electric"
};
Pokemon test = new(){
    Moves=[TestMove, Attackmove],
    Types= ["Water", "Flying"]
};

int Turncount = 1;
test.GetStats();
while (test.HP!=0)
{
    Console.WriteLine("Turn: "+ Turncount);
    test.UseMove(test.Moves[Random.Shared.Next(2)], test);
    test.GetStats();
    Turncount++;
}
TypeHandler testing = new();
if(testing.Test().ParseSucceeded) Console.WriteLine(testing.Test().TypeInteger);
Console.WriteLine("Test: " + Pokemon.typeHandler.TypeEfficiency[1,2]);
Console.ReadLine();
