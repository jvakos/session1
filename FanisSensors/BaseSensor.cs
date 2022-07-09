using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanisSensors
{
    internal abstract class BaseSensor
    {

        public abstract bool IsVoltageValid();
        

        public abstract SensorTypes SensorType { get;  }

        public double Value { get; set; }

        public double Voltage { get; set; }
        /// <summary>
        /// Reads the value from the sensor and store it to Value
        /// </summary>
        public void ReadValue()
        {
            if (IsVoltageValid())
            {
                Value = 1.1;
            }

        }

        

    }

    


    enum SensorTypes
    {
        LightSensor,
        HumiditySensor,
        TempSensor,
        Sonar
    }

    

}
