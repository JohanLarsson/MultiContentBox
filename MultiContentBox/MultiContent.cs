using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace MultiContentBox
{
    public class MultiContent : IList
    {
        private readonly MultiContentControl _parent;

        public MultiContent(MultiContentControl parent)
        {
            _parent = parent;
        }

        public int Count { get; private set; }

        public object SyncRoot { get; private set; }

        public bool IsSynchronized { get; private set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Add(object value)
        {
            var dataTemplate = value as DataTemplate;
            if (dataTemplate != null)
            {
                _parent.DataTemplate = dataTemplate;
                return 0;
            }
            var controlTemplate = value as ControlTemplate;
            if (controlTemplate != null)
            {
                _parent.Template = controlTemplate;
                return 0;
            }
            else
            {
                _parent.Content = value;
            }
            return 0;
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool IsReadOnly { get; private set; }
        public bool IsFixedSize { get; private set; }
    }
}