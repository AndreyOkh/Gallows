namespace functions;

// --------------------Печатаем виселицу в консоль--------------------
public class Error {
    public void PrintErr (int countUserError) {
        Console.Clear();
        int i = 0;
        // --------------------Девятая ошибка--------------------
        if (countUserError > 8) {
            Console.SetCursorPosition(11, 13);
            Console.Write("\\");
            Console.SetCursorPosition(12, 14);
            Console.Write("\\");
            Console.SetCursorPosition(13, 15);
            Console.Write("\\");
            Console.SetCursorPosition(9, 6);
            Console.Write("х");
            Console.SetCursorPosition(11, 6);
            Console.Write("х");
            Console.SetCursorPosition(10, 7);
            Console.Write("~");
        }

        // --------------------Восьмая ошибка--------------------
        if (countUserError > 7) {
            Console.SetCursorPosition(9, 13);
            Console.Write("/");
            Console.SetCursorPosition(8, 14);
            Console.Write("/");
            Console.SetCursorPosition(7, 15);
            Console.Write("/");
        }

        // --------------------Седьмая ошибка--------------------
        if (countUserError > 6) {
            Console.SetCursorPosition(11, 9);
            Console.Write("\\");
            Console.SetCursorPosition(12, 10);
            Console.Write("\\");
            Console.SetCursorPosition(13, 11);
            Console.Write("\\");
        }

        // --------------------Шестая ошибка--------------------
        if (countUserError > 5) {
            Console.SetCursorPosition(9, 9);
            Console.Write("/");
            Console.SetCursorPosition(8, 10);
            Console.Write("/");
            Console.SetCursorPosition(7, 11);
            Console.Write("/");
        }

        // --------------------Пятая ошибка--------------------
        if (countUserError > 4) {
            Console.SetCursorPosition(10, 9);
            Console.Write("|");
            Console.SetCursorPosition(10, 10);
            Console.Write("|");
            Console.SetCursorPosition(10, 11);
            Console.Write("|");
            Console.SetCursorPosition(10, 12);
            Console.Write("|");
        }

        // --------------------Четвертая ошибка--------------------
        if (countUserError > 3) {
            Console.SetCursorPosition(10, 3);
            Console.Write("|");
            Console.SetCursorPosition(10, 4);
            Console.Write("|");
            Console.SetCursorPosition(9, 5);
            Console.Write("_");
            Console.SetCursorPosition(10, 5);
            Console.Write("_");
            Console.SetCursorPosition(11, 5);
            Console.Write("_");
            Console.SetCursorPosition(12, 6);
            Console.Write('\\');
            Console.SetCursorPosition(12, 7);
            Console.Write("/");
            Console.SetCursorPosition(8, 6);
            Console.Write("/");
            Console.SetCursorPosition(8, 7);
            Console.Write("\\");
            Console.SetCursorPosition(9, 8);
            Console.Write("¯");
            Console.SetCursorPosition(10, 8);
            Console.Write("¯");
            Console.SetCursorPosition(11, 8);
            Console.Write("¯");
        }

        // --------------------Третья ошибка--------------------
        if (countUserError > 2) {
            i = 0;
            while (i < 15) {
                Console.SetCursorPosition(i, 2);
                Console.Write("_");
                i++;
            }
        }

        // --------------------Вторая ошибка--------------------
        if (countUserError > 1) {
            i = 3;
            while (i < 20) {
                Console.SetCursorPosition(2, i);
                Console.Write("|");
                i++;
            }
        }

        // --------------------Первая ошибка--------------------
        
        if (countUserError > 0) {
            i = 0;
            while (i < 20) {
                Console.SetCursorPosition(i, 20);
                Console.Write("¯");
                i++;
            }
        }


    }
}

// --------------------Отображение позиций букв в слове--------------------
public class Word {
    public void PositionWord(char[] arrayUserWord) {
        Console.WriteLine();
        int i = 0;
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
    }
}