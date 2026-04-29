import java.awt.Color;
import java.awt.Graphics;
import java.awt.image.BufferedImage;
import java.io.IOException;


import javax.imageio.ImageIO;

public class Player
{
	private UserInput Movement;
	private GamePanel Panel;
	//Player Movement Variables
	//Snake Positon
	public int[]PlayerX = new int[144];
	public int[]PlayerY= new int[144];
	private char[]PlayerDirection = new char[244];
	//Direction and Size
	private char direction = 'D';
	public int Size = 2;
	//Glorpy Pictures
	private BufferedImage[] DirectionHead= new BufferedImage[4];//0 = up, 1=Down, 2=Left, 3 = Right
	private BufferedImage[] DirectionBody= new BufferedImage[2];//0 = Up,Down, 1=Left,Right
	private BufferedImage[] DirectionTail= new BufferedImage[4];//0 = up, 1=Down, 2=Left, 3 = Right
	//Current Glorpy pictures
	private BufferedImage CurrentHead= null;
	private BufferedImage CurrentBody= null;
	private BufferedImage CurrentTail= null;
	
	
	public Player(GamePanel panel, UserInput movement)
	{
		Panel = panel;
		Movement = movement;
	}
	
	
	public void draw(Graphics g)
	{
		//Sets The Direction For The Parts Of Glorpy
		//For Loop To draw the Snake based on size
		for(int i = 0; i<Size; i++)
		{
			//Draws Head of Snake 
			if(i==0)
			{
				//Draws Head
				g.drawImage(CurrentHead,PlayerX[0],PlayerY[0],Panel.TileSize, Panel.TileSize,null); 
			}
			else if(i ==Size-1)
			{
				//Gets Tail Direction
				switch(PlayerDirection[i])
				{
					case 'U':
						CurrentTail = DirectionTail[1];
						break;
						
					case 'D':
						//Down-
						CurrentTail = DirectionTail[0];
						break;
						
					case 'L':
						//Left
						CurrentTail = DirectionTail[3];
						break;
						
					case 'R':
						//Right
						CurrentTail = DirectionTail[2];
						break;
					
				}//end Switch
				//Draws Tail
				g.drawImage(CurrentTail,PlayerX[i],PlayerY[i],Panel.TileSize, Panel.TileSize,null);
			}
			else
			{
				//Gets Body Direction
				switch(PlayerDirection[i])
				{
					case 'U':
						CurrentBody = DirectionBody[0];
						break;
						
					case 'D':
						//Down-
						CurrentBody = DirectionBody[0];
						break;
						
					case 'L':
						//Left
						CurrentBody = DirectionBody[1];
						break;
						
					case 'R':
						//Right
						CurrentBody = DirectionBody[1];
						break;
					
				}//end Switch
				
				//Draws body of snake
				g.setColor(Color.red);
				g.drawImage(CurrentBody,PlayerX[i],PlayerY[i],Panel.TileSize, Panel.TileSize,null);
			}//end if
		}//end for
	}
	
	
	public void update()
	{
		//Sets Direction
		PlayerDirection[0] = direction;
		//Sets up the Snake
		for(int i = Size; i >0; i--)
		{
			PlayerX[i] = PlayerX[i-1];
			PlayerY[i] = PlayerY[i-1];
			PlayerDirection[i] =PlayerDirection[i-1];
		}

		//Gets Direction from key pressed
		if(Movement.UpPressed == true)
		{
			direction = 'U';
		}
		else if(Movement.DownPressed == true)
		{
			direction = 'D';
			
		}
		else if(Movement.LeftPressed == true)
		{
			direction = 'L';
		}
		else if(Movement.RightPressed == true)
		{
			direction = 'R';
		}//end if

		//Case Player Head movement by direction
		switch(direction)
		{
			case 'U':
				//Player Move Up
				PlayerY[0] -=Panel.TileSize;
				CurrentHead = DirectionHead[0];
				break;
			case 'D':
				//Player Move Down
				PlayerY[0] +=Panel.TileSize;
				CurrentHead = DirectionHead[1];
				break;
			case 'L':
				//Player Move Left
				PlayerX[0] -=Panel.TileSize;
				CurrentHead = DirectionHead[2];
				break;
			case'R':
				//Player Move Right
				PlayerX[0] +=Panel.TileSize;
				CurrentHead = DirectionHead[3];
				break;
				
		}//end case
	}
	
	
	public void getGlorpyImage()
	{
		try
		{	
			//Gets Head Picture
			DirectionHead[0] = ImageIO.read(getClass().getResourceAsStream("/Assets/Snake/GlorpyUp.png"));
			DirectionHead[1] = ImageIO.read(getClass().getResourceAsStream("/Assets/Snake/GlorpyDown.png"));
			DirectionHead[2] = ImageIO.read(getClass().getResourceAsStream("/Assets/Snake/GlorpyLeft.png"));
			DirectionHead[3] = ImageIO.read(getClass().getResourceAsStream("/Assets/Snake/GlorpyRight.png"));
			
			//Gets Body Picture
			DirectionBody[0] = ImageIO.read(getClass().getResourceAsStream("/Assets/Snake/BodyUpDown.png"));
			DirectionBody[1] = ImageIO.read(getClass().getResourceAsStream("/Assets/Snake/BodyLeftRight.png"));
			
			//Gets Tail Picture
			DirectionTail[0] = ImageIO.read(getClass().getResourceAsStream("/Assets/Snake/TailUp.png"));
			DirectionTail[1] = ImageIO.read(getClass().getResourceAsStream("/Assets/Snake/TailDown.png"));
			DirectionTail[2] = ImageIO.read(getClass().getResourceAsStream("/Assets/Snake/TailLeft.png"));
			DirectionTail[3] = ImageIO.read(getClass().getResourceAsStream("/Assets/Snake/TailRight.png"));
			
		}
		catch(IOException e)
		{
			e.printStackTrace();
		}
	}
}