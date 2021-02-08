using UnityEngine;
using TMPro;
using System.Collections.Generic;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown resolutionDropdown;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private Image soundImage;

    private Resolution[] resolutions;

    private void Awake()
    {
        resolutions = Screen.resolutions;
        List<string> options = new List<string>();

        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].Equals(Screen.currentResolution))
            {
                resolutionDropdown.AddOptions(options);
                resolutionDropdown.value = i;

                options.Clear();
            }
        }

        resolutionDropdown.AddOptions(options);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            settingsPanel.SetActive(!settingsPanel.activeSelf);
        }
    }

    public void setVolume(float volume)
    {
        if (volume == 0)
        {
            soundImage.color = Color.black;
        }
        else if (audioSource.volume == 0 && volume > 0)
        {
            soundImage.color = Color.white;
        }

        audioSource.volume = volume;
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void setResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
