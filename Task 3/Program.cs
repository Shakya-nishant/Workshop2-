byte b = 255;                    
short  s = -32768;                 
int    i = 100000;          
long   l = 999999999999L;
float  f = 3.14f;         
double d = 2.71828;
decimal m = 123.456m; 
char   c = 'A';
bool   ok = true;

        
string intAsString = 42.ToString();               
double doubleFromString = double.Parse("3.14");    


Console.WriteLine($"byte   : {b}   (type: {b.GetType()})");
Console.WriteLine($"short  : {s}   (type: {s.GetType()})");
Console.WriteLine($"int    : {i}   (type: {i.GetType()})");
Console.WriteLine($"long   : {l}   (type: {l.GetType()})");
Console.WriteLine($"float  : {f}   (type: {f.GetType()})");
Console.WriteLine($"double : {d}   (type: {d.GetType()})");
Console.WriteLine($"decimal: {m}   (type: {m.GetType()})");
Console.WriteLine($"char   : {c}   (type: {c.GetType()})");
Console.WriteLine($"bool   : {ok}   (type: {ok.GetType()})");

Console.WriteLine($"int → string : {intAsString}");
Console.WriteLine($"\"3.14\" → double : {doubleFromString}");