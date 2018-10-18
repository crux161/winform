using System;
using System.Windows.Forms;

public class CoreProcess : Form
{
	static public void Main ()
	{
		Application.Run (new CoreProcess ());
	}
	
	public CoreProcess ()
	{
		Text = "CoreProcess v1";
	}
}
