// introduce you with my prejetc where i give and take the input form you about name......
System.Console.WriteLine("===========================================");
System.Console.WriteLine();
System.Console.WriteLine("Hi welcome to Rock Paper scissor game......");
System.Console.WriteLine();
System.Console.WriteLine("===========================================");
System.Console.WriteLine();
System.Console.WriteLine("Please enter player name!");
string player = Console.ReadLine();
System.Console.WriteLine();
/*System.Console.WriteLine("RULES ARE VERY SIMPLE WHO EVER SCORE 3 POINT FIRST WIIL WIN!");
Console.WriteLine();
System.Console.WriteLine("BEST OF LUCK");*/
System.Console.WriteLine();
System.Console.WriteLine("===========================================");
System.Console.WriteLine();
System.Console.WriteLine("Welcome to our game! " + player );
System.Console.WriteLine();
System.Console.WriteLine("RULES ARE VERY SIMPLE WHO EVER SCORE 3 POINT FIRST WIIL WIN!");
Console.WriteLine();
System.Console.WriteLine("BEST OF LUCK");


// creating a program that contain which is responsible for creating the random thing and that can count the player point...

Random random = new Random();
int playerpoint = 0;
int enemypoint = 0;

// while loop that can run the program endless without interruption...

while(playerpoint != 3 && enemypoint != 3){
    System.Console.WriteLine();
    System.Console.WriteLine("===========================================================");
    System.Console.WriteLine("please enter 'r' for rock, 'p' for paper & 's' for scissor.");
    System.Console.WriteLine("===========================================================");
    string playerchoice = Console.ReadLine();
    

    int enemychoice = random.Next(0,3);
    System.Console.WriteLine("playerpoint - " + playerpoint + " enemypoint - " + enemypoint);
    if (enemychoice == 0){
        System.Console.WriteLine("enemy choose the ||rock!||");
        switch(playerchoice){
            case "r" :
            {
                System.Console.WriteLine("tie! ");
                break;
            }
            case "p" :
            {
                System.Console.WriteLine("you win! ");
                playerpoint++;
                break;
            }
            case "s" :
            {
                System.Console.WriteLine("you lose! ");
                enemypoint++;
                break;
            }
        }
    }
    
    else if (enemychoice == 1){
        System.Console.WriteLine("enemy choose the ||paper!||");
         switch(playerchoice){
            case "r" :
            {
                System.Console.WriteLine("you lose!  ");
                enemypoint++;
                break;
            }
            case "p" :
            {
                System.Console.WriteLine("tie! ");
                
                break;
            }
            case "s" :
            {
                System.Console.WriteLine("you win! ");
                playerpoint++;
                break;
            }
        }
    }
    else if (enemychoice == 2){
        System.Console.WriteLine("enemy choose the ||scissor||");
         switch(playerchoice){
            case "r" :
            {
                System.Console.WriteLine("you win! ");
                playerpoint++;
                break;
            }
            case "p" :
            {
                System.Console.WriteLine("you lose! ");
                enemypoint++;
                break;
            }
            case "s" :
            {
                System.Console.WriteLine("tie! ");
                break;
            }
        }
    }
    else{
        System.Console.WriteLine("please enter vaalid choice");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
if (playerpoint < enemypoint){
    System.Console.WriteLine("you loose! (better luck next time :)");
}   
else{
    System.Console.WriteLine("you win! congratulation...\n");
}
