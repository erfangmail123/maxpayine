using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public Slider healthBar;          // نوار سلامتی
    public Text ammoText;             // نمایش مهمات
    public PlayerShooting playerShooting;

    void Update()
    {
        // به‌روزرسانی نوار سلامتی
        healthBar.value = playerShooting.GetComponent<Health>().currentHealth;

        // نمایش مهمات
        ammoText.text = "Ammo: " + playerShooting.ammo;
    }
}
