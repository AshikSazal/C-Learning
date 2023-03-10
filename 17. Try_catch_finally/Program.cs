using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace MultipleInheritance
{
    // Make custom Error types
    class CustomError : Exception
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Risky code here
            } catch(System.Net.Http.HttpRequestException e) when(e.Message.Contains("301")) 
            {
                // site moved
            }
            catch (Exception e)
            {
                // Handle error
            }
            finally
            {
                // This will run not matter what
            }
        }

        void ExampleMethod(object obj)
        {
            if(obj == null)
            {
                throw new NullReferenceException("Sudent object is null.");
            }
        }
    }
}
