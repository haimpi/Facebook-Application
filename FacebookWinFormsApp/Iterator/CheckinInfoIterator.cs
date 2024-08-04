using BasicFacebookFeatures;
using System.Collections.Generic;
using System;

public class CheckinInfoIterator : IIterator
{
    private readonly List<CheckinInfo> r_Checkins;
    private int m_CurrentIdx = -1;
    private int m_Count = -1;

    public CheckinInfoIterator(List<CheckinInfo> i_Checkins)
    {
        r_Checkins = i_Checkins;
        m_Count = r_Checkins.Count;
    }

    public void Reset()
    {
        m_CurrentIdx = -1;
    }

    public bool MoveNext()
    {
        if (m_Count != r_Checkins.Count)
        {
            throw new Exception("Collection cannot be changed during iteration!");
        }
        if (m_CurrentIdx >= m_Count)
        {
            throw new Exception("Already reached the end of the collection");
        }

        return ++m_CurrentIdx < r_Checkins.Count;
    }

    public object Current
    {
        get { return r_Checkins[m_CurrentIdx]; }
    }
}