using System;

namespace FP_Probleme_Setul_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static void Citire_Vector(int n)
        {
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
        }
        static int n, x, m;
        static int[] v;
        static int caut(int s, int d)
        {
            if (s > d)
                return -1;

            m = (s + d) / 2;
            if (x == v[m])
                return m;
            if (x < v[m])
                return caut(s, m - 1);
            else
                return caut(m + 1, d);
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Alege o problema : ");
            Console.WriteLine("1. Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
            Console.WriteLine("2. Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. ");
            Console.WriteLine("3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). ");
            Console.WriteLine("4. Determinati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. ");
            Console.WriteLine("5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. ");
            Console.WriteLine("6. Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.");
            Console.WriteLine("7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
            Console.WriteLine("8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. ");
            Console.WriteLine("9. Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. ");
            Console.WriteLine("10. Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. ");
            Console.WriteLine("11. Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). ");
            Console.WriteLine("12. Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. ");
            Console.WriteLine("13. Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. ");
            Console.WriteLine("14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). ");
            Console.WriteLine("15. Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. ");
            Console.WriteLine("16. Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
            Console.WriteLine("17. Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   ");
            Console.WriteLine("18. Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. ");
            Console.WriteLine("19. Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). ");
            Console.WriteLine("20. Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem.");
            Console.WriteLine("22. Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. ");
            Console.WriteLine("24. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).");
            Console.WriteLine("25. (Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. ");
            Console.WriteLine("28. Quicksort. Sortati un vector folosind metoda QuickSort.");
            Console.WriteLine("29. MergeSort. Sortati un vector folosind metoda MergeSort.");
            Console.WriteLine();
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine("1. Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
                        int n = int.Parse(Console.ReadLine());
                        int[] v = new int[n];
                        int s = 0;
                        for (int i = 0; i < n; i++)
                        {
                            v[i] = int.Parse(Console.ReadLine());
                            s = s + v[i];
                        }
                        Console.WriteLine($"Suma elementelor vectorului este {s}");
                        return false;
                    }
                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine("2. Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.");
                        int n = int.Parse(Console.ReadLine());
                        int[] v = new int[n];
                        int pozitie = -1;
                        int k = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            v[i] = int.Parse(Console.ReadLine());
                            if (k == v[i])
                            {
                                pozitie = i;
                                break;
                            }
                        }
                        if (pozitie == -1)
                            Console.WriteLine($"Elementul {k} nu se afla in vector ");
                        else
                            Console.WriteLine($"Prima pozitie pe care apare {k} este {pozitie} ");
                        return false;
                    }
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). ");
                        int n = int.Parse(Console.ReadLine());
                        int[] v = new int[n];
                        int pozitie_min = -1;
                        int pozitie_max = -1;
                        int i = 0;
                        v[i] = int.Parse(Console.ReadLine());
                        int min = v[0];
                        int max = v[0];
                        for (i = 1; i < n; i++)
                        {
                            v[i] = int.Parse(Console.ReadLine());
                            if (min > v[i])
                                pozitie_min = i;
                            if (max < v[i])
                                pozitie_max = i;
                        }
                        Console.WriteLine($"Elementul maxim {max} se afla pe pozitia {pozitie_max}");
                        Console.WriteLine($"Elementul minim {min} se afla pe pozitia {pozitie_min}");
                        return false;
                    }
                case "4":
                    {
                        return false;

                    }
                case "5":
                    {
                        Console.Clear();
                        Console.WriteLine("5. Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. ");
                        int n, i, k, e;
                        n = int.Parse(Console.ReadLine());
                        float[] a = new float[n + 1];
                        for (i = 0; i < n; i++)
                        {
                            a[i] = float.Parse(Console.ReadLine());
                        }
                        k = int.Parse(Console.ReadLine());
                        k--;

                        if ((k >= 0) && (k < n))
                        {
                            e = int.Parse(Console.ReadLine());
                            for (i = n - 1; i >= k; i--)
                                a[i + 1] = a[i];
                            a[k] = e;
                            Console.Write("Elementele noului vector sunt:");
                            for (i = 0; i <= n; i++)
                                Console.Write("{0}", a[i]);
                        }
                        else
                            Console.Write("Pozitia cautata nu exista!");
                        return false;
                    }
                case "6":
                    {
                        Console.Clear();
                        Console.WriteLine("6. Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. ");
                        int n = int.Parse(Console.ReadLine());
                        float[] array = new float[n];
                        for (int i = 0; i < n; i++)
                        {
                            array[i] = float.Parse(Console.ReadLine());
                        }
                        int k = int.Parse(Console.ReadLine());
                        k--;
                        if ((k >= 0) && (k < n))
                        {
                            for (int i = k + 1; i < n; i++)
                                array[i - 1] = array[i];

                            n--;
                            Console.Write("Noua ordine a elementelor vectorului:");
                            for (int i = 0; i < n; i++)
                                Console.Write("{0} ", array[i]);
                        }
                        else
                            Console.Write("Pozitie inexistenta!");
                        return false;
                    }
                case "7":
                    {
                        Console.Clear();
                        Console.WriteLine("7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
                        int n = int.Parse(Console.ReadLine());
                        int[] v = new int[n];
                        int i = 0;
                        for (i = 0; i < n; i++)
                        {
                            v[i] = int.Parse(Console.ReadLine());
                        }
                        int j = n - 1;
                        i = 0;
                        while (i <= j)
                        {
                            int aux = v[i];
                            v[i] = v[j];
                            v[j] = aux;
                            j--;
                            i++;
                        }
                        Console.WriteLine();
                        for (i = 0; i < n; i++)
                            Console.WriteLine(v[i]);
                        Console.WriteLine();
                        return false;
                    }
                case "8":
                    {
                        Console.Clear();
                        Console.WriteLine("8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. ");
                        int n = int.Parse(Console.ReadLine());
                        int[] v = new int[n];
                        int i = 0;
                        for (i = 0; i < n; i++)
                        {
                            v[i] = int.Parse(Console.ReadLine());
                        }
                        int aux = v[0];
                        for (i = 0; i < n - 1; i++)
                            v[i] = v[i + 1];
                        v[n - 1] = aux;
                        for (i = 0; i < n; i++)
                            Console.Write($"{v[i]} ");
                        Console.WriteLine();
                        return false;
                    }
                case "9":
                    {
                        Console.Clear();
                        Console.WriteLine("9. Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.");
                        int n = int.Parse(Console.ReadLine());
                        int[] v = new int[n];
                        int i;
                        for (i = 0; i < n; i++)
                        {
                            v[i] = int.Parse(Console.ReadLine());
                        }
                        int k = int.Parse(Console.ReadLine());
                        while (k != 0)
                        {
                            int aux = v[0];
                            for (i = 0; i < n - 1; i++)
                                v[i] = v[i + 1];
                            v[n - 1] = aux;
                            k--;
                        }
                        for (i = 0; i < n; i++)
                            Console.Write($"{v[i]} ");
                        Console.WriteLine();
                        return false;
                    }
                case "10":
                    {
                        Console.Clear();
                        Console.WriteLine("10. Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. ");
                        Console.Write("n= ");
                        n = int.Parse(Console.ReadLine());
                        v = new int[n];
                        Console.Write("x= ");
                        x = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                            v[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Elementul a fost gasit pe pozitia {0}!", caut(0, n - 1));
                        return false;
                    }
                case "11":
                    {
                        Console.Clear();
                        Console.WriteLine("11. Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).");
                        int n = int.Parse(Console.ReadLine());
                        int[] v = new int[n];
                        int i;
                        for (i = 0; i < n; i++)
                        {
                            v[i] = 0;
                        }
                        v[0] = 1;
                        v[1] = 1;
                        for (i = 2; i < n/2 ; i++)
                        {
                            if (v[i] == 0)
                                for (int j = 2; j < n / i; j++)
                                    v[i * j] = 1;
                        }
                        for (i = 0; i < n; i++)
                            if (v[i] == 0)
                                Console.Write($"{i} ");
                        Console.WriteLine();
                        return false;
                    }
                case "12":
                    {
                        Console.Clear();
                        Console.WriteLine("12. Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.");
                        int[] v = new int[10];
                        int i, j, k;
                        for (i = 0; i < v.Length; i++)
                            v[i] = int.Parse(Console.ReadLine());
                        for (i = 0; i < v.Length; i++)
                        {
                            k = i;
                            for(j=i+1; j<v.Length;j++)
                            {
                                if (v[j] < v[k])
                                    k = j;
                            }
                            swap(v, i, k);
                        }
                        for (i = 0; i < n; i++)
                            Console.Write($"{v[i]} ");
                        Console.WriteLine();
                        return false;
                    }
                case "13":
                    {
                        Console.Clear();
                        Console.WriteLine("13. Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. ");
                        int[] v = new int[10];
                        for (int i = 0; i < v.Length; i++)
                            v[i] = int.Parse(Console.ReadLine());
                        int k;
                        for(int i=1; i <v.Length; i++)
                        {
                            for( k=i; k>0 && v[k] < v[k-1] ; k--)
                            {
                                swap(v, k, k - 1);
                            }
                        }
                        for (int i = 0; i < n; i++)
                            Console.Write($"{v[i]} ");
                        Console.WriteLine();
                        return false;
                    }
                case "14":
                    {
                        Console.Clear();
                        Console.WriteLine("14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). ");
                        int n = int.Parse(Console.ReadLine());
                        int[] v = new int[n];
                        int i;
                        for ( i = 0; i < n; i++)
                            v[i] = int.Parse(Console.ReadLine());
                        i = 0;
                        int j = n - 1;
                        while(i<=j)
                        {
                            if (v[i] == 0)
                            {
                                if (v[j] != 0)
                                {
                                    swap(v, i, j);
                                    i++;
                                    j--;
                                }
                                else
                                    j--;
                            }
                            else
                                i++;
                        }
                        for (i = 0; i < n; i++)
                            Console.Write($"{v[i]} ");
                        Console.WriteLine();
                        return false;
                    }
                case "15":
                    {
                        Console.Clear();
                        Console.WriteLine("16. Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. ");
                        int n = int.Parse(Console.ReadLine());
                        int[] v = new int[n];
                        int i;
                        for (i = 0; i < n; i++)
                            v[i] = int.Parse(Console.ReadLine());
                        i = 0;
                        int j;
                        int cn = n;
                        j = i + 1;
                        while(i<n)
                        {
                                
                            if (v[i] == v[j])
                            {
                                v[i] = v[j];
                                i--;
                                n--;
                            }
                            i++;
                            j++;
                        }
                        for (i = 0; i < n; i++)
                            Console.Write($"{v[i]} ");
                        Console.WriteLine();
                        return false;
                    }
                case "16":
                    {
                        Console.Clear();
                        Console.WriteLine("16. Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
                        int n = int.Parse(Console.ReadLine());
                        int[] v = new int[n];
                        int i;
                        for (i = 0; i < n; i++)
                            v[i] = int.Parse(Console.ReadLine());
                        int cmmdc = v[0];
                        for (i = 1; i < n; i++)
                        {
                            int copieEL = v[i];
                            while (copieEL != cmmdc)
                            {
                                if (copieEL > cmmdc)
                                    copieEL = copieEL - cmmdc;
                                else if (copieEL < cmmdc)
                                    cmmdc = cmmdc - copieEL;
                            }
                        }
                        Console.WriteLine(cmmdc);
                        return false;
                    }
                case "17":

                    {
                        Console.Clear();
                        Console.WriteLine("17. Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.");
                        int n = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int r = 1, digits = 0;
                        char[] CharArray = new char[20];
                        int cn = n;
                        while (n!=0)
                        {
                            r = n % b;
                            if(r<9)
                                CharArray[digits] = (char)(r + 48);
                            else
                                CharArray[digits] = (char)(r + 55);
                            n /= b;
                            digits++;

                        }
                        Console.WriteLine($"Reprezentarea in baza {b} a numarului {cn} este : ");

                        for (int i = digits - 1; i >= 0; i--)
                            Console.Write(CharArray[i]);
                        Console.WriteLine();
                        return false;
                    }
                case "18":
                    {
                        Console.Clear();
                        Console.WriteLine("18. Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. ");
                        int n = int.Parse(Console.ReadLine());
                        int[] v = new int[n];
                        for (int i = 0; i <n ; i++)
                        {
                            v[i] = int.Parse(Console.ReadLine());
                        }
                        int result = 0;
                        for (int i = 0; i < n; i++)
                        {
                            result += v[i] * (int)Math.Pow(x, i);
                        }
                        Console.WriteLine(result);
                        return false;
                    }
                case "19":
                    {
                        Console.Clear();
                        Console.WriteLine("19. Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). ");
                        int i ;
                        int n = int.Parse(Console.ReadLine());
                        int[] s = new int[n];
                        for ( i = 0; i < n; i++)
                        {
                            s[i] = int.Parse(Console.ReadLine());
                        }
                        int m = int.Parse(Console.ReadLine());
                        int[] p = new int[m];
                        for ( i = 0; i < m; i++)
                        {
                            p[i] = int.Parse(Console.ReadLine());
                        }
                        i = 0;
                        int j = 0, count = 0, k = 0;
                        while(i<n)
                        {
                            if(s[i]==p[j])
                            {
                                i++;
                                j++;
                                k++;
                                if (k == 3)
                                {
                                    j = 0;
                                    k = 0;
                                    i--;
                                    count++;
                                }
                            }
                            else
                            {
                                i++;
                                j = 0;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine(count);

                        return false;
                    }
                case "20":
                    {
                        Console.Clear();
                        Console.WriteLine("20. Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. ");
                        int n = int.Parse(Console.ReadLine());
                        int m = int.Parse(Console.ReadLine());
                        int[] s1 = new int[n];
                        int[] s2 = new int[m];
                        for (int i = 0; i < n; i++)
                        {
                            s1[i] = int.Parse(Console.ReadLine());
                        }
                        for (int i = 0; i < m; i++)
                        {
                            s2[i] = int.Parse(Console.ReadLine());
                        }
                        int minLength = Math.Min(n, m);
                        int index = 0;
                        int max_suprapuneri = 0;
                        while (index < n)
                        {
                            int suprapuneri = 0;
                            for (int i = 0; i < minLength; i++)
                            {
                                if (s1[i] == s2[i])
                                {
                                    suprapuneri++;
                                }
                            }

                            if (suprapuneri > max_suprapuneri)
                            {
                                max_suprapuneri = suprapuneri;
                            }
                            s1 = RotateLeft(s1);
                            index ++;
                        }
                        Console.WriteLine(max_suprapuneri);
                        return false;
                    }
                case "22":
                    {
                        Console.Clear();
                        Console.WriteLine("22. Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. ");
                        Console.WriteLine("Alegeti una dintre probleme ");
                        Console.WriteLine("a. Intersectie ");
                        Console.WriteLine("b. Reuniune ");
                        Console.WriteLine("c. Diferenta ");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    int n = int.Parse(Console.ReadLine());
                                    int m = int.Parse(Console.ReadLine());
                                    float[] a = new float[n];
                                    float[] b = new float[m];
                                    int pos = 0;
                                    bool empty = true;
                                    for (int i = 0; i < n; i++)
                                    {
                                        a[i] = float.Parse(Console.ReadLine());
                                    }
                                    for (int i = 0; i < m; i++)
                                    {
                                        b[i] = float.Parse(Console.ReadLine());
                                    }
                                    int p = Math.Min(n, m);
                                    float[] intersectie = new float[p];

                                    for (int i = 0; i < n; i++)
                                    {
                                        for (int j = 0; j < m; j++)
                                        {
                                            if (a[i] == b[j])
                                            {
                                                intersectie[pos] = a[i];
                                                pos++;
                                                empty = false;
                                            }
                                        }
                                    }
                                    if (empty)
                                        Console.WriteLine("Multimea vida");
                                    else
                                    {
                                        for (int i = 0; i < pos; i++)
                                            Console.WriteLine("{0}", intersectie[i]);
                                    }
                                    return false;
                                }
                            case "2":
                                {
                                    int n = int.Parse(Console.ReadLine());
                                    int m = int.Parse(Console.ReadLine());
                                    float[] a = new float[n + m];
                                    float[] b = new float[m];
                                    for (int i = 0; i < n; i++)
                                    {
                                        a[i] = float.Parse(Console.ReadLine());
                                    }
                                    for (int i = 0; i < m; i++)
                                    {
                                        b[i] = float.Parse(Console.ReadLine());
                                    }
                                    int pos = n;
                                    bool find;
                                    for (int j = 0; j < m; j++)
                                    {
                                        find = false;
                                        for (int i = 0; i < m; i++)
                                        {
                                            if (b[j] == a[i])
                                            {
                                                find = true;
                                                break;
                                            }
                                        }
                                        if (!find)
                                        {
                                            a[pos] = b[j];
                                            pos++;
                                        }
                                    }
                                    n = pos;
                                    for (int i = 0; i < n; i++)
                                        Console.WriteLine("{0}", a[i]);
                                    return false;
                                }
                            case "3":
                                {
                                    int n = int.Parse(Console.ReadLine());
                                    int m = int.Parse(Console.ReadLine());
                                    float[] a = new float[n];
                                    float[] b = new float[m];
                                    for (int i = 0; i < n; i++)
                                    {
                                        a[i] = float.Parse(Console.ReadLine());
                                    }
                                    for (int i = 0; i < m; i++)
                                    {
                                        b[i] = float.Parse(Console.ReadLine());
                                    }
                                    bool exist, empty = true;
                                    int pos = 0;
                                    float[] dif = new float[n];
                                    for (int i = 0; i < n; i++)
                                    {
                                        exist = false;
                                        for (int j = 0; j < m; j++)
                                            if (a[i] == b[j])
                                            {
                                                exist = true;
                                                break;
                                            }
                                        if (exist == false)
                                        {
                                            dif[pos] = a[i];
                                            pos++;
                                            empty = false;
                                        }
                                    }

                                    Console.Write("A \\ B = ");

                                    if (empty == false)
                                        for (int i = 0; i < pos; i++)
                                            Console.Write("{0} ", dif[i]);
                                    else
                                        Console.Write("Multimea vida");
                                    return false;
                                }
                            default:
                                {
                                    Console.WriteLine("Nu ati ales nicio problema din cele enumerate mai sus ");
                                    return false;
                                }
                        }
                        return false;
                    }
                case "24":
                    {
                        Console.Clear();
                        Console.WriteLine("22. Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. ");
                        Console.WriteLine("Alegeti una dintre probleme ");
                        Console.WriteLine("a. Intersectie ");
                        Console.WriteLine("b. Reuniune ");
                        Console.WriteLine("c. Diferenta ");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    int n = int.Parse(Console.ReadLine());
                                    int m = int.Parse(Console.ReadLine());
                                    int[] a = new int[n];
                                    int[] b = new int[m];
                                    int poz_maxima1 = 0;
                                    int poz_maxima2 = 0;
                                    for (int i = 0; i < n; i++)
                                    {
                                        int x = int.Parse(Console.ReadLine());
                                        a[x] = 1;
                                        if (x > poz_maxima1)
                                            poz_maxima1 = x;
                                    }
                                    for (int i = 0; i < m; i++)
                                    {
                                        int y = int.Parse(Console.ReadLine());
                                        b[y] = 1;
                                        if (y > poz_maxima2)
                                            poz_maxima2 = y;
                                    }
                                    int pos = 0;
                                    bool empty = true;
                                    int p = Math.Min(n, m);
                                    float[] intersectie = new float[p];

                                    for (int i = 0; i <= poz_maxima1; i++)
                                    {
                                        for (int j = 0; j <= poz_maxima2; j++)
                                        {
                                            if (i==j && a[i]==1 && b[j]==1)
                                            {
                                                intersectie[pos] = i;
                                                pos++;
                                                empty = false;
                                            }
                                        }
                                    }
                                    if (empty)
                                        Console.WriteLine("Multimea vida");
                                    else
                                    {
                                        for (int i = 0; i < pos; i++)
                                            Console.WriteLine("{0}", intersectie[i]);
                                    }

                                    return false;
                                }
                            case "2":
                                {
                                    int n = int.Parse(Console.ReadLine());
                                    int m = int.Parse(Console.ReadLine());
                                    int[] a = new int[n+m];
                                    int[] b = new int[m];
                                    int poz_maxima1 = 0;
                                    int poz_maxima2 = 0;
                                    for (int i = 0; i < n; i++)
                                    {
                                        int x = int.Parse(Console.ReadLine());
                                        a[x] = 1;
                                        if (x > poz_maxima1)
                                            poz_maxima1 = x;
                                    }
                                    for (int i = 0; i < m; i++)
                                    {
                                        int y = int.Parse(Console.ReadLine());
                                        b[y] = 1;
                                        if (y > poz_maxima2)
                                            poz_maxima2 = y;
                                    }
                                    int pos = poz_maxima1;
                                    bool find;
                                    for (int j = 0; j <= poz_maxima2; j++)
                                    {
                                        find = false;
                                        for (int i = 0; i <= poz_maxima2; i++)
                                        {
                                            if (i==j && b[i]==1)
                                            {
                                                find = true;
                                                break;
                                            }
                                        }
                                        if (!find)
                                        {
                                            a[pos] = 1;
                                            pos++;
                                        }
                                    }
                                    n = pos;
                                    for (int i = 0; i < n; i++)
                                        if (a[i] == 1)
                                            Console.WriteLine("{0}", i);
                                    return false;
                                }
                            case "3":
                                {
                                    int n = int.Parse(Console.ReadLine());
                                    int m = int.Parse(Console.ReadLine());
                                    int[] a = new int[n];
                                    int[] b = new int[m];
                                    int poz_maxima1 = 0;
                                    int poz_maxima2 = 0;
                                    for (int i = 0; i < n; i++)
                                    {
                                        int x = int.Parse(Console.ReadLine());
                                        a[x] = 1;
                                        if (x > poz_maxima1)
                                            poz_maxima1 = x;
                                    }
                                    for (int i = 0; i < m; i++)
                                    {
                                        int y = int.Parse(Console.ReadLine());
                                        b[y] = 1;
                                        if (y > poz_maxima2)
                                            poz_maxima2 = y;
                                    }
                                    bool exist, empty = true;
                                    int pos = 0;
                                    float[] dif = new float[n];
                                    for (int i = 0; i <=poz_maxima1; i++)
                                    {
                                        exist = false;
                                        for (int j = 0; j <=poz_maxima2; j++)
                                            if (i==j && a[i]==1 && b[j]==1)
                                            {
                                                exist = true;
                                                break;
                                            }
                                        if (exist == false)
                                        {
                                            dif[pos] = i;
                                            pos++;
                                            empty = false;
                                        }
                                    }

                                    Console.Write("A \\ B = ");

                                    if (empty == false)
                                        for (int i = 0; i < pos; i++)
                                            Console.Write("{0} ", dif[i]);
                                    else
                                        Console.Write("Multimea vida");
                                    return false;
                                }
                            default:
                                {
                                    Console.WriteLine("Nu ati ales nicio problema din cele enumerate mai sus ");
                                    return false;
                                }
                        }
                        return false;
                    }
                case "25":
                    {
                        Console.Clear();
                        Console.WriteLine("25. (Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. ");
                        int n = int.Parse(Console.ReadLine());
                        int m = int.Parse(Console.ReadLine());
                        float[] a = new float[n + m];
                        float[] b = new float[m];
                        int i = 0;
                        for (i = 0; i < n; i++)
                        {
                            a[i] = float.Parse(Console.ReadLine());
                        }
                        for (i = 0; i < m; i++)
                        {
                            b[i] = float.Parse(Console.ReadLine());
                        }
                        float[] c = new float[n + m];
                        int k = 0, j = 0;
                        while (i < n && j < m)
                        {
                            if (a[i] < b[j])
                            {
                                c[k] = a[i];
                                k++;
                                i++;
                            }
                            else
                            {
                                c[k] = b[j];
                                k++;
                                j++;
                            }
                        }
                        if (i <= n)
                        {
                            for (int p = i; p < n; p++)
                            {
                                c[k] = a[p];
                                k++;
                            }
                        }
                        if (j <= m)
                        {
                            for (int p = j; p < m; p++)
                            {
                                c[k] = b[p];
                                k++;
                            }
                        }
                        for (int p = 0; p < k; p++)
                        {
                            Console.Write("{0} ", c[p]);
                        }
                        Console.WriteLine();
                        return false;

                    }
                case "28":
                    {
                        Console.Clear();
                        Console.WriteLine("28. Quicksort. Sortati un vector folosind metoda QuickSort.");
                        int n = int.Parse(Console.ReadLine());
                        int[] arr = new int[n];
                        int i;
                        for (i = 0; i < n; i++)
                            v[i] = int.Parse(Console.ReadLine());
                        Quick_Sort(arr, 0, arr.Length - 1);
                        foreach (var item in arr)
                        {
                            Console.Write(" " + item);
                        }
                        Console.WriteLine();
                        return false;
                    }
                case "29":
                    {
                        Console.Clear();
                        Console.WriteLine("29. MergeSort. Sortati un vector folosind metoda MergeSort.");
                        int n = int.Parse(Console.ReadLine());
                        int[] arr = new int[n];
                        int i;
                        for (i = 0; i < n; i++)
                            v[i] = int.Parse(Console.ReadLine());
                        SortMerge(arr , 0 ,n-1);
                        for ( i = 0; i < n; i++)
                            Console.WriteLine(" " + arr[i]);
                        return false;
                    }
                case "30":
                    {
                        Console.Clear();
                        Console.WriteLine("30. Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. ");
                        int n = int.Parse(Console.ReadLine());
                        int m = int.Parse(Console.ReadLine());
                        int[] e = new int[n];
                        int[] w = new int[m];
                        int i = 0;
                        for (i = 0; i < n; i++)
                        {
                            e[i] = int.Parse(Console.ReadLine());
                        }
                        for (i = 0; i < m; i++)
                        {
                            w[i] = int.Parse(Console.ReadLine());
                        }
                        for (i = 1; i < e.Length; i++)
                        {
                            int element = e[i];
                            int pondere = w[i];
                            int j = i - 1;

                            while (j >= 0 && e[j] >= element)
                            {
                                if (e[j] == element && w[j] >= pondere)
                                {
                                    break;
                                }
                                e[j + 1] = e[j];
                                w[j + 1] = w[j];
                                j--;
                            }

                            e[j + 1] = element;
                            w[j + 1] = pondere;
                        }
                        return false;
                    }
                default:
                    {
                        Console.WriteLine("Nu ati ales nicio problema din cele enumerate mai sus ");
                        return false;
                    }
            }
        }
        public static int[] RotateLeft(int[] array)
        {
            int length = array.Length;
            int[] newArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                int index = i - 1;
                int place = length + index;
                if (index >= 0)
                {
                    newArray[index] = array[i];
                }
                else
                {
                    newArray[place] = array[i];
                }
            }

            return newArray;
        }
        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        private static void swap(int[] v, int i, int j)
        {
            int aux;
            aux = v[i];
            v[i] = v[j];
            v[j] = aux;
        }
    }
}
