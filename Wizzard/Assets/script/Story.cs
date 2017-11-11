using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Story : MonoBehaviour {

	enum States
	{
		kidnap,
		deth,
		torture,
		bedEnd,
		goodEnd


	}

	States state= States.kidnap;
	public Text mainText;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		if (state == States.kidnap) {
			Kidnap ();
		}
		if (state == States.deth) {
			Death ();
		}
	}

	void Kidnap()
	{
		mainText.text = "Вы богатый миллиардер и вас похители, и положили в богажник. Ворам нужны коды о вашего сейфа/n" +
		"(П)Попытаться выбраться/n (Н)Ждать помощи";
		if (Input.GetKeyDown(KeyCode.G))
		{
			state = States.deth;
				
		}

		if (Input.GetKeyDown(KeyCode.Y))
		{
			state = States.torture;

		}

					
	}

	void Death()
	{
		mainText.text = "Вы попытались сбежать и вас убили. КОНЕЦ!/n(З)Заново.";
		if (Input.GetKeyDown (KeyCode.P)) 
		{

			state = States.kidnap;
		}
			
		
	}
	void Torture()
	{
		mainText.text = "Вы ждали  много ремени и вас привезли в лес на пытку";
		if (Input.GetKeyDown (KeyCode.P)) 
		{

			state = States.kidnap;
		}


	}
}
