using UnityEngine;
using UnityEngine.EventSystems;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource bgmSource;
    public AudioSource sfxSource;
    public AudioClip bgmClip;
    public AudioClip deadClip;
    private const string BGM_PREF_KEY = "BGM_ENABLED";

    public AudioClip clickSound;
    public AudioSource clickSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            InitBGMSetting();
            clickSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void InitBGMSetting()
    {
        bool isEnabled = PlayerPrefs.GetInt(BGM_PREF_KEY, 1) == 1;
        bgmSource.clip = bgmClip;
        bgmSource.loop = true;

        if (isEnabled)
        {
            bgmSource.Play();
        }
    }

    public void SetBGMEnabled(bool enabled)
    {
        if (enabled)
        {
            if (!bgmSource.isPlaying)
            {
                bgmSource.Play();
            }
        }
        else
        {
            if (bgmSource.isPlaying)
            {
                bgmSource.Stop();
            }
        }

        PlayerPrefs.SetInt(BGM_PREF_KEY, enabled ? 1 : 0);
        PlayerPrefs.Save();
    }

    public bool IsBGMEnabled()
    {
        return PlayerPrefs.GetInt(BGM_PREF_KEY, 1) == 1;
    }

    public void PlayDeadMusic()
    {
        bgmSource.Stop();
        if (deadClip != null)
        {
            sfxSource.PlayOneShot(deadClip);
        }
    }

    public void ClickSoundPlay()
    {
        if (clickSound != null)
        {
            clickSource.PlayOneShot(clickSound);
        }
    }
}
