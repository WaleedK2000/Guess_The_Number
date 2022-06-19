using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GuessNumberGame : MonoBehaviour {

	public InputField input;
	public Text infoText;

	private int guessNumber;
	private int usersGuess;

	// Use this for initialization
	void Start () {
		guessNumber = Random.Range (0, 100);

	}
	
	// Update is called once per frame
	public void checkGuess(){
		usersGuess = int.Parse(input.text);

		if (usersGuess == guessNumber) {
			infoText.text = "You Guessed The number!";
		} else if (usersGuess > guessNumber) {
			infoText.text = "This number is greater than the guess number";
		} else if (usersGuess < guessNumber) {
			infoText.text = "Your number is lower than the guess number";
		}

		input.text = "";

	}
}
