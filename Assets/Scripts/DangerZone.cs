using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DangerZone : MonoBehaviour
{
    public Slider slider;

    private void Update()
    {
        if (slider.value == 0)
        {
            SceneManager.LoadScene("Level1");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            slider.value -= 1;
        }
    }
}
