using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_Markov.Classes;
using TaskManager_Markov.Context;
using TaskManager_Markov.Models;

namespace TaskManager_Markov.ViewModels
{
    public class VM_Tasks : Notification
    {
        public TasksContext tasksContext = new TasksContext();
        public ObservableCollection<Tasks> Tasks { get; set; }
        public VM_Tasks() => Tasks = new ObservableCollection<Tasks>(tasksContext.Tasks.OrderBy(x => x.Done));
        public RelayCommand OnAddTask
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Tasks NewTask = new Tasks()
                    {
                        Name = "Новый прикол",
                        Priority = "Средне",
                        DateExecute = DateTime.Now,
                        Comment = "Накалаякай",
                        Done = false,
                        IsEnable = true
                    };
                    Tasks.Add(NewTask);
                    tasksContext.Tasks.Add(NewTask);
                    tasksContext.SaveChanges();
                });
            }
        }
    }
}
