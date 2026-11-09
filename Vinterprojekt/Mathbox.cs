public class Mathbox
{
    public int CalculateDMG(Move Move, Pokemon Attacker, Pokemon Target)
    {
        float DmgToDeal = 0;
        DmgToDeal=Move.Power*Attacker.Attack/Target.Defense;

        return (int)DmgToDeal;
    }
}