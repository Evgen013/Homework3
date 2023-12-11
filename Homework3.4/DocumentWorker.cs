using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._4
{
    internal class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("document is open");
        }
        public virtual void EditDocument() 
        {
            Console.WriteLine("editing of the document is available in the version PRO");
        }
        public virtual void SaveDocument() 
        {
            Console.WriteLine("save of the document is avaible in the version PRO");
        }
    }
}
