using System;
using System.Collections.Generic;

public class Queue<T>
{
    public string CheckType() {
        return (typeof(T).ToString());
    }
}
