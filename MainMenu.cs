using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PhysicsOpen()
    {
        SceneManager.LoadSceneAsync(1);

    }

    public void BiologyOpen()
    {
        SceneManager.LoadSceneAsync(2);

    }

    public void ChemistryOpen()
    {
        SceneManager.LoadSceneAsync(3);

    }

    public void MainOpen()
    {
        SceneManager.LoadSceneAsync(0);
    }




    public void PelvicOpen()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void SkeletonOpen()
    {
        SceneManager.LoadSceneAsync(6);
    }
    public void BrainOpen()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void LabOpen()
    {
        SceneManager.LoadSceneAsync(8);
    }

    public void PCL3Open()
    {
        SceneManager.LoadSceneAsync(7);
    }

    public void Quit()
    {
        Application.Quit();
    }





}
