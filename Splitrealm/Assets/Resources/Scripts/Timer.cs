using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Splitrealm
{
    public class Timer : MonoBehaviour
    {
        public Text timerText;                                  // The Text component on the gameobject, which holds the timer display text.
        TimeSpan timeSpan;                                      
        bool isRunning;                                         // This variable is used to determin, if the timer is running.

        // The Coroutine which is used to start the timer. It requires a parameter, in form of a int, which is the seconds the timer should run.
        IEnumerator StartTimer(int seconds)
        {
            isRunning = true;
            UpdateTimer(seconds);
            timerText.gameObject.SetActive(true);

            while(seconds != 0)
            {
                yield return new WaitForSeconds(1f);
                seconds--;
                UpdateTimer(seconds);
            }

            timerText.gameObject.SetActive(false);
            isRunning = false;
            StopCoroutine("StartTimer");
        }


        // The function is used to update the timer. It has an int parameter which is the amount of seconds.
        void UpdateTimer(int seconds)
        {
            timeSpan = TimeSpan.FromSeconds(seconds);
            timerText.text = timeSpan.ToString();
        }

        // THis function is used to set the timer. It has an int parameter which is given in seconds.
        public void SetTimer(int seconds)
        {
            if(!isRunning)
                StartCoroutine(StartTimer(seconds));
        }
    }
}