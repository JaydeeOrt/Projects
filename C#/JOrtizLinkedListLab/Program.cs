/*
* Jorge Ortiz
* Linked List Lab
* CPT-244-A01H
*/

using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;

namespace LinkedListLab
{
    class TaskNode<T1, T2, T3,T4>
    {
        public T1 Task { get; set; }
        public T2 Priority { get; set; }
        public T3 DueDate { get; set; }
        public T4 Status { get; set; }

        //refference
        public TaskNode<T1, T2, T3,T4>? NextTask { get; set; }

        //Constructor
        public TaskNode(T1 task, T2 prio, T3 dueDate,T4 status)
        {
            Task = task;
            Priority = prio;
            DueDate = dueDate;
            Status = status;
            NextTask = null;
        }
    }
    class LinkedListLab<T1, T2, T3,T4>
    {

        //First thing in list
        private TaskNode<T1, T2, T3,T4>? head;

        //AddTask
        public void Add_Task(T1 task, T2 prio, T3 dueDate, T4 status)
        {
            //set node equal to the paramater info
            TaskNode<T1, T2, T3, T4> newNode = new(task, prio, dueDate, status);
            if (head == null)
            {
                //This means there is nothing here; we make the newnode the head
                head = newNode;
            }
            else
            {
                //Find end null to add it there
                TaskNode<T1, T2, T3, T4> current = head;
                //find null
                while (current.NextTask != null)
                {
                    //advance to the next node
                    current = current.NextTask;
                }

                //set new node to last position on list
                current.NextTask = newNode;
            }
        }

        //List Tasks
        public void List_Tasks()
        {
            TaskNode<T1, T2, T3, T4>? current = head;
            if (current == null)
            {
                //Empty
                Console.WriteLine("Task list is empty");
            }//endif
            while (current != null)
            {
                //print
                //****************************Write the print out statement************************************************
                Console.WriteLine($"Task: {current.Task}\nPriority: {current.Priority}\nDueDate: {current.DueDate}\nCompleted: {current.Status}\n");

                //move to the next node
                current = current.NextTask;
            }
            //current is null and do nothing
        }

        //removing Task
        public bool Remove_Task(T1 task)
        {
            if (head == null)
            {
                Console.WriteLine("There is nothing to remove");
                return false;
            }
            else if (head.Task.Equals(task))
            {
                head = head.NextTask;
                return true;
            }

            //head is not null and the head is not the thing to remove; we gotta look;
            TaskNode<T1, T2, T3, T4>? current = head;
            while (current.NextTask != null)
            {
                //Look for the name we are deleting
                if (current.NextTask.Task.Equals(task))
                {
                    //remove it
                    current.NextTask = current.NextTask.NextTask;
                    return true;
                }
                current = current.NextTask;
            }
            //we got to the end and did the find item
            Console.WriteLine("Failed to remove, could not find task!");
            return false;
        }

        //Complete a task
        public bool Marked_Completed(T1 taskname,T4 status)
        {
            if (head == null)
            {
                Console.WriteLine("There is nothing to complete");
                return false;
            }
            else if (head.Task.Equals(taskname))
            {
                head.Status = status;
                return true;
            }

            //head is not null and the head is not the thing to complete; we gotta look;
            TaskNode<T1, T2, T3, T4>? current = head;
            while (current.NextTask != null)
            {
                //Look for the name we are completign
                if (current.NextTask.Task.Equals(taskname))
                {
                    //complete
                    current.NextTask.Status = status;
                    return true;
                }
                current = current.NextTask;
            }
            //we got to the end and did the find item
            Console.WriteLine("Failed to mark completion could not find task!");
            return false;
        }

        //Find Overdue Tasks----
        public void Find_Overdue_Tasks()
        {
            if (head == null)
            {
                Console.WriteLine("There are no tasks");
            }
            TaskNode<T1, T2, T3, T4>? current = head;
            while (current != null)
            {
                if (current.DueDate is DateTime date && date < DateTime.Now && current.Status is bool status && status !=true)
                {
                    Console.WriteLine($"Task Overdue: {current.Task} \nDueDate: {current.DueDate}\n priority: {current.Priority}\n");
                }
                
                    //move to next node
                    current = current.NextTask;
            }
        }
    }
    class TaskManager
    {
        private static void Menu()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*   Task schedule menu      *");
            Console.WriteLine("*    1.Show all tasks       *");
            Console.WriteLine("*        2.Add task         *");
            Console.WriteLine("*       3.Remove task       *");
            Console.WriteLine("*     4.Complete a task     *");
            Console.WriteLine("*      5.Overdue task       *");
            Console.WriteLine("*         6.Exit            *");
            Console.WriteLine("*****************************");
        }
        static void Main(string[] args)
        {
            //Main method
            int userChoice = 0;
            int prioNum = 0;
            string taskName = "";
            bool status = false;
            DateTime date;
            Menu();
            //creates object in memory
            LinkedListLab<string, int, DateTime,bool> linkedListLab = new LinkedListLab<string, int, DateTime,bool>();
            //loops
            while (userChoice != 6)
            {
                Console.WriteLine("Please choose menu option: ");
                bool trys = int.TryParse(Console.ReadLine(), out userChoice);
                if (trys != true)
                {
                    Console.WriteLine("Error! Please enter integer");
                }

                if (userChoice == 1)
                {
                    linkedListLab.List_Tasks();
                }
                //option 2
                else if (userChoice == 2)
                {
                    //addTask
                    Console.WriteLine("Please enter name of task: ");
                    taskName = Console.ReadLine();
                    Console.WriteLine("Please enter priority of task (>0): ");
                    if (int.TryParse(Console.ReadLine(), out prioNum))
                    {
                        Console.WriteLine("Please enter duedate(yyyy-mm-dd hh:mm:ss):");
                        if (DateTime.TryParse(Console.ReadLine(), out date))
                        {
                            linkedListLab.Add_Task(taskName, prioNum, date,status);
                        }
                        else
                        {
                            Console.WriteLine("Error! Please enter duedate in (yyyy-mm-dd hh:mm:ss)format");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error! Please enter integer");
                    }//endif
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Please enter name of task you want removed: ");
                    taskName = Console.ReadLine();
                    linkedListLab.Remove_Task(taskName);
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("Please enter name of task you have completed: ");
                    taskName = Console.ReadLine();
                    linkedListLab.Marked_Completed(taskName,true);
                }
                else if (userChoice == 5)
                {
                    linkedListLab.Find_Overdue_Tasks();
                }
                else if (userChoice == 6)
                {
                    Console.WriteLine("Thank you!");
                }
                else
                {
                    Console.WriteLine("Invalid menu option. Try a integer please!");
                }//endif
                Console.WriteLine();
                Menu();
                Console.WriteLine();
            }
        }
    }
}
