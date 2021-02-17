using Mirror;
using UnityEngine.UI;

public class MyNetworkManager : NetworkManager
{
    public Text debugLog;
    private string ConText;


    private void Start()
    {
        ConText = "";
    }

    public override void OnStartServer()
    {
        ConText += "Server Started\n";
        debugLog.text = ConText;
    }

    public override void OnStopServer()
    {
        ConText += "Server Stopped\n";
        debugLog.text = ConText;
    }

    public override void OnStartClient()
    {
        ConText += "Client Started\n";
        debugLog.text = ConText;
    }

    public override void OnStopClient()
    {
        ConText += "Client Stopped\n";
        debugLog.text = ConText;
    }
}