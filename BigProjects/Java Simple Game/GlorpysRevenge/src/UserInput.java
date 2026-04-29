
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class UserInput implements KeyListener
{
	public boolean UpPressed;
	public boolean DownPressed;
	public boolean LeftPressed;
	public boolean RightPressed;
	public boolean RestartPressed;

	@Override
	public void keyTyped(KeyEvent e) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void keyPressed(KeyEvent e) 
	{
		int code = e.getKeyCode();
		//Checks Your key press codes
		if(code == KeyEvent.VK_W ||code == KeyEvent.VK_UP) 
		{
			UpPressed = true;
		}
		if(code == KeyEvent.VK_S ||code == KeyEvent.VK_DOWN) 
		{
			DownPressed = true;
		}
		if(code == KeyEvent.VK_A ||code == KeyEvent.VK_LEFT) 
		{
			LeftPressed = true;
		}
		if(code == KeyEvent.VK_D ||code == KeyEvent.VK_RIGHT) 
		{
			RightPressed = true;
		}
		if(code == KeyEvent.VK_R) 
		{
			RestartPressed = true;
		}
		
		
	}

	@Override
	public void keyReleased(KeyEvent e) 
	{
		int code = e.getKeyCode();
		
		if(code == KeyEvent.VK_W||code == KeyEvent.VK_UP) 
		{
			UpPressed = false;
		}
		if(code == KeyEvent.VK_S||code == KeyEvent.VK_DOWN) 
		{
			DownPressed = false;
		}
		if(code == KeyEvent.VK_A ||code == KeyEvent.VK_LEFT) 
		{
			LeftPressed = false;
		}
		if(code == KeyEvent.VK_D ||code == KeyEvent.VK_RIGHT) 
		{
			RightPressed = false;
		}
		if(code == KeyEvent.VK_R) 
		{
			//RestartPressed = false;
		}
	}

}
