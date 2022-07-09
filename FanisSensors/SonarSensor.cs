namespace FanisSensors
{
    internal class SonarSensor :BaseSensor
    {
        public override SensorTypes SensorType =>SensorTypes.Sonar;
            

        public override bool IsVoltageValid()
        {
            if (Voltage>12 && Voltage < 24)
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
