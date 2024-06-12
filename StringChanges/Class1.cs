namespace StringTutorial;

public class StringChanges
{
	public string MyString { get; set; }
	public string GenerateString(int x) 
	{
		for (int i = 0; i < x; i++)
		{
			MyString += i.ToString();
		}
		return MyString;
	}
}
