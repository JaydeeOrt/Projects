import java.io.File;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;
public class AnimationStuff 
{
	private Person gojo;
	private Person toji;
	//private Person toji1;
	private Circle blue;
	private Circle red;
	private Circle purple;
	private Square floor;
	private Circle red1;
	private Circle infinity;
	private Circle infinity1;
	private Circle infinity2;
	private Circle infinity3;
	private Clip clip;
	private Canvas canvas = Canvas.getCanvas();
	String redClip = "ReversalRed.wav";
	String purpleClip="HollowPurpleAudio.wav";
	String honorClip="honored.wav";
	public AnimationStuff()
	{
		toji = new Person();
		floor = new Square();
		gojo = new Person();
		blue = new Circle();
		red = new Circle();
		red1= new Circle();
		purple = new Circle();
		infinity = new Circle();
		infinity1 = new Circle();
		infinity2 = new Circle();
		infinity3 = new Circle();
		//Set up infinity background
		//sets up first ring
		infinity.changeColor("domainBlue");
		infinity.moveHorizontal(-90);
		infinity.moveVertical(-75);
		infinity.changeSize(500);
		//sets up second ring
		infinity1.changeColor("domainWhite");
		infinity1.moveHorizontal(-60);
		infinity1.moveVertical(-35);//negative up  positive down
		infinity1.changeSize(430);
		//sets up third ring
		infinity2.changeColor("lavender");
		infinity2.moveHorizontal(5);//negative left positive right
		infinity2.moveVertical(25);//negative up  positive down
		infinity2.changeSize(300);
		//sets up fourth ring
		infinity3.changeColor("black");
		infinity3.moveHorizontal(75);//negative left positive right
		infinity3.moveVertical(100);//negative up  positive down
		infinity3.changeSize(150);
		//setup gojo
		gojo.moveVertical(243);
		gojo.moveHorizontal(-252);//Positive Right
		
		gojo.changeColor("magenta");
		//Toji
		toji.changeColor("white");
		toji.moveVertical(243);
		toji.moveHorizontal(450);
		//toji.moveVertical(15); smaller up
		//toji.moveHorizontal(-165);pos up
		//toji.moveVertical(243);
		//toji.moveHorizontal(425);
		
		//Floor
		floor.changeColor("green");
		floor.moveVertical(350);
		floor.moveHorizontal(-375);
		floor.changeSize(1000);
		//Red First
		red1.changeColor("red");
		red1.moveVertical(95);
		red1.moveHorizontal(-187);
		//Blue
		blue.moveHorizontal(-187);
		blue.moveVertical(-95);
		//Red
		red.changeColor("red");
		red.moveHorizontal(-187);
		red.moveVertical(300);
		//Hollow Purple
		purple.changeColor("purple");
		purple.moveVertical(95);
		purple.moveHorizontal(-187);
	}
	public void draw()
	{
		infinity.makeVisible();
		infinity1.makeVisible();
		infinity2.makeVisible();
		infinity3.makeVisible();
		toji.makeVisible();
		gojo.makeVisible();
		floor.makeVisible();
		
		//test
		//blue.makeVisible();
		//blue.makeVisible();
	}
	public void Animation()
	{
		Audio(redClip);
		gojo.slowMoveVertical(-225);//positive Down
		red1.makeVisible();
		//Toji rushes towards gojo
		for(int i =0;i<25;i++)
		{
			toji.moveLeft();
			toji.moveUp();
		}
		
		//Gets hit by red and gets pushed back
		for(int i=0;i<25;i++)
		{
			red1.moveRight();
			red1.moveDown();
			toji.moveRight();
			toji.moveDown();
		}
		for(int i=0;i<10;i++)
		{
			red1.moveRight();
			toji.moveRight();
		}
		red1.makeInvisible();
		canvas.wait(5000);
		AudioStop(redClip);
		Audio(purpleClip);
		for(int i=0;i<10;i++)
		{
			toji.moveLeft();
		}
		
		//Charges up hollow pruple
		blue.makeVisible();
		canvas.wait(500);
		red.makeVisible();
		canvas.wait(500);
		blue.changeColor("red");
		canvas.wait(500);
		red.changeColor("blue");
		canvas.wait(500);
		blue.changeColor("blue");
		canvas.wait(500);
		red.changeColor("red");
		canvas.wait(2000);
		blue.slowMoveVertical(190);
		red.slowMoveVertical(-205);
		blue.makeInvisible();
		red.makeInvisible();
		purple.makeVisible();
		canvas.wait(500);
		for(int i=0;i<12;i++)
		{
			purple.moveRight();
			purple.moveDown();
			toji.moveUp();
			toji.moveLeft();
		}
		purple.moveRight();
		purple.moveDown();
		for(int i=0;i<11;i++)
		{
			purple.moveRight();
			purple.moveDown();
			toji.moveRight();
			toji.moveDown();
		}
		for(int i=0;i<5;i++)
		{
			purple.moveRight();
			toji.moveRight();
		}
		toji.makeInvisible();
		purple.makeInvisible();
		canvas.wait(2000);
		AudioStop(purpleClip);
		Audio(honorClip);
		gojo.slowMoveVertical(225);
		canvas.wait(4000);
		AudioStop(honorClip);
	}
	//plays audio
	public void Audio(String file)
	{
		try 
		{
			File fileLocation = new File(file);
			if(fileLocation.exists())
			{
				AudioInputStream audioInput = AudioSystem.getAudioInputStream(fileLocation);
				clip = AudioSystem.getClip();
				clip.open(audioInput);
				clip.start();
			}
			else
			{
				System.out.println("Error");
			}
		}
		catch(Exception e)
		{
			System.out.println(e);
		}
	}
	public void AudioStop(String file)
	{
		if(clip!=null)
		{
			clip.stop();
			clip.close();
			clip=null;
		}
	}
}
