import javax.swing.JFrame;

public class Main {

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
				JFrame game = new JFrame();
				//want to set icon as alien
				game.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
				game.setResizable(false);
				game.setTitle("Glorpy's Revenge");
				GamePanel gamePanel = new GamePanel();
				game.add(gamePanel);
				game.pack();
				game.setLocationRelativeTo(null);
				game.setVisible(true);
	}
}
