using DigitalRuby.RainMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wizardscode.environment
{
    public class RainMakerWeatherManager : WeatherManager
    {
        [Header("Digital Ruby's Rain Maker")]
        [Tooltip("The Rain Maker script to manage the rain in this scene.")]
        public RainScript RainScript;

        private void Start()
        {
            if (RainScript == null)
            {
                Debug.LogError("To use Digital Ruby's Rainmaker Script you must provide a RainScript object.");
                return;
            }

            Debug.Log("Setting rain intensity to 0.");
            configuration.CurrentProfile.precipitationIntensity = 0;
        }

        private void Update()
        {
            configuration.Update();
            if (RainScript != null)
            {
                RainScript.RainIntensity = configuration.CurrentProfile.precipitationIntensity / 100;
            }
        }
    }
}
