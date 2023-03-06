using Khudyakova_Lab_3;
{
        // зададим 2 вектора
        Vector vec1 = new Vector(new double[] {2.0 ,3.0, 5.0});
        Vector vec2 = new Vector(new double[] { 11.0, 2.0, 7.0 });

        Console.WriteLine("1-ый вектор: " + vec1.ToString());
        Console.WriteLine("2-ый вектор: " + vec2.ToString());
        
        // сумма векторов
        Vector vec3 = Vector.Add(vec1, vec2);
        Console.WriteLine("1-ый вектор + 2-ой вектор = " + vec3.ToString());
        
        // произведение векторов
        double dotProduct = Vector.DotProduct(vec1, vec2);
        Console.WriteLine("1-ый вектор * 2-ой вектор = " + dotProduct);

        //результат проверки двух векторов на равенство (полное совпадение)
        bool equal = Vector.AreEqual(vec1, vec2);
        Console.WriteLine("1-ый вектор == 2-ой вектор: " + equal);

        Vector vec4 = new Vector(3);
        vec4.ReadFromConsole();


        Console.WriteLine("4-ый вектор: " + vec4.ToString());
        Console.WriteLine("Модуль 4-го вектора: " + vec4.GetMagnitude());
        Console.WriteLine("Макс элемент 4-го вектора: " + vec4.GetMaxElement());
        Console.WriteLine("Индекс мин элемента 4-го вектора: " + vec4.GetMinElementIndex());

        Vector vec5 = vec4.GetPositiveElementsVector();
        Console.WriteLine("4-ый вектор: " + vec5.ToString());

        
}
