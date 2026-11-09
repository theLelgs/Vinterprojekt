public class Pokemon
{
    public List<Move> Moves = [];
    float _maxHP = 100;
    float _hp;
    public float HP
    {
        get
        {
            return _hp;
        }
        set
        {
            _hp=MathF.Max(0, MathF.Min(value, _maxHP)); // 0 <= HP <= MaxHP
        }
    }
    float _speed;
    public float Speed { get; set; }
    float _defense;
    public float Defense { get; set; }
    float _attack;
    public float Attack { get; set; }
    float _specialDefense;
    public float SpecialDefense { get; set; }
    float _specialAttack;
    public float SpecialAttack { get; set; }
    public Dictionary<string, float> StatBoosts = [];
    float CalculateDMG(Move Move, Pokemon Attacker, Pokemon Target)
    {
        float DmgToDeal=Move.Power*Attacker.Attack/Target.Defense;
        return DmgToDeal;
    }
}