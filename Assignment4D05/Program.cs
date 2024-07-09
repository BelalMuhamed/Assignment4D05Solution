namespace Assignment4D05
{
    internal class Program
    {
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
            int j = (int)z;//that is  not safe and not good to use (from nullable to value type );
            #endregion
        }
    }
}
