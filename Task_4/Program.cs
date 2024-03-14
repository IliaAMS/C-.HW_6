string str_ori = "Я люблю учиться";

string str_res = "";

string[] words = str_ori.ToLower().Split(' ');

for (int i = words.Length - 1; i >= 0; i--)
{
    str_res += words[i];
    if (i != 0)
    {
        str_res += " ";
    }
}

Console.WriteLine(str_res);