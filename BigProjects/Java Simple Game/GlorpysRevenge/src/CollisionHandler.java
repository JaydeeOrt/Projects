
public class CollisionHandler 
{
	private GamePanel Panel;
	public CollisionHandler(GamePanel panel)
	{
		Panel = panel;
	}
	
	
	public void Contact(Player player)
	{
		//Eat planet and gain a point and size
		if(player.PlayerX[0] == Panel.PlanetX &&player.PlayerY[0] == Panel.PlanetY)
		{
			player.Size +=1;
			Panel.PointsEarned +=1;
			Panel.setPlanet();
		}
		
		
		//Checks For Head touching itself
		for(int i = player.Size; i>0;i--)
		{
			if((player.PlayerX[0] == player.PlayerX[i]) && (player.PlayerY[0] == player.PlayerY[i]))
			{
				Panel.runCheck=false;
			}
		}
		
		
		//Check if Touch Left or Right Screen
		if(player.PlayerX[0]<0 )
		{
			Panel.runCheck=false;
		}
		if(player.PlayerX[0]>Panel.ScreenWidth-Panel.TileSize)
		{
			Panel.runCheck=false;
		}
		
		
		//Check if Touch Right Top or Bottom
		if(player.PlayerY[0]<0 )
		{
			Panel.runCheck=false;
		}
		if(player.PlayerY[0]>Panel.ScreenHeight-Panel.TileSize)
		{
			Panel.runCheck=false;
		}
		
		//Game Stop if these things happen
		if(!Panel.runCheck)
		{
			Panel.Timer.stop();
			
		}

	}
}
