using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    //게임 시작 버튼 누르면 팝업창으로 퀘스트 형식의 창이 나오고 퀘스트 수락시 로딩창으로 넘어가면서 게임 씬 진입
    public void StartGame()
    {
        LoadingSceneManager.LoadScene("BackGround_Test");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    public void gameClear()
    {
        SceneManager.LoadScene("MainMenu");
    }

    
}
