namespace task_5
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            //Queue<int> queue = new Queue<int>(3);

            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            ////queue.Enqueue(50);

            //Console.WriteLine(queue.Dequeue()); 
            //Console.WriteLine(queue.Dequeue()); 

            //queue.Enqueue(40);

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());


            //Console.WriteLine(queue.IsEmpty());

            #region parse vs try-parse vs convert

            try
            {
                Point3D p = new();
                int x, y, z;
                //parse
                Console.WriteLine("x: ");
                x = int.Parse(Console.ReadLine());

                //try-parse
                Console.WriteLine("y: ");
                bool yStatus = int.TryParse(Console.ReadLine(), out y);
                if (!yStatus)
                {
                    throw new Exception("invalid input for y");
                }

                //convert
                Console.WriteLine("Enter z (press Enter for null): ");
                string zInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(zInput))
                {
                    throw new Exception("Input for z is null or empty");
                }
                else
                {
                    z = Convert.ToInt32(zInput);
                }

                p.X = x;
                p.Y = y;
                p.Z = z;

                Console.WriteLine(p.ToString());
            }
            catch (Exception ex)
            {
                Utility.LogError(ex);
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region built-in interfaces

            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(5, 1, 3);
            Point3D p3 = new Point3D(4, 2, 3);
            Point3D p4 = new Point3D(4, 3, 3);
            Point3D p5 = new Point3D(3, 7, 3);
            //Point3D[] arrOf3DPoints = [p1, p2, p3, p4, p5];
            Point3D[] arrOf3DPoints = new Point3D[] { p1, p2, p3, p4, p5 };


            Console.WriteLine("before sorting: ");
            for (int i = 0; i < arrOf3DPoints.Length; i++)
            {
                Console.WriteLine(arrOf3DPoints[i].ToString());
            }

            //apply sorting 
            Array.Sort(arrOf3DPoints);

            Console.WriteLine("after sorting: ");
            for (int i = 0; i < arrOf3DPoints.Length; i++)
            {
                Console.WriteLine(arrOf3DPoints[i].ToString());
            }
            #endregion
        }
    }
}
