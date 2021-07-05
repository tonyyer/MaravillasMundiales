using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public GameObject menu;
	public int Score;
//	public int Score;
	public SpriteRenderer help;

	public bool GameStart;

	public TextMesh bestScore;
	public TextMesh ScoreLabel;

	public Animator player;

	public CheckerTime ct;

	Animator anim;
	
	void Start()
	{
		anim = GetComponent<Animator>();
		GameStart = false;
		Score = 0;
		bestScore.text = PlayerPrefs.GetInt("Score",0).ToString();
	}

	void Update()
	{
		if (GameStart && Time.fixedTime % 2 == 0 && ct.isOut)
		{
			anim.speed = Random.Range(1,3);
		}
	}

	void OnMouseUp()
	{
		if (!GameStart && help.color.a == 0)
		{
			GameStart = true;
			Score = 0;
			ScoreLabel.text = Score.ToString();
			GetComponent<Collider2D>().enabled = false;

			menu.SetActive(false);
			ScoreLabel.gameObject.SetActive(true);

			player.Play("Player");
			anim.Play("Earth");
		}
	}

	void IncreaseScore()
	{
		Score++;
		ScoreLabel.text = Score.ToString();
	}

	public void GameOver()
	{
		if (Score > PlayerPrefs.GetInt("Score",0))
		{
			PlayerPrefs.SetInt("Score",Score);
			bestScore.text = Score.ToString();
		}

		menu.SetActive(true);
		ScoreLabel.gameObject.SetActive(false);
		anim.Play("Idle");
		player.Play("Idle");
		Time.timeScale = 1;
		Application.LoadLevel(0);
	}
}