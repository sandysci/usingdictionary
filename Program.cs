using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace diction2prac
{
    class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student()
            {
                id = 1,
                name = "ngozi",
                age = 20


            };
            student student2 = new student()
            {
                id = 2,
                name = "chinedu",
                age = 30


            };
            student student3 = new student()
            {
                id = 3,
                name = "richy",
                age = 40


            };

            Dictionary<int, student> mydic = new Dictionary<int, student>();
            mydic.Add(student1.id, student1);// add to the dictionary using the id as the key and the student's value
            mydic.Add(student2.id, student2);
            mydic.Add(student3.id, student3);
            foreach(var k in mydic){

                int theid = k.Key;//the key
                student values = k.Value;//ll the value
                Console.WriteLine("The key is {0}", theid);//output the key
                Console.WriteLine(" ID ={0} Name={1} age={2}", values.id, values.name, values.age);//output the values in the dictionary
  
            }
            Console.ReadLine();
            /**or remove comment to try this code 
             * student st;
             for (int i = 1; i <= 3; i++) {
                 mydic.TryGetValue(i, out st);
                 Console.WriteLine("id={0} name={1} age= {2}", st.id, st.name, st.age);
                 Console.ReadLine();
            
             }
             if (mydic.TryGetValue(2, out st))
             {
                 Console.WriteLine("id={0} name={1} age= {2}", st.id, st.name, st.age);
                 Console.ReadLine();
             }
             else {

                 Console.WriteLine("dont exit");
                 Console.ReadLine();
             }

             Console.WriteLine("the total in the dictionary is {0}", mydic.Count(kvp => kvp.Value.age>30));
           
             Console.WriteLine("the total is {0}", mydic.Count());
             Console.ReadLine();
             student myst = mydic[1];
             Console.WriteLine("id={0} name={1} age= {2}", myst.id, myst.name, myst.age);
            
             foreach(KeyValuePair<int, student> keys in mydic){
                 Console.WriteLine("the key {0}", keys.Key);
                student STU= keys.Value;
                Console.WriteLine("the ID {0} THE name {1} the age {2} ",STU.id,STU.name, STU.age );
                
                 Console.ReadLine();
            
             }**/
        }
    }
    class student {


        public int id
        {
            get;
            set;

        }
        public string name
        {
            get;
            set;

        }
        public int age
        {
            get;
            set;

        }
    }
}
