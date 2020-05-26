using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace BeyondTheBasics.Gameplay
{
    public class sampleScript : UnityEngine.MonoBehaviour
    {

        #region Variable Declarations

        public int numberToDisplay;
        private int numberToMultiplyBy;

        #endregion

        // Start is called before the first frame update
        #region Private Methods
        private void Start()
        {
            AnonymousTypeExample();
        }

        private void SayHelloWorld()
        {
            var newNumber;
            int anotherNumber;

            var randomNumber = UnityEngine.Random.Range(0, numberToDisplay);
            var displayText = "Hello World!";

            randomNumber = "This won't work";

            for (int i = 0; i < randomNumber; i++)
            {
                Debug.Log("Hello World!");
            }
        }
        private void MultiplyNumber(int numberToMultiply)
        {
            int product = numberToMultiply * numberToMultiplyBy;

            Debug.Log(product);
        }
        private void AnonymousTypeExample()sss
        {
            // var enemy = new { name = "Monster", hitPoints = 100 };
            var enemies = new[]
            {
                new { name = "Monster", hitPoints = 100},
                new { name = "GOblin", hitPoints = 200},
                new { name = "Beast", hitPoints = 300}
            };
            var enemyQuery =
                from enemy in enemies
                orderby enemy.name
                select enemy;
            foreach (var enemy in enemyQuery)
            {
                Debug.Log(enemy.name);
            }
        }
    }
    #endregion
}
