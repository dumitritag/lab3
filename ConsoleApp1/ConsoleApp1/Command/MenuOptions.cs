using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Command
{
    class MenuOptions
    {
        private ActionListenerCommand openCommand;
        private ActionListenerCommand saveCommand;

        public MenuOptions(ActionListenerCommand open, ActionListenerCommand save)
        {
            this.openCommand = open;
            this.saveCommand = save;
        }
        public void clickOpen()
        {
            openCommand.execute();
        }
        public void clickSave()
        {
            saveCommand.execute();
        }
    }
}
