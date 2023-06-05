
using BooksProblem;

const int MaxN = 1000;
const int MaxX = 100000;
const int MaxCiSi = 1000;

var r = new Random();

int n = r.Next(1, MaxN);
int x = r.Next(1, MaxX);

int[] c = new int[n];
int[] s = new int[n];

for (int i = 0; i < n; i++)
{
    c[i] = r.Next(1, MaxCiSi);
    s[i] = r.Next(1, MaxCiSi);
}

int maxPages = Problem.MaxPages(n, x, c, s);
Console.WriteLine("Maximum number of pages: " + maxPages);