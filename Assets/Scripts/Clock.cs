using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
	[SerializeField] private Transform _hoursPivot;
	[SerializeField] private Transform _minutesPivot;
	[SerializeField] private Transform _secondsPivot;
	[SerializeField] private bool _isAnalog;
	
	private const float HoursToDegrees = -30f;
	private const float MinutesToDegrees = -6f;
	private const float SecondsToDegrees = -6f;
	
	private void Update()
	{
		ShowCurrentTime();
	}

	private void ShowCurrentTime()
	{
		if (_isAnalog)
		{
			var timeOfDay = DateTime.Now.TimeOfDay;
			_hoursPivot.rotation = Quaternion.Euler(0f, 0f, (float) timeOfDay.TotalHours * HoursToDegrees);
			_minutesPivot.rotation = Quaternion.Euler(0f, 0f, (float) timeOfDay.TotalMinutes * MinutesToDegrees);
			_secondsPivot.rotation = Quaternion.Euler(0f, 0f, (float) timeOfDay.TotalSeconds * SecondsToDegrees);
		}
		else
		{
			var now = DateTime.Now;
			_hoursPivot.rotation = Quaternion.Euler(0f, 0f, now.Hour * HoursToDegrees);
			_minutesPivot.rotation = Quaternion.Euler(0f, 0f, now.Minute * MinutesToDegrees);
			_secondsPivot.rotation = Quaternion.Euler(0f, 0f, now.Second * SecondsToDegrees);
		}
	}
}
