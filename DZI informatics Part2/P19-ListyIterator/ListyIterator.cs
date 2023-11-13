using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class ListyIterator<T>:IEnumerable<T>
{
	private List<T> collection;
	public ListyIterator(List<T> list)
	{
		this.collection = list;
	}
	public bool Move()
	{
		return collection.GetEnumerator().MoveNext();
	}
    public bool HasNext()
    {
		if (collection.GetEnumerator().MoveNext())
		{
			return true;
		}
		else
		{
			return false;
		}
    }
	public void Print()
	{
		Console.WriteLine(GetEnumerator().Current);
	}
    public void PrintAll()
    {
		foreach (var item in collection )
		{
			Console.WriteLine(item);
		}
    }
    public IEnumerator<T> GetEnumerator()
    {
		for (int i = 0; i < collection.Count; i++)
		{
			yield return collection[i];
		}
    }

    IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
