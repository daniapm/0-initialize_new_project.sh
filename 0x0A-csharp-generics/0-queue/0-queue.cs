using System;
using System.Collections.Generic;

class Queue<T>
{
    public String CheckType() {
        return (typeof(T).ToString());
    }
}
