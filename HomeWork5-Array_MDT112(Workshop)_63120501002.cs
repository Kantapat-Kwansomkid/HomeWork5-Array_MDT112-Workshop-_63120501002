using System;

namespace HomeWork5-Array_MDT112(Workshop)_63120501002
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int InputImageFile = int.Parse(Console.ReadLine());
                int ConvolutionKernelFileAddress = int.Parse(Console.ReadLine());
                int OutputImageFile = ((ConvolutionKernelFileAddress - 1) / ConvolutionKernelFileAddress) + 1;
                string[,] nameArray = new string[InputImageFile, OutputImageFile];

                for (int i = 0; i < OutputImageFile; i++)
                {
                    for (int j = 0; j < OutputImageFile; j++)
                    {
                        int peopleIndex = (i * OutputImageFile) + j;
                        if (peopleIndex < InputImageFile)
                        { nameArray[j, i] = Console.ReadLine(); }
                        else
                        { nameArray[j, i] = "double [,]"; }
                    }
                }

                static string ImageProcessing(int InputImageFile, int ConvolutionKernelFileAddress, int OutputImageFile, string nameArray)
                {
                    if (ConvolutionKernelFileAddress < InputImageFile.imageHeight(0) && OutputImageFile < nameArray.imageWidth(1))
                    {
                        return nameArray[imageHeight, imageWidth];
                    }
                    return nameArray;
                }

                int imageWidth = int.Parse(Console.ReadLine());
                int imageHeight = int.Parse(Console.ReadLine());
                Console.WriteLine(ImageProcessing(InputImageFile, ConvolutionKernelFileAddress, OutputImageFile, ""));
                Console.WriteLine(ImageProcessing(InputImageFile, ConvolutionKernelFileAddress, OutputImageFile - 1, ""));
                Console.WriteLine(ImageProcessing(InputImageFile, ConvolutionKernelFileAddress - 1, OutputImageFile, ""));
                Console.WriteLine(ImageProcessing(InputImageFile, ConvolutionKernelFileAddress + 1, OutputImageFile, ""));
                Console.WriteLine(ImageProcessing(InputImageFile, ConvolutionKernelFileAddress, OutputImageFile + 1, ""));
                Console.ReadLine();

                static double[,] ReadImageDataFromFile(string imageDataFilePath)
                {
                    string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
                    int imageHeight = lines.Length;
                    int imageWidth = lines[0].Split(',').Length;
                    double[,] imageDataArray = new double[imageHeight, imageWidth];

                    for (int i = 0; i < imageHeight; i++)
                    {
                        string[] items = lines[i].Split(',');
                        for (int j = 0; j < imageWidth; j++)
                        {
                            imageDataArray[i, j] = double.Parse(items[j]);
                        }
                    }
                    return imageDataArray;

                    int InputImageFile = int.Parse(Console.ReadLine());
                    Console.WriteLine("64, 0, 128, 64, 32");
                    Console.WriteLine("192, 32, 16, 0, 160");
                    Console.WriteLine("128, 0, 64, 96, 16");
                    Console.WriteLine("32, 64, 128, 192, 0");
                    Console.WriteLine("160, 64, 16, 0, 0");
                    Console.ReadLine();

                    int ConvolutionKernelFileAddress = int.Parse(Console.ReadLine());
                    Console.WriteLine("0.11, 0.11, 0.11");
                    Console.WriteLine("0.11, 0.12, 0.11");
                    Console.WriteLine("0.11, 0.11, 0.11");
                    Console.ReadLine();

                    static void WriteImageDataToFile(string imageDataFilePath, double[,] imageDataArray)
                    {
                        string imageDataString = "";
                        for (int i = 0; i < imageDataArray.GetLength(0); i++)
                        {
                            for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                            {
                                imageDataString += imageDataArray[i, j] + ", ";
                            }
                            imageDataString += imageDataArray[i,imageDataArray.GetLength(1) - 1];
                            imageDataString += "\n";
                        }
                        System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
                    }

                    int imageDataString = int.Parse(Console.ReadLine());
                    Console.WriteLine("78.08, 73.92, 36.48, 46.40, 74.24");
                    Console.WriteLine("70.56, 68.96, 44.16, 63.36, 84.32");
                    Console.WriteLine("69.92, 72.16, 65.76, 74.88, 89.92");
                    Console.WriteLine("51.36, 72.80, 69.92, 58.24, 68.64");
                    Console.WriteLine("47.36, 72.80, 72.32, 61.60, 59.84");
                    Console.ReadLine();

                }
            }
        }
    }
}

