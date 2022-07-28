
string text = " Este tipo de-variável é alfanum ";

#region Contains, ToUpper and ToLower
// Console.WriteLine(text.Contains("Alfanum", StringComparison.Ordinal));
// Console.WriteLine(text.ToUpper());
// Console.WriteLine(text.ToLower());
#endregion

#region IndexOf and LastIndexOf
//Console.WriteLine(text.IndexOf('c'));
//Console.WriteLine(text.IndexOf('e'));
//Console.WriteLine(text.LastIndexOf("tipo"));
#endregion

#region Insert and Replace
//Console.WriteLine(text.Insert(0, "TEST: "));
//Console.WriteLine(text.Replace("TEST: ", ""));
#endregion

#region Length and Substring
//Console.WriteLine(text.Length);
//Console.WriteLine(text.Substring(22));
#endregion

#region Split
//char[] sep = { ' ', '-' };
//string[] textSplitted = text.Split(sep);

//foreach (var halfStr in textSplitted)
//{
//    Console.WriteLine(halfStr);
//}
#endregion

#region StartsWith and EndsWith
//Console.WriteLine(text.StartsWith("Este"));
//Console.WriteLine(text.EndsWith("alfanum"));
#endregion

#region Trim
//Console.WriteLine($"{text}|");        
//Console.WriteLine(text.Trim(' '));
//Console.WriteLine($"{text.TrimStart(' ')}|");
//Console.WriteLine($"{text.TrimEnd(' ')}|");
#endregion

#region CompareTo and Equals
string anotherText = " Este tipo de-variável é alfanum ";
Console.WriteLine(text.CompareTo(anotherText));
Console.WriteLine(text.Equals(text));
#endregion
