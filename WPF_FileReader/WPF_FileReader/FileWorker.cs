using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FirstName; MiddleName; LastName; Age; Salary;
//Харитонов; Дмитрий; Александрович; 20; 35000
//Савельев; Венедикт; Наумович; 32; 32500
//Тимофеев; Лазарь; Аристархович; 50; 42000
//Дмитриев; Владислав; Проклович; 18; 29700
//Авдеев; Евдоким; Дамирович; 20; 29600
//Терентьева; Веста; Аркадьевна; 23; 30000
//Прохорова; Верона; Владиславовна; 28; 31000
//Белоусова; Динара; Олеговна; 20; 28900
//Власова; Ванесса; Протасьевна; 31; 32000
//Мишин; Вениамин; Михайлович; 26; 29800

namespace WPF_FileReader
{
    public class FileWorker
    {
        public ObservableCollection<User> FileRead()
        {
            var userList = new ObservableCollection<User>();
            using (StreamReader streamReader = new StreamReader(@"C:\Users\Ирина\source\repos\WPF_FileReader\WPF_FileReader\Files\users1_1.txt"))
            {
                foreach (var item in streamReader.ReadToEnd().Split('\n'))
                {
                    var stringArray = item.Split(';');
                    if (stringArray[0] != "FirstName")
                    {
                        User user = new User()
                        {
                            FirstName = stringArray[0],
                            MiddleName = stringArray[1],
                            LastName = stringArray[2],
                            Age = int.Parse(stringArray[3]),
                            Salary = int.Parse(stringArray[4])
                        };
                        userList.Add(user);
                    }
                }
            }
            return userList;
        }
    }
}
