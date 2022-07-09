namespace FanisSensors
{
    internal class HumiditySensor : BaseSensor
    {
        public override SensorTypes SensorType =>  SensorTypes.HumiditySensor;

        public override bool IsVoltageValid()
        {
            if (Voltage > 3.3 && Voltage < 5.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
