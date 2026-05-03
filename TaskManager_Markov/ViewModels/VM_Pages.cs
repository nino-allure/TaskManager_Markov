using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_Markov.Classes;
using TaskManager_Markov.View;

namespace TaskManager_Markov.ViewModels
{
    public class VM_Pages : Notification
    {
        public VM_Tasks vm_tasks = new VM_Tasks();
        public VM_Pages()
        {
            MainWindow.init.frame.Navigate(new View.Main(vm_tasks));
        }
        public RelayCommand OnClose
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    MainWindow.init.Close();
                });
            }
        }
    }
}
