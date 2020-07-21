using System;
using System.IO;
using System.Text;

namespace C4
{
    class Parallelepipeds_GUI : Rectangles_GUI
    {
        Parallelеpiped_GUI[] parallelеpipeds;
        Byte cubeAmount = 0;

        public Parallelepipeds_GUI(byte size = 0)
        {
            parallelеpipeds = new Parallelеpiped_GUI[size];

            for (int i = 0; i < size; i++)
            {
                parallelеpipeds[i] = new Parallelеpiped_GUI();
            }
        }

        public Boolean SetElement(Double firstSideLength, Double secondSideLength, Double height)
        {
            if (currentElement < parallelеpipeds.Length)
            {
                parallelеpipeds[currentElement].FirstSideLenght = firstSideLength;
                parallelеpipeds[currentElement].SecondSideLenght = secondSideLength;
                parallelеpipeds[currentElement].Height = height;

                currentElement++;

                return true;
            }
            else return false;
        }

        public new Boolean GenerateElement()
        {
            if (currentElement < parallelеpipeds.Length)
            {
                Random random = new Random();

                parallelеpipeds[currentElement].FirstSideLenght = random.NextDouble() * 100 + 1;
                parallelеpipeds[currentElement].SecondSideLenght = random.NextDouble() * 100 + 1;
                parallelеpipeds[currentElement].Height = random.NextDouble() * 100 + 1;

                currentElement++;

                return true;
            }
            else return false;
        }

        public new string Counter()
        {
            return $"Parallelepiped {currentElement}/{parallelеpipeds.Length}";
        }

        public new void Load(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.UTF8);

            parallelеpipeds = new Parallelеpiped_GUI[(byte)(fileStream.Length / sizeof(double) / 3)];

            for (int i = 0; i < parallelеpipeds.Length; i++)
            {
                parallelеpipeds[i] = new Parallelеpiped_GUI();
                parallelеpipeds[i].Load(ref binaryReader);
            }

            currentElement = (byte)parallelеpipeds.Length;

            binaryReader.Close();
            fileStream.Close();
        }

        public new void Save(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.UTF8);

            for (int i = 0; i < currentElement; i++)
            {
                parallelеpipeds[i].Save(ref binaryWriter);
            }

            binaryWriter.Close();
            fileStream.Close();
        }

        public override string ToString()
        {
            AllInfo = null;
            cubeAmount = 0;

            for (int i = 0; i < currentElement; i++)
            {
                AllInfo += $"Parallelepied number {i + 1}:\n{parallelеpipeds[i]}\n";
                if (parallelеpipeds[i].IsCube())
                    cubeAmount++;
            }
            AllInfo += $"Amount of cubes: {cubeAmount}";

            return AllInfo;
        }
    }
}