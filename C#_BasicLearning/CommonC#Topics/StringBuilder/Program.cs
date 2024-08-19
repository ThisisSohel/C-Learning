


using System.Text;

//StringBuilder stringBuilder = new StringBuilder("Hello Worldfdgfdgddfdfgfdgdf", 20);
//stringBuilder.Append("yttiui");
//stringBuilder.Insert(1, "ttt");
//stringBuilder.Remove(1, 3);
//stringBuilder.Replace("Hello", "Hi");
//Console.WriteLine(stringBuilder);

StringBuilder st1 = new StringBuilder();
st1.Append("Hello");
Console.WriteLine(st1);
StringBuilder st2 = new StringBuilder();

st2 = st1;

st2.Append("Hi");
Console.WriteLine(st2);
Console.WriteLine(st1);

int x = 0;
int y = 2;

var r = x > y ? "X is greater than Y" : "Y is gtreater than X";
Console.WriteLine(r);
