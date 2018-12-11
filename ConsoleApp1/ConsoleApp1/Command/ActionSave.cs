using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Command
{
    class ActionSave : ActionListenerCommand
    {
        private MedicalRecord medicalRecord;
        public ActionSave(MedicalRecord medicalRecord)
        {
            this.medicalRecord = medicalRecord;
        }
        public void execute()
        {
            medicalRecord.save();
        }
    }
}
