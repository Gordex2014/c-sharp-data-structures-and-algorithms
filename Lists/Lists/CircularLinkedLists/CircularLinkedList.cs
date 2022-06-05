using System.Collections;

namespace Lists.CircularLinkedLists;

public class CircularLinkedList<T> : LinkedList<T>
{
    public new IEnumerator GetEnumerator()
    {
        return new CircularLinkedListEnumerator<T>(this);
    }
}