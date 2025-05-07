using UnityEngine;
using UnityEngine.UI;

public class BGMButtonToggle : MonoBehaviour
{
    public Sprite bgmOnIcon;
    public Sprite bgmOffIcon;
    private Image iconImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        iconImage=transform.Find("Icon").GetComponent<Image>();
        UpdateIcon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickToggle()
    {
        bool isBGMOn = !AudioManager.Instance.IsBGMEnabled();
        AudioManager.Instance.SetBGMEnabled(isBGMOn);
        UpdateIcon();
    }

    private void UpdateIcon()
    {
        if (iconImage != null)
        {
            iconImage.sprite = AudioManager.Instance.IsBGMEnabled() ? bgmOnIcon : bgmOffIcon;
        }
    }
}
