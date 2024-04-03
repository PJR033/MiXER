using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class SoundSlider : MonoBehaviour
{
    [SerializeField] protected AudioMixer Mixer;

    protected Slider Slider;
    protected string MixersName;

    public void SetVolume()
    {
        int minVolumeValue = -80;
        int maxVolumeValue = 0;
        Mixer.SetFloat(MixersName, Mathf.Lerp(minVolumeValue, maxVolumeValue, Slider.value));
    }
}
