using System.IO;

string filePath = "path/to/file.csv";
using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("Name,Surname,Street,City,Province,ZIP");
    writer.WriteLine("John,Doe,120 jefferson st.,Riverside,NJ,08075");
    writer.WriteLine("Jack,McGinnis,220 hobo Av.,Phila,PA,09119");
    writer.WriteLine("John Da Man,Repici,120 Jefferson St.,Riverside,NJ,08075");
    writer.WriteLine("Stephen,Tyler,7452 Terrace \"At the Plaza\" road,SomeTown,SD,91234");
    writer.WriteLine("Joan,Anne,Jet,9th at Terrace plc,Desert City,CO,00123");
    writer.WriteLine(",Blankman,,New York, NY, 100101");
    writer.WriteLine("Joan,SomeTown,SD,00298");
}