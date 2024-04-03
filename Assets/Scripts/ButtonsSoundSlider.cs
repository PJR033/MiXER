using UnityEngine.UI;

public class ButtonsSoundSlider : SoundSlider
{
    private void Awake()
    {
        Slider = GetComponent<Slider>();
        MixersName = "SoundsVolume";
    }

    private void Start()
    {
        SetVolume();
    }
}