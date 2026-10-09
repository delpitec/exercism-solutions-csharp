class RemoteControlCar
{
    private int _distance = 0;
    private int _battery  = 100;
    private int _meters   = 0;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distance} meters";
    }

    public string BatteryDisplay()
    {
        string ret = "";
        
        if(_battery > 0)
        {
            ret = $"Battery at {_battery}%";
        }
        else
        {
             ret = "Battery empty";
        }
        return ret;
    }

    public void Drive()
    {
        if(_battery > 0)
        {
            _distance = _distance + 20;
            _battery  = _battery - 1;
        }
    }
}
