using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class networkHandle : MonoBehaviour {

	public GameObject currentCamera;
	private GameObject currentPlayer;
	// Use this for initialization
	void Start () {
		PhotonNetwork.logLevel = PhotonLogLevel.Full;
		PhotonNetwork.ConnectUsingSettings ("0.1");
	}
	
	public void OnJoinedLobby()
	{
		PhotonNetwork.JoinRandomRoom();
	}

	public void OnJoinedRoom()
	{
		currentPlayer = PhotonNetwork.Instantiate("Avatar", currentCamera.transform.position, currentCamera.transform.rotation, 0);
	}

	void OnPhotonRandomJoinFailed()
	{
		Debug.Log("Can't join random room!");
		PhotonNetwork.CreateRoom(null);
	}

	void OnGUI()
	{
		GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
	}

}
