namespace Assignment4D05
{
    internal class Program
    {
        //protective code example more advanced and readable 
        class Department
        {
            public int code { get; set; }
            public string? name { get; set; } = null;
        }
        class Employee      //dafault access mofifier is internal and i can write all access modifiers in class 
        {
            public int id { get; set; }
            public string? name { get; set; } = null;
            public int age { get; set; }
            public string? email { get; set; }= null;
            public Department? department { get; set; }
        }
        static void Main(string[] args)
        {
            #region Boxing&UnBoxing
            object obj = new object();// no thing 
             
            obj = 1;//boxing 
            obj = "string reference type ";//non thing 
            obj = true;//boxing
            /*-we find when we try to  assign reference type to obj(of reference type ) there is no thing happen ,in another case when we try 
             to assign value type to obj(of reference type ) some thing happened called boxing(CLR does it operation)
            ( a value type is boxed, the runtime creates a new object on the heap.The value of the value type is copied into the newly allocated object on the heap.)  */
            
            
            
            //the last value in obj is true notice 
            //bool flag = obj;
            //you can't do it if you want to do it you should give Covenant to clr 
            bool flag =(bool)obj;
            //but itsn't safe 
            //  For your information boxing and unboxung using before genaric As an alternative of it 


            #endregion

            #region NUllableTypes
            //null isn' avalid value for variales of data type value type 
            //null  is avalid value for variable of data type reference type 
            //int age = null; //is false 
            int? x = null;
            //int y = x;    is false because null not valid for y(int ) to make y alloe null 
            int? y = x;
            // for another example 
            int ?z = null;
            //int j = (int)z;//that is  not safe and not good to use (from nullable to value type );
            #endregion

            #region protectiveCodeWithNullable 
            // if you want check to write aprotective code 
            if (x.HasValue)
                y = x.Value;
            else y = 0;
            // y will assign zero 
            // or you can write it on this
            // (y=x.HasValue ? x.Value : 0; )
            //(syntax sugar )
            //y = x ?? 0;
            //int[]? arr = default;
            //for(int i = 0;i<arr.Length;i++)
            //{
            //    Console.WriteLine(i);
            //}
            //this code isn't good so we can write it into protective code using if condition or  
            //for (int i = 0; arr is not null &&i < arr.Length; i++)
            //the best is to write if condition check the array is not null before go throw  the for loop 
            //with class employee 
            Employee employee = new Employee()
            {
                id = 1,
                name = "Bilal",
                age = 24,
                department = new Department()
                {
                    code = 1001
                    
                }
            };
            Console.WriteLine(employee?.department?.name ??"No Name");
            #endregion

            #region Exception Handling 

            //exception is abig class have alot of excitption  inherit from him such divide by zero or out of range 
            bool tq;
            int num1, num2;

            try
            {
                do
                {
                    Console.WriteLine("enter your first number1 ");
                    tq = int.TryParse(Console.ReadLine(), out num1);
                }
                while (!tq);
                do
                {
                    Console.WriteLine("enter your first number2 ");
                    tq = int.TryParse(Console.ReadLine(), out num2);
                }
                while (!tq);
                Console.WriteLine(num1 / num2);
                throw new Exception();//for throw new exception if i want or create exception if i want 
            }
            catch
            (Exception ex)
            {
                Console.WriteLine(ex.Message);//if user put zero in num 2 it will throw the exception 
            }
            finally
            {
                //is the part that also run if you have exception or not 
                //(dellocate ,release ,delete ,free close )
                Console.WriteLine("Finally ");
            }
            #endregion
        }
    }
}
