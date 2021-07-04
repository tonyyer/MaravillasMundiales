using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {

	public InputField emailText;
	public InputField passwordText;
	public Text responseText;


	string authphpurl = "http://localhost/videojuego-2d/auth.php";

	public void handleLoginButtonClick(){
		StartCoroutine(PostDataForLogin ());
	}


	public void handleRegisterButtonClick(){
		StartCoroutine(PostDataForRegister ());
	}

	IEnumerator PostDataForLogin(){
		Debug.Log("PostDataForLogin!");
		
		WWWForm form = new WWWForm();
		form.AddField("email", emailText.text);
		form.AddField("pwd", passwordText.text);

		var url = authphpurl+"?action=login";

		UnityWebRequest www = UnityWebRequest.Post(url, form);

		yield return www.SendWebRequest();

		Debug.Log ("Response:"+www.downloadHandler.text);

		if(www.isNetworkError || www.isHttpError) {
			Debug.Log(www.error);
			responseText.text = www.error;
		}
		else {

			Debug.Log("Form upload complete!");

			JSONNode jsonNode = SimpleJSON.JSON.Parse(www.downloadHandler.text);
			Debug.Log("success : "+jsonNode["success"]);
			Debug.Log("message : "+jsonNode["msg"]);


			responseText.text = jsonNode ["msg"];

            if(jsonNode["success"] == true){
                SceneManager.LoadScene("Menu");
            }
		}

	}

	IEnumerator PostDataForRegister(){
		Debug.Log("PostDataForRegister!");

		WWWForm form = new WWWForm();
		form.AddField("email", emailText.text);
		form.AddField("pwd", passwordText.text);

		var url = authphpurl+"?action=register";

		UnityWebRequest www = UnityWebRequest.Post(url, form);

		yield return www.SendWebRequest();

		Debug.Log ("Response:"+www.downloadHandler.text);

		if(www.isNetworkError || www.isHttpError) {
			Debug.Log(www.error);
			responseText.text = www.error;
		}
		else {

			Debug.Log("Form upload complete!");

			JSONNode jsonNode = SimpleJSON.JSON.Parse(www.downloadHandler.text);
			Debug.Log("success : "+jsonNode["success"]);
			Debug.Log("message : "+jsonNode["msg"]);


			responseText.text = jsonNode ["msg"];
		}

	}

}
