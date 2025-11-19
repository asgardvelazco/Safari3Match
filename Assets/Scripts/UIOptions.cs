using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIOptions : MonoBehaviour
{
    private int volume = 10;
    private int sfx = 10;

    public TextMeshProUGUI volumeLabel;
    public TextMeshProUGUI sfxLabel;


    private void Start()
    {
        volumeLabel.text = volume.ToString();
        sfxLabel.text = sfx.ToString();
    }

    public void AddVolume()
    {
        volume++;
        volume = Mathf.Clamp(volume, 0, 10);
        volumeLabel.text = volume.ToString();

    }

    public void MinusVolume()
    {
        volume--;
        volume = Mathf.Clamp(volume, 0, 10);
        volumeLabel.text = volume.ToString();
    }

    public void AddSFX()
    {
        sfx++;
        sfx = Mathf.Clamp(sfx, 0, 10);
        sfxLabel.text = sfx.ToString();
    }

    public void MinusSFX()
    {
        sfx--;
        sfx = Mathf.Clamp(sfx, 0, 10);
        sfxLabel.text = sfx.ToString();
    }
}

/*
Para añadir el funcionamiento a los botones de audio hice lo siguiente

Primero añadi una referencia al AudioSource del objeto MusicSource desde el script de AudioManager y luego desde el inspector, ya que solo teniamos la referencia al sfxSource public AudioSource MusicSource
Luego en el awake del AudioManager estableci el volumen por defecto de los dos AudioSource a 0.5f (para que al iniciar el juego no se escuche ni muy duro ni muy pasito) MusicSource.volume = 0.5f;  SfxSource.volume = 0.5f; Y tambien cambie a 5 el valor inicial de volume y sfx en el script de UIOptions para que la UI tambien iniciara en 5
Y luego en las 4 funciones del script UIOptions agregue una linea que por medio de la instancia del AudioManager accede a los AudioSource de los objetos hijos y establece el volumen del audio igual a la variable que indica que numero escribir (volume o sfx) dividida 10f para que asi nos de un valor entre 0 y 1, aqui como quedaria el script. public void Addvolume()
{
    volume++;
    volume = Mathf.Clamp(volume, 0, 10);
    volumeLabel.text = volume.ToString();
    AudioManager.Instance.MusicSource.volume = volume/10f;
}
public void Minusvolume()
{
    volume--;
    volume = Mathf.Clamp(volume, 0, 10);
    volumeLabel.text = volume.ToString();
    AudioManager.Instance.MusicSource.volume = volume /10f;
}
public void Addvsfx()
{
    sfx++;
    sfx = Mathf.Clamp(sfx, 0, 10);
    sfxLabel.text = sfx.ToString();
    AudioManager.Instance.SfxSource.volume = sfx/10f;
}
public void Minussfx()
{
    sfx--;
    sfx = Mathf.Clamp(sfx, 0, 10);
    sfxLabel.text = sfx.ToString();
    AudioManager.Instance.SfxSource.volume = sfx/10f;
}
Nota: recordar asignar en el inspector la referencia al MusicSource en el objeto AudioManager
*/