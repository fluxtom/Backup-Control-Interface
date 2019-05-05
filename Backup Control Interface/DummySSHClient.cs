using System;

public class DummySSHClient
{
    private readonly string host;
    private readonly string username;
    private readonly string password;
    
	public DummySSHClient(string host, string username, string password)
	{
	    this.host = host;
	    this.username = username;
	    this.password = password;
	}   

    public SSHCommand RunCommand(string commandString)
    {
        var commandToReturn = new SSHCommand
        {
            CommandText = commandString,
            //Error = $"This is an error. hostname: {host}. username: {username}. password: {password}.",
            Result = "Result 1" + Environment.NewLine + "Result 2" + Environment.NewLine + "Result 3"
        };
        return commandToReturn;
    }

    public void Connect()
    {
            }

    public void Disconnect()
    {

    }


}
