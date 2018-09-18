using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SplashScreenDelayed : MonoBehaviour {
	public float delayTime = 5;
	public string nextLevel; 

	IEnumerator Start () {
		yield return new WaitForSeconds(delayTime);
	
		SceneManager.LoadScene(nextLevel);

	}

}