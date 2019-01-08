using DigitalRuby.RainMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wizardscode.environment
{
    [CreateAssetMenu(fileName = "RainMakerWeatherSystem", menuName = "Wizards Code/Weather/Digital Ruby's Rain Maker")]
    public class RainMakerWeatherSystem : AbstractWeatherSystem
    {
        [Header("Digital Ruby's Rain Maker")]
        public float UpdateInterval = 2;

        private float timeToNextUpdate = 0;

        /// <summary>
        /// Initialize the Weahter system.
        /// </summary>
        override internal void Initialize()
        {
            // Nothing to do here
        }

        internal override void Update()
        {
            timeToNextUpdate -= Time.deltaTime;

            if (timeToNextUpdate > 0)
            {
                return;
            }
            timeToNextUpdate = UpdateInterval;

            float change;
            if (Random.value > 0.5)
            {
                change = Random.value * 25;
            } else
            {
                change = -Random.value * 25;
            }
            
            precipitationIntensity = Mathf.Clamp(precipitationIntensity + change, 0, 100);
        }
    }
}