using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace StBarnabasHospiceTable.Client.Tests
{
    public class TestHelpers
    {
        public static Type GetClassType(string fullName)
        {
            Type parentType = typeof(ComponentBase);
            Assembly assembly = Assembly.Load("StBarnabasHospiceTable");
            Type[] types = assembly.GetTypes();

            IEnumerable<Type> subclasses = types.Where(t => t.IsSubclassOf(parentType));

            var found = subclasses.FirstOrDefault(x => x.FullName == fullName);

            if (found == null)
            {
                found = assembly.GetTypes().FirstOrDefault(x => x.FullName == fullName);
            }

            return found;
        }

        public static string GetRootString()
        {
            return ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar;
        }
    }
}
