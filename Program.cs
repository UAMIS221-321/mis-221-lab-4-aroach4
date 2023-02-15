// See https://aka.ms/new-console-template for more information


DisplayMenu();
int menuChoice = int.Parse(System.Console.ReadLine());
RouteEm(menuChoice);



static void Print(){
    System.Console.Write("o");
}
// normal pyramid methods
static void PrintRow(int count){
   for (int i = 1; i <= count; i++){
    PrintColumn(i);
    System.Console.WriteLine();
   }
}

static void PrintColumn(int count){
   int track = 0;
   while  (track < count){
        Print();
        track++;
    }
}

static void GetFull(){
    Random rnd = new Random();
    int count = rnd.Next(7)+3;
    PrintRow(count);
}

//normal pyramid end

// partial pyramid methods



static void PartialPrint(){
    Random rnd = new Random();
    int number = rnd.Next(2);
    if (number == 1){
    System.Console.Write("o");
    }
    else{
        System.Console.Write(" ");
    }
}

static void PartialPrintColumn(int count){
    int track = 0;
   while  (track < count){
        PartialPrint();
        track++;
    }
}

static void PartialPrintRow(int count){
    for (int i = 1; i <= count; i++){
    PartialPrintColumn(i);
    System.Console.WriteLine();
   }
}

static void GetPartial(){
    Random rnd = new Random();
    int count = rnd.Next(7)+3;
    PartialPrintRow(count);
}
//menu choices

static void DisplayMenu(){
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static void RouteEm(int menuChoice){
    if(menuChoice==1){
        GetFull();
    }
    else if(menuChoice ==2){
        GetPartial();
    }
    else if(menuChoice != 3){
       System.Console.WriteLine("Invalid");
       DisplayMenu();
       RouteEm(int.Parse(Console.ReadLine()));
       }
}