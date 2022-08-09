// ИГРА ВИСЕЛИЦА

// ---------------------Объявляем переменные---------------------
string[] array = {"алмаз", "берег", "вода", "горох", "дверь", "живот", "закон", "икота", "кучер"};
int amountArray = array.Length;
int randomWordIndex = new Random().Next(1, amountArray);
string randomWord = array[randomWordIndex];
char[] arrayUserWord = new char[5];
int countUserError = 0;
int maxUserError = 6;
int countUserWin = 0;

char[] arrayRandomWord = array[randomWordIndex].ToCharArray();
int arrayRandomWordLength = arrayRandomWord.Length;

// ---------------------Игра---------------------
Console.WriteLine("Я загадал слово из 5 букв, попробуйте угадать что это за слово, что бы угадать у вас есть 6 попыток. Слово существительное, нарицательное, в единственном числе.");

while (countUserError < maxUserError && countUserWin < arrayRandomWordLength) {
    bool userWin = false;
    bool exit = false;
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
            i = 0;
            // ---------------------Если буква есть показываем какую позицию она занимает---------------------
            while (i < arrayUserWord.Length) {
                if (arrayUserWord[i] != 0) {
                    Console.Write(arrayUserWord[i]);
                }
                else {
                    Console.Write("_");
                }
                i++;
            }
            Console.WriteLine();
            break;
        }
        count++;
    }
    if (userWin == false) {
        Console.WriteLine("Нет такой буквы!");
        countUserError++;
    }
    
}
if (countUserError == maxUserError) {
    Console.WriteLine($"Вы проиграли, загаданое слово {randomWord}");
}
if (countUserWin == arrayRandomWordLength) {
    Console.WriteLine($"Вы победили, загаданое слово {randomWord}");
}

//Console.WriteLine(arrayRandomWord[0]);