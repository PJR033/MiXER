using UnityEngine.UI;

public class MasterSoundSlider : SoundSlider
{
    private void Awake()
    {
        Slider = GetComponent<Slider>();
        MixersName = "MasterVolume";
    }

    private void Start()
    {
        SetVolume();
    }
}