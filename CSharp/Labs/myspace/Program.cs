namespace myspace
{
    internal class Program
    {
        interface IA
        {
            public void sayHi()
            {
                Console.WriteLine("from IA");
            }
        }
        interface IB
        {
            public void sayHi()
            {
                Console.WriteLine("from IB");
            }
        }
        class C : IA, IB 
        {
            
        }
        static void Main(string[] args)
        {
            C c = new C();
            // c didn't know anything about sayHi()

            IB c1 = new C();
            c1.sayHi(); //from IB

            IA c2 = new C();
            c2.sayHi(); //from IA
        }
    }
}
