import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.IOException;
import java.util.Random;

import javax.imageio.ImageIO;
import javax.swing.*;


public class GamePanel extends JPanel implements ActionListener
{
	//Game Variables
	public final int TileSize = 50;
	public final int ScreenWidth = 600;//MaxScreenCol
	public final int ScreenHeight = 600;//MaxScreenRow
	public boolean runCheck;
	private BufferedImage [] PlanetPicture;
	private BufferedImage Background;
	//Planet Variables
	private Random ran;
	public int PlanetX;
	public int PlanetY;
	private int Planet;
	public int PointsEarned;
	public Timer Timer;
	//Class Variables
	private Player player;
	private CollisionHandler Collision = new CollisionHandler(this);
	//userInput
	private UserInput Movement = new UserInput();
	
	
	public GamePanel()
	{
		this.setPreferredSize(new Dimension(ScreenWidth, ScreenHeight));
		this.setBackground(Color.black);
		this.setDoubleBuffered(true);
		//Listen for users WASD
		this.addKeyListener(Movement);
		//only when in focus
		this.setFocusable(true);
		gameStart();
	}
	
	public void setPlanet()
	{
		//Random Generates the Planets X and Y
		PlanetX = ran.nextInt((int)(ScreenWidth/TileSize))*TileSize;
		PlanetY = ran.nextInt((int)(ScreenHeight/TileSize))*TileSize;
		//randomly picks new planet
		Planet = ran.nextInt(2);
	}
	
	
	public void gameStart()
	{
		ran = new Random();
		player = new Player(this,Movement);
		PointsEarned = 0;
		//Sets point for snake
		setPlanet();
		runCheck = true;
		//Does something every x milliseconds
		//To keep the program running
		Timer = new Timer(100,this);
		Timer.start();
		getImages();
		player.getGlorpyImage();
	}
	
	
	public void paintComponent(Graphics g)
	{
		if(runCheck)
		{
			//Draws Background
			g.drawImage(Background,0,0,ScreenWidth,ScreenHeight,null);
			//This makes the Grid
			for(int i = 0; i<ScreenWidth; i++)
			{
				//Columns
				g.drawLine(i*TileSize, 0, i*TileSize,ScreenHeight);
				//Rows
				g.drawLine( 0, i*TileSize,ScreenWidth,i*TileSize);
			}
			
			//Calls the player draw functiond
			player.draw(g);
			
			//Draws Planet
			g.drawImage(PlanetPicture[Planet],PlanetX, PlanetY, TileSize, TileSize,null);
			g.dispose();
		}
		else
		{
			//restarts or ends game
			restartGame();
		}
	}
	
	
	public void getImages()
	{
		PlanetPicture = new BufferedImage[2];
		try
		{	
			//Gets Background image
			Background = ImageIO.read(getClass().getResourceAsStream("/Assets/SpaceBackground.png"));
			//Saves the Planet PNG image into Planet picture array
			PlanetPicture[0] = ImageIO.read(getClass().getResourceAsStream("/Assets/Planets/Planet1.png"));
			PlanetPicture[1] = ImageIO.read(getClass().getResourceAsStream("/Assets/Planets/Planet2.png"));
		}
		catch(IOException e)
		{
			e.printStackTrace();
		}
	}
	
	//restart or ends game
	public void restartGame()
	{
		int yesNo = JOptionPane.showConfirmDialog(null, "You Earned: " + PointsEarned+ " Points Good Job!" +"\nDo you want to try again?", "Confirm",
		        JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);

		if (yesNo == JOptionPane.YES_OPTION) 
		{
			Movement.RestartPressed=false;
			Timer.stop();
			gameStart();
		} 
		else
		{
			//Final message For game end
			JOptionPane.showMessageDialog(null, "Good bye!" );
			System.exit(0);
		} 
	}
	
	@Override
	public void actionPerformed(ActionEvent e) 
	{
		// TODO Auto-generated method stub
		if(runCheck)
		{
			player.update();
			Collision.Contact(player);
			
		}
		repaint();
		//Restarts the game if R is pressed
		if(Movement.RestartPressed==true)
		{ 
			runCheck=false;
			restartGame();//restarts or ends game
		}
	}
}



