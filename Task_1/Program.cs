using System;
using System.Globalization;
namespace Tasks;
internal class Task_123
{
    static void Main(string[] args)
    {

        var currentBatteryLevel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        var car = new Car() { BatteryLevel = currentBatteryLevel };
        var isStarted = car.Start();

        Console.WriteLine(isStarted);
    }
}

class Car : ICar
{
    private const double BatteryLevelLimit = 10.5;
    public double BatteryLevel { get; set; }
    private bool _isStarted;
    public bool IsStarted { get { return _isStarted; } }
    public int EngineSpeed { get; private set; }
    public void Accelerate()
    {
        if (_isStarted)
        {
            this.EngineSpeed = 2500;
        }
    }

    public bool Start()
    {
        if (this.BatteryLevel > BatteryLevelLimit)
        {
            this._isStarted = true;
            this.EngineSpeed = 1000;
            return true;
        }
        else
        {
            this._isStarted = false;
            this.EngineSpeed = 0;
            return false;
        }
    }

    public void Stop()
    {
        _isStarted = false;
        EngineSpeed = 0;
    }

    // Реализуйте интерфейс ICar
}

interface ICar
{
    bool Start();
    void Accelerate();
    void Stop();
}