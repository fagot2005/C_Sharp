using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil ivan = new Pupil();
            Pupil stepan = new Pupil();
            Pupil petro = new Pupil();
            Pupil dmitro = new Pupil();

        }
    }

    class Pupil
    {

        public virtual void Study()
        {
        }

        public virtual void Read()
        {
        }

        public virtual void Write()
        {
        }

        public virtual void Relax()
        {
        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {

        }

        public override void Read()
        {

        }

        public override void Write()
        {
            
        }

        public override void Relax()
        {
            
        }
    }
    class GoodPupil : Pupil
    {
    }
    class BadPupil : Pupil
    {
    }
}
