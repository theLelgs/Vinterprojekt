public class TypeHandler
{
    public enum Type
    {
        Normal = 0,
        Fire = 1,
        Water = 2,
        Electric = 3,
        Grass = 4,
        Ice = 5,
        Fighting = 6,
        Poison = 7,
        Ground = 8,
        Flying = 9,
        Psychic = 10,
        Bug = 11,
        Rock = 12,
        Ghost = 13, 
        Dragon = 14,
        Dark = 15, 
        Steel = 16,
        Fairy = 17
    }
    public (bool ParseSucceeded, int TypeInteger) Test()
    {
        return (Enum.TryParse("Fairy", out Type x), (int)x);
    }
    
    public int Parse(string type)
    {
        if (Enum.TryParse(type, out Type x))
        {
            return (int)x;
        }
        else
        {
            return -1;
        }
    }

    //THIS IS GOING TO BE HORRIBLE, I'D LIKE FOR THIS TO BE FROM A DATABASE BUT I DIDN'T FIND ONE!
    public float[,] TypeEfficiency = {
        // {X = Attacker, Y = Defender}
        {1f, 1f, 1f, 1f, 1f, 1f, 2, 1f, 1f, 1f, 1f, 1f, 1f, 0, 1f, 1f, 1f, 1f}, //Normal Defender 
        {1f, 1f/2, 2f, 1f, 1f/2, 1f/2, 1f, 1f, 2f, 1f, 1f, 1f/2, 2f, 1f, 1f, 1f, 1/2f, 1/2f}, //Fire Defender
        {1f, 1f/2, 1f/2, 2f, 2f, 1f/2, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f/2, 1f}, //Water Defender
        {1f, 1f, 1f, 1f/2, 1f, 1f, 1f, 1f, 2f, 1f/2, 1f, 1f, 1f, 1f, 1f, 1f, 1f/2, 1f}, //Electric Defender
        {1f, 2f, 1f/2, 1f/2, 1f/2, 2f, 1f, 2f, 1f/2, 2f, 1f, 2f, 1f, 1f, 1f, 1f, 1f, 1f}, //Grass Defender
        {1f, 2f, 1f, 1f, 1f, 1f/2, 2f, 1f, 1f, 1f, 1f, 1f, 2f, 1f, 1f, 1f, 2f, 1f}, //Ice Defender
        {1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 2f, 1f/2, 1f/2, 1f, 1f, 1f/2, 1f, 2f}, //Fighting Defender
        {1f, 1f, 1f, 1f, 1f/2, 1f, 1f/2, 1f/2, 2f, 1f, 2f, 1f/2, 1f, 1f, 1f, 1f, 1f, 1f/2}, //Poison Defender
        {1f, 1f, 2f, 0f, 2f, 2f, 1f, 1f/2, 1f, 1f, 1f, 1f, 1f/2, 1f, 1f, 1f, 1f, 1f}, //Ground Defender
        {1f, 1f, 1f, 2f, 1f/2, 2f, 1f/2, 1f, 0f, 1f, 1f, 1f/2, 2f, 1f, 1f, 1f, 1f, 1f}, //Flying Defender
        {1f, 1f, 1f, 1f, 1f, 1f, 1f/2, 1f, 1f, 1f, 1f/2, 2f, 1f, 2f, 1f, 2f, 1f, 1f}, //Psychic Defender
        {1f, 2f, 1f, 1f, 1f/2, 1f, 1f/2, 1f, 1f/2, 2f, 1f, 1f, 2f, 1f, 1f, 1f, 1f, 1f}, //Bug Defender
        {1f/2, 1f/2, 2f, 1f, 2f, 1f, 2f, 1f/2, 2f, 1f/2, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 1f}, //Rock Defender
        {0f, 1f, 1f, 1f, 1f, 1f, 0f, 1f/2, 1f, 1f, 1f, 1f/2, 1f, 2f, 1f, 2f, 1f, 1f}, //Ghost Defender
        {1f, 1f/2, 1f/2, 1f/2, 1f/2, 2f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 1f, 1f, 2f}, //Dragon Defender
        {1f/2, 2f, 1f, 1f, 1f/2, 1f/2, 2f, 0f, 2f, 1f/2, 1f/2, 1f/2, 1f/2, 1f, 1f/2, 1f, 1f/2, 1f/2}, //Steel Defender
        {1f, 1f, 1f, 1f, 1f, 1f, 1f/2, 2f, 1f, 1f, 1f, 1f/2, 1f, 1f, 0f, 1f/2, 2f, 1f,} //Fairy Defender
        };
}