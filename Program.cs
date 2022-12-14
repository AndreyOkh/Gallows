// ИГРА ВИСЕЛИЦА
using functions;
// ---------------------Объявляем переменные---------------------
string[] array = {"алмаз", "берег", "горох", "дверь", "живот", "закон", "икота", "кучер"};
int amountArray = array.Length;
int randomWordIndex = new Random().Next(1, amountArray);
string randomWord = array[randomWordIndex];
char[] arrayUserWord = new char[5];
int countUserError = 0;
int maxUserError = 9;
int countUserWin = 0;

char[] arrayRandomWord = array[randomWordIndex].ToCharArray();
int arrayRandomWordLength = arrayRandomWord.Length;

// ---------------------Игра---------------------
Console.WriteLine($"Я загадал слово из 5 букв, попробуйте угадать что это за слово, что бы угадать у вас есть {maxUserError} попыток. Слово существительное, нарицательное, в единственном числе.");

while (countUserError < maxUserError && countUserWin < arrayRandomWordLength) {
    bool userWin = false;
    bool exit = false;
    Console.WriteLine();
    Console.Write("Введите букву: ");
    char userWord = Console.ReadKey().KeyChar;
    Console.WriteLine();
    int count = 0;
    // ---------------------Проверяем была ли введена эта буква ранее---------------------
    int i = 0;
    while (i < arrayUserWord.Length) {
        if (arrayUserWord[i] == userWord) {
            Console.WriteLine("Такая буква уже была");
            exit = true;
        }
        i++;
    }
    if (exit == true) {
        continue;
    }

    // ---------------------Проверяем есть ли буква введенная пользователем в загаданном слове---------------------
    while (count < arrayRandomWordLength) {
        if (userWord == arrayRandomWord[count]) {
            arrayUserWord[count] = userWord;
            userWin = true;
            countUserWin++;
            Console.WriteLine("Верно!");
        }
        count++;
    }
    // ---------------------Если буква есть показываем какую позицию она занимает---------------------
    if (userWin == true) {
        var userWordClass = new Word();
        userWordClass.PositionWord(arrayUserWord);
    }
    // ---------------------Если буквы нет---------------------
    if (userWin == false) {
        Console.WriteLine();
        Console.WriteLine("Нет такой буквы!");
        countUserError++;
        var err = new Error();
        err.PrintErr(countUserError);
        var userWordClass = new Word();
        userWordClass.PositionWord(arrayUserWord);
    }
    
}
// ---------------------Конец игры---------------------
if (countUserError == maxUserError) {
    Console.WriteLine();
    Console.WriteLine($"Вы проиграли, загаданое слово {randomWord}.");
}
if (countUserWin == arrayRandomWordLength) {
    Console.WriteLine();
    Console.WriteLine($"Вы победили, загаданое слово {randomWord}.");
}
