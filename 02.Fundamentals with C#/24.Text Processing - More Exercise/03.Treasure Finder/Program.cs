using System;

class Program
{
    static void Main()
    {
        // 1️⃣ Четем ключа и го правим масив от числа
        // Примерен вход: 1 2 1 3
        int[] key = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        // 2️⃣ Четем първия ред на криптирано съобщение
        string line = Console.ReadLine();

        // 3️⃣ Обработваме всички редове до "find"
        while (line != "find")
        {
            string decrypted = ""; // тук ще съхраняваме декриптираното съобщение
            int keyIndex = 0;      // за да знаем коя стойност от ключа използваме

            // 4️⃣ Декриптиране на всеки символ
            for (int i = 0; i < line.Length; i++)
            {
                // Взимаме символ и намаляваме с числото от ключа
                char decryptedChar = (char)(line[i] - key[keyIndex]);
                decrypted += decryptedChar;

                keyIndex++; // минаваме към следващото число от ключа
                if (keyIndex == key.Length)
                {
                    keyIndex = 0; // ако стигнем края на ключа, започваме отначало
                }
            }

            // 5️⃣ Извличаме типа на съкровището между '&' и '&'
            int typeStart = decrypted.IndexOf('&') + 1;
            int typeEnd = decrypted.LastIndexOf('&');
            string treasureType = decrypted.Substring(typeStart, typeEnd - typeStart);

            // 6️⃣ Извличаме координатите между '<' и '>'
            int coordStart = decrypted.IndexOf('<') + 1;
            int coordEnd = decrypted.IndexOf('>');
            string coordinates = decrypted.Substring(coordStart, coordEnd - coordStart);

            // 7️⃣ Отпечатваме резултата
            Console.WriteLine($"Found {treasureType} at {coordinates}");

            // 8️⃣ Четем следващия ред
            line = Console.ReadLine();
        }
    }
}