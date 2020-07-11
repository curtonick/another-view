using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Aview
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _Instance = null;

        // Start is called before the first frame update
        void Awake()
        {
            if (_Instance == null)
            {
                _Instance = this;
            } 
            else
            {
                Debug.LogError("There is already a GameManager Instance!");
            }
        }

        public static void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

    }
}
