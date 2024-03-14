char[,] chars = {
                        { 'q', 'w', 'e' },
                        { 'r', 't', 'y' }
                    };

string str = "";

foreach (var mas in chars)
{
    str += string.Concat(mas);
}


Console.WriteLine(str);