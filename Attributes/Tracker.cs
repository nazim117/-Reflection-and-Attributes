using AuthorProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var type = typeof(StartUp);

            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | 
                BindingFlags.Public | 
                BindingFlags.Static);

            foreach (MethodInfo method in methods)
            {
                var authorAttribute = (AuthorAttribute)Attribute
                    .GetCustomAttribute(method, typeof(AuthorAttribute));
                if (authorAttribute != null)
                {
                    Console.WriteLine("{0} is written by {1}", method.Name, authorAttribute.Name);
                }
                
            }
        }
    }
}
