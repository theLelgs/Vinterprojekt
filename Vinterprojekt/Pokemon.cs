public class Pokemon
{
    public List<Move> Moves = [];
    string[] Types;
    float _maxHP = 100;
    float _hp;
    float _speed;
    float _defense;
    float _attack;
    float _specialDefense;
    float _specialAttack;
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
    public float Speed 
    {
        get
        {
            if (StatBoosts.TryGetValue("speed", out float x))
            {    
                return _speed*GetStatBoost((int)x);
            }
            else
            {
                return _speed;
            }
        }
        set
        {
            _speed=value;
        } 
    }
    public float Defense 
    {
        get
        {
            if (StatBoosts.TryGetValue("defense", out float x))
            {    
                return _defense*GetStatBoost((int)x);
            }
            else
            {
                return _defense;
            }
        }
        set
        {
            _defense=value;
        } 
    }
    public float Attack 
    {
        get
        {
            if (StatBoosts.TryGetValue("attack", out float x))
            {    
                return _attack*GetStatBoost((int)x);
            }
            else
            {
                return _attack;
            }
        }
        set
        {
            _attack=value;
        }
    }
    public float SpecialDefense 
    {
        get
        {
            if (StatBoosts.TryGetValue("specialdefense", out float x))
            {    
                return _specialDefense*GetStatBoost((int)x);
            }
            else
            {
                return _specialDefense;
            }        }
        set
        {
            _specialDefense=value;
        }
    }
    public float SpecialAttack 
    {
        get
        {
            if (StatBoosts.TryGetValue("specialattack", out float x))
            {    
                return _specialAttack*GetStatBoost((int)x);
            }
            else
            {
                return _specialAttack;
            }
        }
        set
        {
            _specialAttack=value;
        }
    }
    public Dictionary<string, float> StatBoosts = [];
    float CalculateDMG(Move move, Pokemon attacker, Pokemon target)
    {
        float DmgToDeal=move.Power*attacker.Attack/target.Defense;
        return DmgToDeal;
    }
    public void UseMove(Move move, Pokemon attacker, Pokemon target)
    {
        if(move.Power!=0)
        {
            CalculateDMG(move, attacker, target);
        }
        else if(move.GetType().ToString()=="StatboostMove")

        {
            StatboostMove temp = (StatboostMove)move;
            Console.WriteLine("STATBOOSTMOVE");   
            foreach (string stat in temp.StatboostPairings.Keys)
            {
                Console.WriteLine("Adding " + stat);
                if (!StatBoosts.TryAdd(stat, temp.StatboostPairings[stat]))
                {
                    StatBoosts[stat]+=temp.StatboostPairings[stat];
                }
            }
            
        }
        else
        {
            Console.WriteLine("Output = "+move.GetType().ToString());
        }
        move.PP--;
    }
    float GetStatBoost(int boostIndex)
    {
        float[] StatModifiers = [1f/4, 2f/7, 1f/3, 2f/5, 1f/2, 2f/3, 1f, 3f/2, 2f, 5f/2, 3f, 7f/2, 4f];
        float Modifier = StatModifiers[Math.Clamp(boostIndex,-6,6)+6];
        Console.WriteLine("Modifiers: ");
        foreach (float stat in StatModifiers)
        {
            Console.WriteLine(stat);
        }
    

        return Modifier;
    }
}
