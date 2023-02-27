using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace crazy.Scripts.Player
{
    
    public class PlayerController : MonoBehaviour
    {
        private readonly float bell = 100.0f;
        private float currentBell = 100.0f;
        private Image bellBar;
        [SerializeField] public GameObject restartButton;
        [SerializeField] public int coin;
        [SerializeField] Text coinText;
        protected virtual void Start()
        {
            bellBar = GameObject.Find("Canvas/Bell").GetComponent<Image>();
        }
        private void OnTriggerEnter(Collider col)
        {
            if(col.gameObject.CompareTag("enemy"))
            {
                currentBell -= 2f;
                bellBar.fillAmount = currentBell / bell;
                if(currentBell<=0)
                {
                    Time.timeScale = 0;
                    restartButton.SetActive(true);
                }
            }
            if (!col.gameObject.CompareTag("coin")) return;
            NumberOfCoins();
            Destroy(col.gameObject);
        }
        private void NumberOfCoins()
        {
            coin++;
            coinText.text = coin.ToString();
        }
        public void RestartButton()
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }

    }
}