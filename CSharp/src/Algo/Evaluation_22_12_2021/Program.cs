using System;

namespace Evaluation_22_12_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(UserInfo());
            //Console.WriteLine(MonthOfBirth());
            //OrganisationDay();
            //StaticArray();
            //StaticArrayNumber();
            Pascal();
        }

        /// <summary>
        /// LE TRIANGLE DE PASCAL ET FONCTION RECURSIVE
        /// </summary>
        private static void Pascal()
        {
            const int row = 10;
            const int col = 10;
            int[,] pascalNumbers = new int[row, col];
            pascalNumbers[0, 0] = 1;
            pascalNumbers[1, 0] = 1;
            pascalNumbers[1, 1] = 1;
            RecursifPascal(pascalNumbers, 1, 1);
        }

        private static void RecursifPascal(int[,] _pascalNumbers, int _row, int _col)
        {
            if (_row > 1 && _row < 10)
            {
                Console.Write(_pascalNumbers[_row, _col]);
            }
            for (_col = 2; _col < _pascalNumbers.Length / 2; _col++)
            {
                _pascalNumbers[_row, _col] = _pascalNumbers[_row - 1, _col - 1] + _pascalNumbers[_row - 1, _col];
                Console.Write(_pascalNumbers[_row, _col]);
                RecursifPascal(_pascalNumbers, _row + 1, _col);
            }
        }

        /// <summary>
        /// FONCTIONS ET TABLEAUX STATIQUES DE NOMBRES ENTIERS
        /// </summary>
        private static void StaticArrayNumber()
        {
            bool response = ResponseUser("Voulez-vous entrer les nombres vous même ?\nSi vous choisissez 'non', ils seront générés aléatoirement.");
            if (response == true)
            {
                int userArrayLength = AskANumberWithLimit("Entrez un nombre entier, compris entre 1 et 20 pour la taille du tableau :");
                int[] userNumber = AskANumbers("Entrez des nombres entier separé par '_' :", userArrayLength);
                Display(userNumber, userArrayLength);
                MinAndMaxInArray(userNumber);
            }
            else
            {
                int arrayLenth = RandomNumber(1, 21);
                int[] arrayNumber = new int[arrayLenth];
                int[] newArrayRandom = GetRandomNumberInArray(arrayNumber);
                Display(newArrayRandom, arrayLenth);
                MinAndMaxInArray(newArrayRandom);
            }
        }

        /// <summary>
        /// Get min and max in the table
        /// </summary>
        /// <param name="_arrayNumber">Array number</param>
        private static void MinAndMaxInArray(int[] _arrayNumber)
        {
            for (int i = 0; i < _arrayNumber.Length - 1; ++i)
            {
                for (int j = i + 1; j < _arrayNumber.Length; ++j)
                {
                    if (_arrayNumber[j] < _arrayNumber[i])
                    {
                        Permuter(ref _arrayNumber[i], ref _arrayNumber[j]);
                    }
                }
            }
            MakeCalculationAverage(_arrayNumber, _arrayNumber[0]);
            Console.WriteLine($"Le nombre le plus petit du tableau est {_arrayNumber[0]}.\nLe plus grand est {_arrayNumber[_arrayNumber.Length - 1]}.\nL'écart entre les deux est de {_arrayNumber[_arrayNumber.Length - 1]- _arrayNumber[0]}");
        }

        /// <summary>
        /// Permutation of tow number
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Permuter(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Average of the table
        /// </summary>
        /// <param name="userNumber">Array number enter by the user</param>
        private static void MakeCalculationAverage(int[] userNumber, int minNumber)
        {
            double sum = 0;
            for (int i = 0; i < userNumber.Length; i++)
            {
                sum += (double)userNumber[i];

            };
            double average = sum / (double)userNumber.Length;
            Console.WriteLine($"La moyenne du tableau est de {average}.");
        }

        /// <summary>
        /// Display array
        /// </summary>
        /// <param name="_userNumber">Array number make by the user</param>
        /// <param name="_userArrayLength">Length of the array</param>
        private static void Display(int[] _userNumber, int _userArrayLength)
        {
            string newStringArray = "";
            foreach (int item in _userNumber)
            {
                newStringArray += item.ToString() + " ";
            }
            Console.WriteLine($"La taille de votre tableau est {_userArrayLength} et les élements dedans sont : {newStringArray}");
        }

        private static int AskANumberWithLimit(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    int tmp = int.Parse(userEntry);
                    if (tmp <= 20 && tmp > 0)
                    {
                        return tmp;
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas saisie un nombre entre 1 et 20, recommencez :");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Vous n'avez pas entrer un nombre, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// Ask user to enter numbers
        /// </summary>
        /// <param name="message">Question for user</param>
        /// <param name="userArrayLength">Array length</param>
        /// <returns>Return array number</returns>
        private static int[] AskANumbers(string message, int userArrayLength)
        {
            Console.WriteLine(message);
            do
            {
                string[] userEntry = Console.ReadLine().Split('_');
                int[] userNumber = new int[userArrayLength];
                try
                {
                    for (int i = 0; i < userNumber.Length; i++)
                    {
                        userNumber[i] = int.Parse(userEntry[i]);

                    }
                    return userNumber;
                }
                catch (Exception)
                {

                    Console.WriteLine("Vous n'avez pas entrer un nombre entier, recommencez :");
                }
            } while (true);
        }

        /// <summary>
        /// Get random number in array
        /// </summary>
        /// <param name="_arrayNumber"></param>
        /// <returns>Return array number</returns>
        private static int[] GetRandomNumberInArray(int[] _arrayNumber)
        {
            for (int i = 0; i < _arrayNumber.Length; i++)
            {
                int randomInt = RandomNumber(-50, 51);
                _arrayNumber[i] = randomInt;
            }
            return _arrayNumber;
        }

        /// <summary>
        /// Random method
        /// </summary>
        /// <param name="start">Start integer</param>
        /// <param name="end">End integer</param>
        /// <returns>Return an random number</returns>
        private static int RandomNumber(int start, int end)
        {
            Random number = new Random();
            return number.Next(start, end);
        }

        /// <summary>
        /// TABLEAUX STATIQUES
        /// </summary>
        private static void StaticArray()
        {
            string[] question = {   "Avez-vous votre permis voiture ?", 
                                    "Aimez-vous faire du ping-pong ?", 
                                    "Avez-vous des enfants ?", 
                                    "Aimez-vous au cinéma", 
                                    "Savez-vous tout sur tout ?",
                                    "Savez-vous danser ?"};
            string[] response = new string[6];
            for (int i = 0; i < question.Length; i++)
            {
                string userResponse = TrueOrFalse(question[i]);
                response[i] = userResponse;
            }

            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine($"{question[i]} Vous avez répondu \"{response[i]}\"");
            }
        }

        /// <summary>
        /// CREATIONS ET INITIALISATIONS DE VARIABLES
        /// </summary>
        /// <returns></returns>
        private static string UserInfo()
        {
            const string firstName = "Fabrice";
            const string lastName = "Turleque";
            int age;
            age = AskANumber("Inscrivez un age :");
            if (age < 21)
            {
                return $"Vous vous appelez {lastName} {firstName} vous avez {age} ans et vous ête née avant les années 2000.";
            }
            else
            {
                return $"Vous vous appelez {lastName} {firstName} vous avez {age} ans et vous n'ête née après les années 2000.";
            }

        }

        /// <summary>
        /// MOIS DE NAISSANCE D’UN UTILISATEUR
        /// </summary>
        /// <returns></returns>
        private static string MonthOfBirth()
        {
            string[] monthOfYear = { "Janvier", "Février", "Mars", "avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            do
            {
                int month = AskANumber("Inscrivez le numéro de votre mois de naissance :");
                if (month > 0 && month < 13)
                {
                    if (monthOfYear[month - 1] == "Janvier")
                    {
                        return $"Le mois de {monthOfYear[month - 1]} est le mois de votre naissance, c'est le premier mois de l'année.";
                    }
                    else if (monthOfYear[month - 1] == "Décembre")
                    {
                        return $"Le mois de {monthOfYear[month - 1]} est le mois de votre naissance, c'est le dernier mois de l'année.";

                    }
                    else
                    {
                        return $"Le mois de {monthOfYear[month - 1]} est le mois de votre naissance, c'est le {month} mois de l'année.";

                    }
                }
                else
                {
                    Console.WriteLine($"{month} ne correspond à aucun mois. Entrez un numéro (entre 1 et 12) correspondant à votre mois de naissance :");
                }
            } while (true);
        }

        /// <summary>
        /// MA JOURNEE DE SAMEDI
        /// </summary>
        private static void OrganisationDay()
        {
            bool response;
            response = ResponseUser("Ete vous deja allez faire les course ?");
            if (response == false)
            {
                do
                {
                    response = ResponseUser("Vos sacs sont il vide ?");
                    if (response == true)
                    {
                        Console.WriteLine("Vous partez en course !");
                        do
                        {
                            response = ResponseUser("Regardez votre liste et verifiez que vous avez bien tous vos articles. Avez vous tous vos articles ?");
                            if (response == true)
                            {
                                Console.WriteLine("Passez en caise et payez vos articles !");
                            }
                            else
                            {
                                Console.WriteLine("Continuez vos courses et récupérez les articles manquant.");
                            }
                        } while (response == false);
                    }
                    else
                    {
                        Console.WriteLine("Vos sac ne sont pas vide, allez les vider !");
                    }
                } while (response == false);

            }
            else
            {
                Console.WriteLine("Pensez à les ranger !!!!");
            }
            response = ResponseUser("Fait-il beau ?");
            if (response == true)
            {
                Console.WriteLine("Vous allez vous promener le long de la rivière.");
                response = ResponseUser("Vous sentez vous en forme ?");
                bool tmp = ResponseUser("Ete vous assez échauffé ?");
                if (response == true && tmp == true)
                {
                    Console.WriteLine("Vous pouvez profiter des instalations sportive, amusez vous bien !");
                }
                else
                {
                    if (response == true)
                    {
                        Console.WriteLine("Vous n'ête pas assez échauffé, vous pouvez aller explorer la faune et la flore. Pensez a rentrer a midi pour manger !");
                    }
                    else
                    {
                        Console.WriteLine("Vous n'ête pas en forme, vous pouvez aller explorer la faune et la flore. Pensez a rentrer a midi pour manger !");

                    }
                }
            }
            else
            {
                response = ResponseUser("Y a-t-il neigé cette nuit passé ?");
                if (response == false)
                {
                    Console.WriteLine("Il ne fait pas beau et pas de neige, vous restez chez vous bien au chaud.");
                    bool coffee = ResponseUser("Voulez vous du caffé ?");
                    if (coffee == true)
                    {
                        Console.WriteLine("Faite coullé le caffé !");
                    }
                    else
                    {
                        bool tea = ResponseUser("Voulez vous du thé ?");
                        if (tea == true)
                        {
                            Console.WriteLine("Allez faire chauffer l'eau !");
                        }
                    }
                    response = ResponseUser("Votre connexion internet est-elle bonne ?");
                    if (response == true)
                    {
                        Console.WriteLine("Vous pouvez continuer votre série !");
                    }
                    else
                    {
                        Console.WriteLine("Votre connextion n'est pas bonne, allez prendre un livre de votre auteur favoris.");
                    }
                    response = ResponseUser("Ete-vous motivé a faire a mangé ?");
                    if (response == true)
                    {
                        Console.WriteLine("Vous mangez des petits pois, purée de carottes et un steak");
                    }
                    else
                    {
                        Console.WriteLine("Vous mangez un sandwich fait rapidement avec salade, tomate, cornichon, oeufs durs, jambon et beurre");
                    }
                }
                else
                {
                    response = ResponseUser("Reste-il de la neigé au sol ?");
                    if (response == true)
                    {
                        Console.WriteLine("Prenez vos gants, votre bonnet et votre écharpe.");
                        response = ResponseUser("Votre voiture était elle dans votre garage cette nuit ?");
                        if (response == false)
                        {
                            Console.WriteLine("Prenez votre pelle et dégagez votre voiture !");
                            response = ResponseUser("Avez vous ranger votre pelle ?");
                            if (response == false)
                            {
                                Console.WriteLine("Allez la ranger et ne jouez pas avec Bernie :) !");
                            }
                            response = ResponseUser("Partez vous faire faire du ski ?");
                            if (response == true)
                            {
                                Console.WriteLine("Vous devez trouver un restaurant pour manger");
                                do
                                {
                                    response = ResponseUser("Y a t il de la place au restaurant ?");
                                    if (response == false)
                                    {
                                        Console.WriteLine("Refaite la même piste en attendant une place !");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Il y a de la place vous pouvez aller manger !");
                                    }

                                } while (response == false);
                                Console.WriteLine("Vous pouvez retourner sur les pistes !");
                                do
                                {
                                    response = ResponseUser("Est_il l'heure de la fermeture ?");
                                    if (response == false)
                                    {
                                        Console.WriteLine("Vous pouvez continuer a skier !");
                                    }
                                    else
                                    {
                                        Console.WriteLine("C'est l'heure de partir, vous rentrez chez vous !");
                                    }

                                } while (response == false);
                                Console.WriteLine("Vous venez de rentrer du ski, vous ete trop fatigué et vous commandez !");
                            }
                            else
                            {
                                response = ResponseUser("Vos amis sont-ils disponible pour sortir ?");
                                if (response == true)
                                {
                                    Console.WriteLine("Vous sortez avec vos amis et vous irez peut être au restaurant !");
                                }
                                else
                                {
                                    Console.WriteLine("Vos amis ne sont pas disponibles, vous pouvez lancer votre jeux multijoueur en ligne et vous regardez si il y a quelqu'un de connecté !");
                                    response = ResponseUser("Vos amis sont-ils connectés ?");
                                    if (response == false)
                                    {
                                        Console.WriteLine("Finalement personne n'est connectés, vous allez plutôt vous occuper de vos plantes.\nVous aurez le temps de préparer un petit festin et invitez toute votre famille");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vos amis sont connecté, vous pouvez commencer une partie en ligne !\nVous oubliez le temps et devez faire un truc rapide !");
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }

        private static string TrueOrFalse(string message)
        {
            do
            {
                Console.WriteLine(message + "\nRépondez par 'vrai' ou par 'faux' !");
                string userEntry = Console.ReadLine();
                if (userEntry.ToLower() == "vrai")
                {
                    return "vrai";
                }
                else if (userEntry.ToLower() == "faux")
                {
                    return "faux";
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas répondu par 'vrai' ou par 'faux', recommencez :");
                }
            } while (true);
        }

        private static bool ResponseUser(string message)
        {
            Console.WriteLine(message + " répondez par 'oui' ou par 'non' !");
            do
            {
                string userEntry = Console.ReadLine();
                if (userEntry.ToLower() == "oui")
                {
                    return true;
                }
                else if (userEntry.ToLower() == "non")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas répondu par 'oui' ou 'non' recommencez :");
                }
            } while (true);
        }

        private static int AskANumber(string message)
        {
            Console.WriteLine(message);
            do
            {
                string userEntry = Console.ReadLine();
                try
                {
                    return int.Parse(userEntry);
                }
                catch (Exception)
                {

                    Console.WriteLine("Vous n'avez pas entrer un nombre, recommencez :");
                }
            } while (true);
        }
    }
}
