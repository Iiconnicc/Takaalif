using System.ComponentModel.Design;

int m = 0, n = 0;
Console.WriteLine("عدد اول را وارد کنید");
string sstring = Console.ReadLine();
m = Convert.ToInt32(sstring);
Console.WriteLine("عدد دوم را وارد کنید");
string fstring = Console.ReadLine();
n = Convert.ToInt32(fstring);
Console.WriteLine("نتیجه:         ");
for (int i = m; i < n; i++)
{
	int x = i, y = 2;

		while (true)
	{
		if (x == y)
		{
			Console.WriteLine(x);
			break;
		}
		else if (x % y == 0)
			break;


		y++;

		
	}
}