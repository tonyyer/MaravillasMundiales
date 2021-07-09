
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider slider;
    public float sliderValor;
    public Image imagenMute;
    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 1f);
        AudioListener.volume = slider.value;
        CheckMute();
    }
    public void ValorSlider(float valor)
    {
        sliderValor = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValor);
        AudioListener.volume = slider.value;
        //CheckMute();
    }
    public void CheckMute()
    {
        if (sliderValor == 0)
        {
            imagenMute.enabled = true;
        }
        else
        {
            imagenMute.enabled = false;
        }
    }
}
