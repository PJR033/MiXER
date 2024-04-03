using UnityEngine.UI;

public class MusicSlider : SoundSlider
{
    private void Awake()
    {
        Slider = GetComponent<Slider>();
        MixersName = "MusicVolume";
    }

    private void Start()
    {
        SetVolume();
    }
}