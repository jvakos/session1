using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanisSensors
{
    internal abstract class BaseSensor
    {
        public SensorType SensorType { get; set; }

        public double Value { get; set; }



        /// <summary>
        /// Reads the value from the sensor and store it to Value
        /// </summary>
        public void ReadValue()
        {
            Value = 1.1;

        }

    }


    enum SensorType
    {
        LightSensor,
        HumiditySensor,
        TempSensor
    }

    

}
