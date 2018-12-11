using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Command
{
    class ActionOpen : ActionListenerCommand
    {
        private MedicalRecord medicalRecord;
        public ActionOpen(MedicalRecord medicalRecord)
        {
            this.medicalRecord = medicalRecord;
        }
    public void execute()
        {
            medicalRecord.open();
        }
    }
}
