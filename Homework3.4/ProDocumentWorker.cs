using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._4
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("the document is edit");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("the document is save in the old format, other format is available in version EXPERT");
        }
    }
}
