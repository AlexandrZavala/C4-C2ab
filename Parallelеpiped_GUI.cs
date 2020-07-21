using System;
using System.IO;

namespace C4
{
    class Parallelеpiped_GUI : Rectangle_GUI
    {
        Double height;

        public double Height { get => height; set => height = value; }

        public bool IsCube()
        {
            return secondSideLenght == firstSideLenght && firstSideLenght == height ? true : false;
        }

        public new double GetSquare()
        {
            return 2 * (firstSideLenght * secondSideLenght + secondSideLenght * height + firstSideLenght * height);
        }

        public double GetCapacity()
        {
            return height * firstSideLenght * secondSideLenght;
        }

        public new void Save(ref BinaryWriter binaryWriter)
        {
            binaryWriter.Write(firstSideLenght);
            binaryWriter.Write(secondSideLenght);
            binaryWriter.Write(height);
        }

        public new void Load(ref BinaryReader binaryReader)
        {
            firstSideLenght = binaryReader.ReadDouble();
            secondSideLenght = binaryReader.ReadDouble();
            height = binaryReader.ReadDouble();
        }

        public override string ToString() => $"\nFirst side lenght = {String.Format("{0:0.0}", firstSideLenght)}" +
                $"\nSecond side lenght = {String.Format("{0:0.0}", secondSideLenght)}" +
                $"\nHeight lenght = {String.Format("{0:0.0}", height)}" +
                $"\nSquare = {String.Format("{0:0.0}", GetSquare())}" +
                $"\nCapacity = {String.Format("{0:0.0}", GetCapacity())}\n";
    }
}