public class StatboostMove : Move
{
    Dictionary<string, int> _statboostPairings;

    public Dictionary<string, int> StatboostPairings 
    { 
        get 
        {
            return _statboostPairings;
        }
        set
        {
            _statboostPairings=value;
        }
    }
}