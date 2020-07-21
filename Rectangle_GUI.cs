using System;
using System.IO;

namespace C4
{
    class Rectangle_GUI
    {
        private protected Double firstSideLenght;
        private protected Double secondSideLenght;

        public double FirstSideLenght { get => firstSideLenght; set => firstSideLenght = value; }
        public double SecondSideLenght { get => secondSideLenght; set => secondSideLenght = value; }

        public double GetDiagonal()
        {
            return Math.Sqrt(firstSideLenght * firstSideLenght + secondSideLenght * secondSideLenght);
        }

        public double Perimeter()
        {
            return 2 * (firstSideLenght + secondSideLenght);
        }

        public double GetSquare()
        {
            return firstSideLenght * secondSideLenght;
        }

        public void Load(ref BinaryReader binaryReader)
        {
            firstSideLenght = binaryReader.ReadDouble();
            secondSideLenght = binaryReader.ReadDouble();
        }

        public void Save(ref BinaryWriter binaryWriter)
        {
            binaryWriter.Write(firstSideLenght);
            binaryWriter.Write(secondSideLenght);
        }

        public override string ToString()
        {
            return $"\nFirst side lenght = {String.Format("{0:0.0}", firstSideLenght)}" +
                  $"\nSecond side lenght = {String.Format("{0:0.0}", secondSideLenght)}" +
                  $"\nDiagonal = {String.Format("{0:0.0}", GetDiagonal())}" +
                  $"\nPerimeter = {String.Format("{0:0.0}", Perimeter())}" +
                  $"\nSquare = {String.Format("{0:0.0}", GetSquare())}\n";
        }
    }
}