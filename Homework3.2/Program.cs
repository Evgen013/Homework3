
/*Створити клас, який представляє навчальний клас ClassRoom. Створіть клас учень Pupil. 
 * 
 * У тілі класу створіть методи void Study(), void Read(), void Write(), void Relax(). 
 * 
 * Створіть 3 похідні класу ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil і перевизначте кожен із методів,
 * залежно від успішності учня. 
 * 
 * Конструктор класу ClassRoom приймає аргументи типу Pupil, клас має складатися із 4 учнів.
 * 
 * Передбачте можливість, що користувач може передати 2 або 3 аргументи. Виведіть інформацію про те, 
 * як усі учні екземпляра класу ClassRoom вміють вчитися, читати, писати, відпочивати. */


namespace Homework3._2
{
    class ClassRoom
    {
       
    }
    class Pupil
    {
        public int gradeStudy;
        public int gradeRead;
        public int gradeWrite;
        public int gradeRelax;

        public virtual void Study(int gradeStudy)
        {
            Console.WriteLine(gradeStudy);
        }
        public virtual void Read()
        {
            Console.WriteLine(gradeRead);
        }
        public virtual void Write()
        {
            
        }
        public virtual void Relax()
        {
            
        }
    }

    class ExcellentPupil : Pupil 
    {
        public int gradeStudy;
        public override void Study(int gradeStudy) 
        {
            if (gradeStudy == 5) 
            {
                Console.WriteLine("STUDY excellent");
            }
            else
            {
                
            }
                    
            /*switch (this.gradeStudy) 
            {
                case 5:
                    Console.WriteLine("study excellent");
                    break;
            }*/
        }
        public override void Read()
        {
            switch (gradeRead)
            {
                case 5:
                    Console.WriteLine("study excellent");
                    break;
            }
        }
        public override void Write()
        {
            switch (gradeWrite)
            {
                case 5:
                    Console.WriteLine("study excellent");
                    break;
            }
        }
        public override void Relax()
        {
            switch (gradeRelax)
            {
                case 5:
                    Console.WriteLine("study excellent");
                    break;
            }
        }
    }
    class GoodPupil : Pupil 
    {
        public override void Study(int gradeStudy)
        {
            
            if (gradeStudy == 4)
                {
                Console.WriteLine("good study");

            }
            /*switch (gradeStudy)
            {
                case 4:
                    Console.WriteLine("good");
                    break;
            }*/
        }
        public override void Read()
        {
            switch (gradeRead)
            {
                case 4:
                    Console.WriteLine("good");
                    break;
            }
        }
        public override void Write()
        {
            switch (gradeWrite)
            {
                case 4:
                    Console.WriteLine("good");
                    break;
            }
        }
        public override void Relax()
        {
            switch (gradeRelax)
            {
                case 4:
                    Console.WriteLine("good");
                    break;
            }
        }
    }
    class BadPupil : Pupil
    {
        public override void Study(int gradeStudy)
        {
            switch (gradeStudy)
            {
                case 3:
                    Console.WriteLine("everage");
                    break;
                case 2:
                    Console.WriteLine("bad");
                    break;
                case 1:
                    Console.WriteLine("very bad");
                    break;

            }
        }
        public override void Read()
        {
            switch (gradeRead)
            {
                case 3:
                    Console.WriteLine("everage");
                    break;
                case 2:
                    Console.WriteLine("bad");
                    break;
                case 1:
                    Console.WriteLine("very bad");
                    break;

            }
        }
        public override void Write()
        {
            switch (gradeWrite)
            {
                case 3:
                    Console.WriteLine("everage");
                    break;
                case 2:
                    Console.WriteLine("bad");
                    break;
                case 1:
                    Console.WriteLine("very bad");
                    break;

            }
        }
        public override void Relax()
        {
            switch (gradeRelax)
            {
                case 3:
                    Console.WriteLine("everage");
                    break;
                case 2:
                    Console.WriteLine("bad");
                    break;
                case 1:
                    Console.WriteLine("very bad");
                    break;

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
             //ClassRoom room = new ClassRoom();

           // Pupil pupil = new Pupil();

            ExcellentPupil excellentPupil = new ExcellentPupil();
            GoodPupil goodPupil = new GoodPupil();
            BadPupil badPupil = new BadPupil();

            /*excellentPupil.gradeStudy = 1;
            excellentPupil.gradeRead = 1;
            excellentPupil.gradeWrite = 1;
            excellentPupil.gradeRelax = 1;

            goodPupil.gradeStudy = 1;
            goodPupil.gradeRead = 1;
            goodPupil.gradeWrite= 1;
            goodPupil.gradeRelax = 1;

            badPupil.gradeStudy= 1;
            badPupil.gradeRead= 1;
            badPupil.gradeWrite = 1;
            badPupil.gradeRelax = 1;*/


            excellentPupil.Study(4);
            excellentPupil.Read(5);


            excellentPupil.Read();

            /*pupil.Write(pupil.gradeWrite);
            pupil.Relax(pupil.gradeRelax);*/

            //Console.WriteLine(excellentPupil.gradeStudy);



            Console.ReadKey();
        }
    }
} 

//подивитись на 1:24:00 