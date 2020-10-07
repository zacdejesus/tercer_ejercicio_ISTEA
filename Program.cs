using System;

namespace tercer_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalVotosPedro = 0;
            int totalVotosPablo = 0;
            int totalVotosIguita = 0;
            int totalVotosCacerola = 0;
            int totalVotosJose = 0;
            int porcentarjeVotosPedro = 0;
            int porcentarjeVotosPablo = 0;
            int porcentarjeVotosIguita = 0;
            int porcentarjeVotosCacerola = 0;
            int porcentarjeVotosJose = 0;
            int votosTotales = 0;

            int ganadorPorcentaje1 = 0;
            string ganadorPorcentajeStr1 = "";

            int ganadorPorcentaje2 = 0;
            string ganadorPorcentajeStr2 = "";

            int[] totalPorcentajesArray = new int[5];

            int ganadorPorcentaje = 0;
            string ganadorPorcentajeStr = "";

            totalPorcentajesArray[0] = porcentarjeVotosPedro;
            totalPorcentajesArray[1] = porcentarjeVotosJose;
            totalPorcentajesArray[2] = porcentarjeVotosCacerola;
            totalPorcentajesArray[3] = porcentarjeVotosPablo;
            totalPorcentajesArray[4] = porcentarjeVotosIguita;

            int[] totalVotosArray = new int[5];

            totalVotosArray[0] = totalVotosPedro;
            totalVotosArray[1] = totalVotosJose;
            totalVotosArray[2] = totalVotosCacerola;
            totalVotosArray[3] = totalVotosPablo;
            totalVotosArray[4] = totalVotosIguita;

            int ganador = 0;
            string ganadorStr = "";

            string[,] matrizVotaciones = new string[4, 6];
            string[] canditatosArray = new string[5];

            canditatosArray[0] = "pedro";
            canditatosArray[1] = "jose";
            canditatosArray[2] = "cacerola";
            canditatosArray[3] = "pablo escobar";
            canditatosArray[4] = "Iguita";

            matrizVotaciones[0, 0] = "mesa 1";
            matrizVotaciones[0, 1] = "2310";
            matrizVotaciones[0, 2] = "10213";
            matrizVotaciones[0, 3] = "100";
            matrizVotaciones[0, 4] = "100";
            matrizVotaciones[0, 5] = "32";

            matrizVotaciones[1, 0] = "mesa 2";
            matrizVotaciones[1, 1] = "5533";
            matrizVotaciones[1, 2] = "333";
            matrizVotaciones[1, 3] = "300";
            matrizVotaciones[1, 4] = "100";
            matrizVotaciones[1, 5] = "2332";

            matrizVotaciones[2, 0] = "mesa 3";
            matrizVotaciones[2, 1] = "343";
            matrizVotaciones[2, 2] = "2342";
            matrizVotaciones[2, 3] = "250";
            matrizVotaciones[2, 4] = "100";
            matrizVotaciones[2, 5] = "3322";

            matrizVotaciones[3, 0] = "mesa 4";
            matrizVotaciones[3, 1] = "3023";
            matrizVotaciones[3, 2] = "432";
            matrizVotaciones[3, 3] = "200";
            matrizVotaciones[3, 4] = "100";
            matrizVotaciones[3, 5] = "1212";

            Console.Write("                              pedro              jose             cacerola          pablo escobar            Iguita\n");

            for (int f = 0; f < matrizVotaciones.GetLength(0); f++)
            {
                for (int c = 0; c < matrizVotaciones.GetLength(1); c++)
                {
                    if (!string.IsNullOrEmpty(matrizVotaciones[f, c]))
                    {
                        if (c == 0)
                        {
                            Console.Write("          {0,-10}", matrizVotaciones[f, c]);
                        }
                        else if (c == 1)
                        {
                            Console.Write("          {0,-10}", matrizVotaciones[f, c]);
                        }
                        else if (c == 2)
                        {
                            Console.Write("          {0,-10}", matrizVotaciones[f, c]);
                        }
                        else if (c == 3)
                        {
                            Console.Write("          {0,-10}", matrizVotaciones[f, c]);
                        }
                        else if (c == 4)
                        {
                            Console.Write("          {0,-10}", matrizVotaciones[f, c]);
                        }
                        else if (c == 5)
                        {
                            Console.Write("          {0,-10}", matrizVotaciones[f, c]);
                        }
                        else if (c == 6)
                        {
                            Console.Write("          {0,-10}", matrizVotaciones[f, c]);
                        }
                        else if (c == 7)
                        {
                            Console.Write("          {0,-10}", matrizVotaciones[f, c]);
                        }
                        else if (c == 8)
                        {
                            Console.Write("          {0,-10}", matrizVotaciones[f, c]);
                        }
                        else if (c == 9)
                        {
                            Console.Write("          {0,-10}", matrizVotaciones[f, c]);
                        }
                        else if (c == 10)
                        {
                            Console.Write("          {0,-10}", matrizVotaciones[f, c]);
                        }
                        else
                        {
                            Console.Write($"{matrizVotaciones[f, c],-3}\n");
                        }
                    }

                }
                Console.WriteLine("");  // salto de linea para mostrar la siguiente fila abajo 
            }

            Console.Write("\n\n");
            for (int c = 0; c < matrizVotaciones.GetLength(0); c++)
            {
                int votosMesa1 = int.Parse(matrizVotaciones[c, 1]);

                totalVotosPedro = votosMesa1 + totalVotosPedro;
            }

            for (int c = 0; c < matrizVotaciones.GetLength(0); c++)
            {
                int votosMesa1 = int.Parse(matrizVotaciones[c, 2]);

                totalVotosJose = votosMesa1 + totalVotosJose;
            }

            for (int c = 0; c < matrizVotaciones.GetLength(0); c++)
            {
                int votosMesa1 = int.Parse(matrizVotaciones[c, 3]);

                totalVotosCacerola = votosMesa1 + totalVotosCacerola;
            }

            for (int c = 0; c < matrizVotaciones.GetLength(0); c++)
            {
                int votosMesa1 = int.Parse(matrizVotaciones[c, 4]);

                totalVotosPablo = votosMesa1 + totalVotosPablo;
            }

            for (int c = 0; c < matrizVotaciones.GetLength(0); c++)
            {
                int votosMesa1 = int.Parse(matrizVotaciones[c, 5]);

                totalVotosIguita = votosMesa1 + totalVotosIguita;
            }

            votosTotales = totalVotosPedro + totalVotosJose + totalVotosCacerola + totalVotosPablo + totalVotosIguita;

            porcentarjeVotosPedro = (totalVotosPedro * 100) / votosTotales;
            porcentarjeVotosJose = (totalVotosJose * 100) / votosTotales;
            porcentarjeVotosCacerola = (totalVotosCacerola * 100) / votosTotales;
            porcentarjeVotosPablo = (totalVotosPablo * 100) / votosTotales;
            porcentarjeVotosIguita = (totalVotosIguita * 100) / votosTotales;

            Console.Write($"Pedro con -> {totalVotosPedro} votos es un {porcentarjeVotosPedro}%\n");
            Console.Write($"Jose con -> {totalVotosJose} votos es un {porcentarjeVotosJose}%\n");
            Console.Write($"Cacerola con -> {totalVotosCacerola} votos es un {porcentarjeVotosCacerola}%\n");
            Console.Write($"Pablp con -> {totalVotosPablo} votos es un {porcentarjeVotosPablo}%\n");
            Console.Write($"Iguita con -> {totalVotosIguita} votos es un {porcentarjeVotosIguita}%\n\n");

            for (int c = 0; c < totalVotosArray.Length; c++)
            {
                if (totalVotosArray[c] > ganador)
                {
                    ganador = totalVotosArray[c];
                    ganadorStr = canditatosArray[c];
                }
            }

            Console.Write($"el candidato mas votado es {ganadorStr} con la cantindad de votos {ganador}\n");

            for (int c = 0; c < totalPorcentajesArray.Length; c++)
            {
                if (totalPorcentajesArray[c] > 50)
                {
                    ganadorPorcentaje = totalPorcentajesArray[c];
                    ganadorPorcentajeStr = canditatosArray[c];
                }
            }


            if (ganadorPorcentaje > 0){
                Console.Write($"el ganador es {ganadorPorcentajeStr} con el porcentaje de votos {ganadorPorcentaje}\n\n");
            }
            else
            {
                for (int c = 0; c < totalPorcentajesArray.Length; c++)
                {
                    if (totalPorcentajesArray[c] > ganadorPorcentaje1 && ganadorPorcentaje1 == 0)
                    {
                        ganadorPorcentaje1 = totalPorcentajesArray[c];
                        ganadorPorcentajeStr1 = canditatosArray[c];
                    }
                    else if (totalPorcentajesArray[c] > ganadorPorcentaje2)
                    {
                        ganadorPorcentaje2 = totalPorcentajesArray[c];
                        ganadorPorcentajeStr2 = canditatosArray[c];
                    }
                }
                Console.Write($"los que pasan a segunda ronda {ganadorPorcentajeStr1} y {ganadorPorcentajeStr2}\n");
            }
        }
    }
}
