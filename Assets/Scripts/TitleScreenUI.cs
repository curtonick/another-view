using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Aview
{
    public class TitleScreenUI : MonoBehaviour
    {
        [SerializeField]
        Button m_StartGameButton = null;
        [SerializeField]
        Button m_OptionButton1 = null;
        [SerializeField]
        Button m_OptionButton2 = null;
        [SerializeField]
        Button m_QuitGame = null;

        // Start is called before the first frame update
        void Start()
        {
            m_StartGameButton.onClick.AddListener(() => GameManager.LoadScene("Launcher"));
            m_QuitGame.onClick.AddListener(() => Application.Quit());
        }

    }
}