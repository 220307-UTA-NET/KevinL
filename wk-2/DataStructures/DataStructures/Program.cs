string[] arrayName = {"Kevin", "Dan", "Anu", "Kelly", "Trygg"};

string Nametwo = arrayName[2];
arrayName[1] = "Cam";

Array.Sort(arrayName);

//Enumerables
foreach (string name in arrayName)
{
    Console.WriteLine(name);
}

int[] myNumbers = {1,2,4,8,16,32,64,128};

Array.Sort(myNumbers);

foreach( int i in myNumbers)
{
    Console.WriteLine(i);
}

/*string[] arrayTwo = {"Jerome", "Christian", "Phirith"};

string[] result = arrayName + arrayTwo; 

IEnumberabel<string> resultArray = arrayName.Concat("Jerome");

foreach (string name in arrayName)
{
    Console.WriteLine(name);
}*/