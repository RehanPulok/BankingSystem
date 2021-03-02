using System;

public class IdGenerator
{
	public int id = 100;

	public IdGenerator()
	{
		id = id + 1;
		return id;
	}
}
