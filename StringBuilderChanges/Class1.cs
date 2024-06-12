using System.Text;

namespace StringBuilderTutorial;

public class StringBuilderChanges
{
	public StringBuilder MyString { get; set; } = new StringBuilder();
	public string GenerateString(int x) 
	{
		for (int i = 0; i < x; i++)
		{
			MyString.Append(i.ToString());
		}
		return MyString.ToString();
	}
}
