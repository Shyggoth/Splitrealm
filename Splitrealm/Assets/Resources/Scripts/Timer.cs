using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Splitrealm
{
    public class Timer : MonoBehaviour
    {
        public Text timerText;

        TimeSpan timeSpan;
        bool isRunning;

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

        void UpdateTimer(int seconds)
        {
            timeSpan = TimeSpan.FromSeconds(seconds);
            timerText.text = timeSpan.ToString();
        }

        public void SetTimer(int seconds)
        {
            if(!isRunning)
                StartCoroutine(StartTimer(seconds));
        }
    }
}