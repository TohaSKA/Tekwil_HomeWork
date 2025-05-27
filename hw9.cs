//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp_less1
//{
//    class HW9
//    {

//        static Dictionary<string, string> bazaDeDate = new Dictionary<string, string>()
//    {
//        { "admin_test", "Admin_pass" },
//        { "user_test", "Pass123" },
//        { "user2_test", "User2_pass" }
//    };
//        static void Autentificare(string username, string parola) 
//        {
//            if (string.IsNullOrWhiteSpace(username))
//                throw new NumeUtiliceptiozatorGolException("Numele de utilizator nu poate fi gol.");

//            if (parola.Length < 8)
//                throw new ParolaPreaScurtaException("Parola este prea scurta. Trebuie sa aiba cel putin 6 caractere.");

//            if (!parola.Any(char.IsUpper) || !parola.Any(char.IsLower) || !parola.Any(char.IsDigit))
//                throw new ParolaInvalidaException("Parola trebuie sa contina cel putin o litera mare, una mica si un numar.");

//            if (!bazaDeDate.ContainsKey(username) || bazaDeDate[username] != parola)
//                throw new CredentialeInvalideExn("Numele de utilizator sau parola sunt incorecte.");

//        }


//        static void Main(string[] args)
//        {
//            #region sarcina1
//            /*
//                        List<float> note = new List<float>();
//                        while (note.Count < 4)
//                        {
//                            Console.Write("Introdu nota " + (note.Count + 1) + ": ");
//                            try
//                            {
//                                string input = Console.ReadLine();
//                                float nota = float.Parse(input);

//                                if (nota < 0 || nota > 10)
//                                {
//                                    throw new NotaInvalidaException("Nota trebuie sa fie intre 0 si 10.");
//                                }

//                                note.Add(nota);
//                            }
//                            catch (NotaInvalidaException ex)
//                            {
//                                Console.WriteLine("Eroare: " + ex.Message);
//                            }
//                            catch (FormatException)
//                            {
//                                Console.WriteLine("Eroare: Trebuie sa introduci un numar valid (ex: 7,5).");
//                            }
//                            catch (Exception ex)
//                            {
//                                Console.WriteLine("Eroare necunoscuta: " + ex.Message);
//                            }
//                        }
//                        float suma = note.Sum();
//                        float media = suma / note.Count;

//                        Console.WriteLine("\nMedia notelor este: " + media);
//            */
//            #endregion
//            #region sarcina2
//            try
//            {
//                Console.Write("Introduce numele de utilizator: ");
//                string username = Console.ReadLine();

//                Console.Write("Introduce parola: ");
//                string parola = Console.ReadLine();

//                Autentificare(username, parola);
//                Console.WriteLine("\nAutentificare reusita! " + username + "!");
//            }
//            catch (NumeUtiliceptiozatorGolException ex)
//            {
//                Console.WriteLine("Eroare: " + ex.Message);
//            }
//            catch (ParolaPreaScurtaException ex)
//            {
//                Console.WriteLine("Eroare: " + ex.Message);
//            }
//            catch (ParolaInvalidaException ex)
//            {
//                Console.WriteLine("Eroare: " + ex.Message);
//            }
//            catch (CredentialeInvalideExn ex)
//            {
//                Console.WriteLine("Eroare: " + ex.Message);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Eroare neașteptată: " + ex.Message);
//            }
//            #endregion
//        }
//    }
//}
