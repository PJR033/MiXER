using UnityEngine.Audio;
using UnityEngine;

public class MuteButton : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;

    private bool _isMuted;

    public void MuteSound()
    {
        if (_isMuted)
        {
            _mixer.SetFloat("MasterVolume", 0);
            _isMuted = false;
        }
        else
        {
            int minVolumeValue = -80;
            _mixer.SetFloat("MasterVolume", minVolumeValue);
            _isMuted = true;
        }
    }
}
