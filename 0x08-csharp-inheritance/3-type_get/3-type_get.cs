using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();
        TypeInfo t = type.GetTupeInfo();
        IEnumerable<PropertyInfo> pList = t.GetProperties();
        IEnumerable<MethodInfo> mList = t.GetMethods();

        System.Console.WriteLine("{0} Properties:", t.Name);
        foreach (PropertyInfo p in pList)
        {
            System.Console.WriteLine(p.Name);
        }
        
        System.Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo m in mList)
        {
            System.Console.WriteLine(m.Name);
        }
    }
}