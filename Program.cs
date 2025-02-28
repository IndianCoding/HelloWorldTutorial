String a = "a";
String b = "b";
String c = "c";
String d = "d";
String e = "e";
String f = "f";
String g = "g";
String h = "h";
String i = "i";
String j = "j";
String k = "k";
String l = "l";
String m = "m";
String n = "n";
String o = "o";
String p = "p";
String q = "q";
String r = "r";
String s = "s";
String t = "t";
String u = "u";
String v = "v";
String w = "w";
String x = "x";
String y = "y";
String z = "z";
String SPACE = " ";

String A = "A";
String B = "B";
String C = "C";
String D = "D";
String E = "E";
String F = "F";
String G = "G";
String H = "H";
String I = "I";
String J = "J";
String K = "K";
String L = "L";
String M = "M";
String N = "N";
String O = "O";
String P = "P";
String Q = "Q";
String R = "R";
String S = "S";
String T = "T";
String U = "U";
String V = "V";
String W = "W";
String X = "X";
String Y = "Y";
String Z = "Z";

String firstPart = h.ToString() + e;
String firstLetter = l + l.ToString();
String secondPart = o.ToString();

String space = SPACE.ToString();
String thirdPart = w.ToString() + o;
String thirdLetter = r + l.ToString();
String fourthPart = d.ToString();

String hello = firstPart + firstLetter + firstLetter + secondPart;
String world = thirdPart + thirdLetter + fourthPart;

String fullMessage = hello + space + world;

String part1 = fullMessage.Substring(0, 5);
String part2 = fullMessage.Substring(6, 5);
String finalMessage = part1 + space + part2;

String incrediblyStupid = finalMessage + fullMessage.Length.ToString() + fullMessage.ToUpper();

Console.WriteLine(incrediblyStupid.ToString());
