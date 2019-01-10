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
        [Tooltip("The prefab to use to add Rain Maker to the scene.")]
        public RainScript RainMakerPrefab;
        public float UpdateInterval = 2;

        private GameObject rainMaker;
        private float timeToNextUpdate = 0;
        
        /// <summary>
        /// Initialize the Weather system.
        /// </summary>
        override internal void Initialize()
        {
            if (RainMakerPrefab == null)
            {
                Debug.LogError("To use Digital Ruby's Rainmaker Script you must provide a prefab that has the Rain Maker scripts attached. There is an example in the `prefabs` folder of this plugin.");
                return;
            }
            rainMaker = Instantiate(RainMakerPrefab.gameObject);
            rainMaker.name = "Rain Maker";
            
            precipitationIntensity = 0;
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
            rainMaker.GetComponent<RainScript>().RainIntensity = precipitationIntensity / 100;
        }
    }
}