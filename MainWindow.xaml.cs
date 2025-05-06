// MainWindow.xaml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SymbolTasks
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeTasks();
        }

        private void InitializeTasks()
        {
            for (int i = 1; i <= 30; i++)
            {
                TaskComboBox.Items.Add($"Задача {i}");
            }
            TaskComboBox.SelectedIndex = 0;
        }

        private void TaskComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OutputTextBox.Text = GetTaskDescription(TaskComboBox.SelectedIndex + 1);
        }

        private string GetTaskDescription(int taskNumber)
        {
            switch (taskNumber)
            {
                case 1: return "Введите массив символов из 10 элементов. Замените символы-цифры на символ '*'.";
                case 2: return "Введите массив символов из 11 элементов. Переведите все строчные буквы-символы в верхний регистр.";
                case 3: return "Введите массив символов из 12 элементов. Замените каждый символ-цифру на символ '!'.";
                case 4: return "Ввести массив из 10 символов. Если символ массива является прописной буквой латинского алфавита (т. е. буквой от 'a' до 'z'), замените символ, стоящий перед прописной буквой на пробел.";
                case 5: return "Введите массив символов из 15 элементов. Измените регистр символа: прописные заменить на строчные, а строчные на прописные.";
                case 6: return "Дана матрица символов размером 2×6. Сколько раз среди данных символов встречаются символы +, -, *.";
                case 7: return "Введите массив символов из 15 элементов. Подсчитать количество гласных русских букв.";
                case 8: return "Дан массив символов, среди которых есть символ двоеточие ':'. Определить, сколько символов ему предшествует.";
                case 9: return "Дан массив символов, содержащий английский текст. Найти количество слов, начинающихся с буквы b.";
                case 10: return "Дан массив символов. Подсчитать, сколько в нем букв r, k, t.";
                case 11: return "Дан массив символов. Определить, сколько в нем символов '*', ',', '.'.";
                case 12: return "Дан массив символов, среди которых есть символ '#'. Определить, сколько символов стоит после него.";
                case 13: return "Дан массив символов. Определить, сколько раз входит в него группа букв abc.";
                case 14: return "Дан массив символов. Заменить все двоеточия (:) на точку с запятой (;). Подсчитать количество замен.";
                case 15: return "Дан массив символов. Удалить символ «двоеточие» (:) и подсчитать количество удаленных символов.";
                case 16: return "Дан массив символов. Удалить часть текста, заключенного в скобки (вместе со скобками).";
                case 17: return "Дан массив символов, в котором есть один символ $. Подсчитать количество символов до этого символа и после него.";
                case 18: return "Из заданной символьной строки выбрать те символы, которые встречаются в ней только один раз, в том порядке, в котором они встречаются в тексте.";
                case 19: return "Дан массив символов. Проверить, одинаковое ли число открывающихся и закрывающихся квадратных скобок в данной строке.";
                case 20: return "Дана матрица символов размером 3×4. Подсчитать, сколько раз среди символов строки встречается символ @.";
                case 21: return "Дана матрица символов размером 5×4. Сколько раз среди данных символов встречается символ + и сколько раз символ *.";
                case 22: return "Введите массив символов из 12 элементов. Удвоить все коды символов массива.";
                case 23: return "Дана матрица символов размером 3×4. Сколько раз среди данных символов встречаются цифры? Заменить цифры на символ !.";
                case 24: return "Дана матрица символов размером 5×5. Создать строку только из латинских букв.";
                case 25: return "Дана матрица символов размером 5×5. Упорядочить символы строк по возрастанию их кода.";
                case 26: return "Дана матрица символов размером 4×4. Определить сумму кодов символов элементов главной диагонали.";
                case 27: return "Дана матрица символов размером 5×5. Определить символ с наибольшим кодом.";
                case 28: return "Дан массив символов. Заменить в нем каждую точку многоточнем (тремя точками).";
                case 29: return "Введите массив символов, состоящий из английских слов и пробелов. Упорядочить данный массив английских слов по алфавиту.";
                case 30: return "Дана матрица символов размером 5×7. Определить сумму цифр в матрице.";
                default: return "Неизвестная задача.";
            }
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            int taskNumber = TaskComboBox.SelectedIndex + 1;
            string result = ExecuteTask(taskNumber);
            OutputTextBox.Text += $"\n\nРезультат:\n{result}";
            StatusTextBlock.Text = $"Задача {taskNumber} выполнена.";
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = GetTaskDescription(TaskComboBox.SelectedIndex + 1);
            StatusTextBlock.Text = "Очищено.";
        }

        private string ExecuteTask(int taskNumber)
        {
            try
            {
                switch (taskNumber)
                {
                    case 1: return Task1();
                    case 2: return Task2();
                    case 3: return Task3();
                    case 4: return Task4();
                    case 5: return Task5();
                    case 6: return Task6();
                    case 7: return Task7();
                    case 8: return Task8();
                    case 9: return Task9();
                    case 10: return Task10();
                    case 11: return Task11();
                    case 12: return Task12();
                    case 13: return Task13();
                    case 14: return Task14();
                    case 15: return Task15();
                    case 16: return Task16();
                    case 17: return Task17();
                    case 18: return Task18();
                    case 19: return Task19();
                    case 20: return Task20();
                    case 21: return Task21();
                    case 22: return Task22();
                    case 23: return Task23();
                    case 24: return Task24();
                    case 25: return Task25();
                    case 26: return Task26();
                    case 27: return Task27();
                    case 28: return Task28();
                    case 29: return Task29();
                    case 30: return Task30();
                    default: return "Неизвестная задача.";
                }
            }
            catch (Exception ex)
            {
                return $"Ошибка при выполнении задачи: {ex.Message}";
            }
        }

        // Реализации задач
        private string Task1()
        {
            char[] array = "a1b2c3d4e5".ToCharArray(); // Пример ввода
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Исходный массив: " + new string(array));

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsDigit(array[i]))
                {
                    array[i] = '*';
                }
            }

            sb.AppendLine("Результат: " + new string(array));
            return sb.ToString();
        }
        private string Task2()
        {
            char[] array = "Hello World".ToCharArray(); // Пример ввода
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Исходный массив: " + new string(array));

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }

            sb.AppendLine("Результат: " + new string(array));
            return sb.ToString();
        }

        private string Task3()
        {
            char[] array = "Test123String456".ToCharArray(); // Пример ввода
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Исходный массив: " + new string(array));

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsDigit(array[i]))
                {
                    array[i] = '!';
                }
            }

            sb.AppendLine("Результат: " + new string(array));
            return sb.ToString();
        }

        private string Task4()
        {
            char[] array = "aBcDeFgHiJk".ToCharArray(); // Пример ввода
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Исходный массив: " + new string(array));

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= 'a' && array[i] <= 'z')
                {
                    array[i - 1] = ' ';
                }
            }

            sb.AppendLine("Результат: " + new string(array));
            return sb.ToString();
        }

        private string Task5()
        {
            char[] array = "Hello World 123".ToCharArray(); // Пример ввода
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Исходный массив: " + new string(array));

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsUpper(array[i]))
                {
                    array[i] = char.ToLower(array[i]);
                }
                else if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }

            sb.AppendLine("Результат: " + new string(array));
            return sb.ToString();
        }

        private string Task6()
        {
            char[,] matrix = {
                { '+', 'a', '-', '*', 'b', '+' },
                { 'c', '*', '-', 'd', '+', 'e' }
            };

            int plusCount = 0, minusCount = 0, starCount = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    switch (matrix[i, j])
                    {
                        case '+': plusCount++; break;
                        case '-': minusCount++; break;
                        case '*': starCount++; break;
                    }
                }
            }

            return $"Символ '+' встречается {plusCount} раз(а)\n" +
                   $"Символ '-' встречается {minusCount} раз(а)\n" +
                   $"Символ '*' встречается {starCount} раз(а)";
        }

        private string Task7()
        {
            char[] array = "Привет, мир!".ToCharArray(); // Пример ввода
            char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я',
                             'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' };
            int count = 0;

            foreach (char c in array)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return $"Количество гласных русских букв: {count}";
        }
        private string Task8()
        {
            char[] array = "abc:def".ToCharArray(); // Пример ввода
            int index = Array.IndexOf(array, ':');

            if (index == -1)
            {
                return "Символ ':' не найден в массиве.";
            }

            return $"Количество символов перед ':': {index}";
        }

        private string Task9()
        {
            string text = "big black bug bit a big black bear";
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Count(w => w.StartsWith("b", StringComparison.OrdinalIgnoreCase));

            return $"Количество слов, начинающихся с буквы 'b': {count}";
        }

        private string Task10()
        {
            char[] array = "rocket science".ToCharArray(); // Пример ввода
            int rCount = 0, kCount = 0, tCount = 0;

            foreach (char c in array)
            {
                switch (char.ToLower(c))
                {
                    case 'r': rCount++; break;
                    case 'k': kCount++; break;
                    case 't': tCount++; break;
                }
            }

            return $"Буква 'r' встречается {rCount} раз(а)\n" +
                   $"Буква 'k' встречается {kCount} раз(а)\n" +
                   $"Буква 't' встречается {tCount} раз(а)";
        }

        private string Task11()
        {
            char[] array = "Hello, *world*.".ToCharArray(); // Пример ввода
            int starCount = 0, commaCount = 0, dotCount = 0;

            foreach (char c in array)
            {
                switch (c)
                {
                    case '*': starCount++; break;
                    case ',': commaCount++; break;
                    case '.': dotCount++; break;
                }
            }

            return $"Символ '*' встречается {starCount} раз(а)\n" +
                   $"Символ ',' встречается {commaCount} раз(а)\n" +
                   $"Символ '.' встречается {dotCount} раз(а)";
        }

        private string Task12()
        {
            char[] array = "abc#def".ToCharArray(); // Пример ввода
            int index = Array.IndexOf(array, '#');

            if (index == -1)
            {
                return "Символ '#' не найден в массиве.";
            }

            return $"Количество символов после '#': {array.Length - index - 1}";
        }

        private string Task13()
        {
            char[] array = "abc123abc456abc789".ToCharArray(); // Пример ввода
            int count = 0;

            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i] == 'a' && array[i + 1] == 'b' && array[i + 2] == 'c')
                {
                    count++;
                }
            }

            return $"Группа букв 'abc' встречается {count} раз(а)";
        }

        private string Task14()
        {
            char[] array = "a:b:c:d".ToCharArray(); // Пример ввода
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ':')
                {
                    array[i] = ';';
                    count++;
                }
            }

            return $"Количество замен: {count}\nРезультат: {new string(array)}";
        }

        private string Task15()
        {
            char[] array = "a:b:c:d".ToCharArray(); // Пример ввода
            List<char> list = new List<char>(array);
            int count = list.RemoveAll(c => c == ':');

            return $"Количество удаленных символов ':': {count}\nРезультат: {new string(list.ToArray())}";
        }
        private string Task16()
        {
            string text = "Hello (world) this is (test) string";
            StringBuilder sb = new StringBuilder();
            bool inBrackets = false;

            foreach (char c in text)
            {
                if (c == '(')
                {
                    inBrackets = true;
                    continue;
                }

                if (c == ')')
                {
                    inBrackets = false;
                    continue;
                }

                if (!inBrackets)
                {
                    sb.Append(c);
                }
            }

            return $"Результат после удаления текста в скобках:\n{sb.ToString()}";
        }

        private string Task17()
        {
            char[] array = "abc$def".ToCharArray(); // Пример ввода
            int index = Array.IndexOf(array, '$');

            if (index == -1)
            {
                return "Символ '$' не найден в массиве.";
            }

            return $"Количество символов до '$': {index}\n" +
                   $"Количество символов после '$': {array.Length - index - 1}";
        }

        private string Task18()
        {
            string text = "abracadabra";
            StringBuilder sb = new StringBuilder();

            foreach (char c in text)
            {
                if (text.Count(ch => ch == c) == 1)
                {
                    sb.Append(c);
                }
            }

            return $"Символы, встречающиеся один раз: {sb.ToString()}";
        }

        private string Task19()
        {
            char[] array = "[[test[]]".ToCharArray(); // Пример ввода
            int openCount = array.Count(c => c == '[');
            int closeCount = array.Count(c => c == ']');

            return $"Открывающихся скобок: {openCount}\n" +
                   $"Закрывающихся скобок: {closeCount}\n" +
                   $"Результат проверки: {(openCount == closeCount ? "Одинаковое количество" : "Разное количество")}";
        }

        private string Task20()
        {
            char[,] matrix = {
                { '@', 'a', 'b', '@' },
                { 'c', '@', 'd', 'e' },
                { 'f', 'g', 'h', '@' }
            };

            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '@')
                    {
                        count++;
                    }
                }
            }

            return $"Символ '@' встречается {count} раз(а)";
        }

        private string Task21()
        {
            char[,] matrix = {
                { '+', 'a', '*', 'b' },
                { 'c', '*', 'd', '+' },
                { 'e', '+', 'f', 'g' },
                { 'h', 'i', '*', 'j' },
                { 'k', 'l', 'm', '+' }
            };

            int plusCount = 0, starCount = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '+') plusCount++;
                    if (matrix[i, j] == '*') starCount++;
                }
            }

            return $"Символ '+' встречается {plusCount} раз(а)\n" +
                   $"Символ '*' встречается {starCount} раз(а)";
        }

        private string Task22()
        {
            char[] array = "Hello World!".ToCharArray(); // Пример ввода
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Исходный массив: " + new string(array));

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)(array[i] * 2);
            }

            sb.AppendLine("Результат после удвоения кодов: " + new string(array));
            return sb.ToString();
        }

        private string Task23()
        {
            char[,] matrix = {
                { '1', 'a', '2', 'b' },
                { 'c', '3', 'd', '4' },
                { 'e', 'f', '5', 'g' }
            };

            int digitCount = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (char.IsDigit(matrix[i, j]))
                    {
                        digitCount++;
                        matrix[i, j] = '!';
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Количество цифр в матрице: {digitCount}");
            sb.AppendLine("Матрица после замены:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        private string Task24()
        {
            char[,] matrix = {
                { 'a', '1', 'b', '2', 'c' },
                { 'd', '3', 'e', '4', 'f' },
                { 'g', '5', 'h', '6', 'i' },
                { 'j', '7', 'k', '8', 'l' },
                { 'm', '9', 'n', '0', 'o' }
            };

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((matrix[i, j] >= 'a' && matrix[i, j] <= 'z') ||
                        (matrix[i, j] >= 'A' && matrix[i, j] <= 'Z'))
                    {
                        sb.Append(matrix[i, j]);
                    }
                }
            }

            return $"Строка из латинских букв: {sb.ToString()}";
        }

        private string Task25()
        {
            char[,] matrix = {
                { 'd', 'a', 'c', 'b', 'e' },
                { 'h', 'g', 'f', 'i', 'j' },
                { 'm', 'l', 'k', 'n', 'o' },
                { 'r', 'q', 'p', 's', 't' },
                { 'w', 'v', 'u', 'x', 'y' }
            };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Исходная матрица:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.AppendLine();
            }

            // Сортировка каждой строки
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] row = new char[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }
                Array.Sort(row);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            sb.AppendLine("\nМатрица после сортировки строк:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
        private string Task26()
        {
            char[,] matrix = {
                { 'a', 'b', 'c', 'd' },
                { 'e', 'f', 'g', 'h' },
                { 'i', 'j', 'k', 'l' },
                { 'm', 'n', 'o', 'p' }
            };

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }

            return $"Сумма кодов символов главной диагонали: {sum}";
        }

        private string Task27()
        {
            char[,] matrix = {
                { 'a', 'b', 'c', 'd', 'e' },
                { 'f', 'g', 'h', 'i', 'j' },
                { 'k', 'l', 'm', 'n', 'o' },
                { 'p', 'q', 'r', 's', 't' },
                { 'u', 'v', 'w', 'x', 'y' }
            };

            char maxChar = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > maxChar)
                    {
                        maxChar = matrix[i, j];
                    }
                }
            }

            return $"Символ с наибольшим кодом: {maxChar} (код: {(int)maxChar})";
        }

        private string Task28()
        {
            char[] array = "Hello. World. This. Is. A. Test.".ToCharArray(); // Пример ввода
            List<char> result = new List<char>();

            foreach (char c in array)
            {
                if (c == '.')
                {
                    result.Add('.');
                    result.Add('.');
                    result.Add('.');
                }
                else
                {
                    result.Add(c);
                }
            }

            return $"Результат замены точек многоточиями:\n{new string(result.ToArray())}";
        }

        private string Task29()
        {
            string text = "banana apple cherry date elderberry";
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words, StringComparer.OrdinalIgnoreCase);

            return $"Упорядоченные слова:\n{string.Join("\n", words)}";
        }

        private string Task30()
        {
            char[,] matrix = {
                { '1', 'a', '2', 'b', '3', 'c', '4' },
                { 'd', '5', 'e', '6', 'f', '7', 'g' },
                { '8', 'h', '9', 'i', '0', 'j', 'k' },
                { 'l', 'm', 'n', 'o', 'p', 'q', 'r' },
                { 's', 't', 'u', 'v', 'w', 'x', 'y' }
            };

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (char.IsDigit(matrix[i, j]))
                    {
                        sum += int.Parse(matrix[i, j].ToString());
                    }
                }
            }

            return $"Сумма цифр в матрице: {sum}";
        }
    }
}