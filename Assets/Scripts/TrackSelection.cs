using UnityEngine;
using System.Collections;

public class TrackSelection : MonoBehaviour {

	public AudioClip track1;
	public AudioClip track2;
	public AudioClip track3;
	public AudioClip track4;

	private AudioSource source;

	// Use this for initialization
	void Start () 
	{
		source = GetComponent<AudioSource> ();
	}

	void trackSelected(int track)
	{
		if (track == 1) 
		{
			source.clip = track1;
			source.Play();
		}

		if (track == 2) 
		{
			source.clip = track2;
			source.Play();
		}

		if (track == 3) 
		{
			source.clip = track3;
			source.Play();
		}

		if (track == 4) 
		{
			source.clip = track4;
			source.Play();
		}
	}
}
