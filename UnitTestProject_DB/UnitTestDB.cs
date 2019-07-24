using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplicationAlex;
using System.Text.RegularExpressions;


namespace UnitTestProject_DB
{

    [TestClass]
    public class UnitTestDB { 
    
        Form_goout Fg = new Form_goout();

      //Подключение к БД для проверки добавления и обновления
        
        public bool Checklog(string log) {
                var regex = new Regex("(?=.*[0-9])(?=.*[a-z])");
            return regex.IsMatch(log);
        } 
        // Проверка логина через регулярное выражение. Логин должен содержать цифру и букву
        public bool Checkpass(string pass)
        {
            var regex = new Regex("(?=.*[0-9])(?=.*[a-z])");
            return regex.IsMatch(pass);
        }
        // Проверка пароля через регулярное выражение. Пароль должен содержать цифру и букву
        
      
        [TestMethod]
        public void Test_Add_toDB()//Работает 1 раз , если шо, как  и вприложении
        {
            int id_int = 16;
            string login_string = "1";
            string password_string = "1";
            bool insert;
            insert = Fg.InsertDB(id_int, login_string, password_string);
            bool yes = true;
            Assert.AreEqual(insert, yes);//Сравнивает выполнение добавления с yes, которое обозначает true
        }

        [TestMethod]
        public void Test_Add_Picture()
        {
           
                string str_filename = "abracadabra";
                string str_key_value = "258";
                bool Update;
                Update = Fg.UpdateImage(str_filename, str_key_value);
            
            Assert.AreEqual(Update, false);
            //Если обновление провалено, то при сравнении с False тест успешно пройден, потому что подходит ожиданиям
           
        }

        [TestMethod]
        public void Log_and_Pass()
        {
            Assert.AreEqual(Checklog("apjis"), false);//Логин не должен подходить, потому что нет цифр
            Assert.AreEqual(Checkpass("10190asd"), true);//Пароль должен подойти, потому что удолетворяет регулярному выражению
            //В случае, если сравнения выполняются верно, то TestMethod является выполненным

        }

        
    }
}
