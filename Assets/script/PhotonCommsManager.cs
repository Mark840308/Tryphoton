using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonCommsManager : MonoBehaviour {

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
		Debug.Log ("join room success");
		// instantiate user avatar locally and spawns in remote instances
		//if (PhotonNetwork.isMasterClient)
		//{
	    //	PhotonNetwork.Instantiate ("HostVR", new Vector3 (0, 0, -4), Quaternion.identity, 0);
		//}
		//else
		//{
		//	PhotonNetwork.Instantiate ("ClienAR", new Vector3 (0, 0, 4), Quaternion.identity, 0);
		//}

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
