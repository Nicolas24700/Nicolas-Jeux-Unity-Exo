using UnityEngine.SceneManagement;

public class LevelController : TriggerController
{
    protected override void Interact()
    {
        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        int nextLevelIndex = activeScene.buildIndex + 1;

        if (nextLevelIndex >= SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(0);
            return;
        }
        else
        {
            SceneManager.LoadScene(nextLevelIndex);
        }
    }
}