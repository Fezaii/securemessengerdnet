using SQLite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureMessengerDNet
{
    class Database
    {
        private static Database _instance;
        private SQLiteAsyncConnection db;
        private const string _dbName = "Database.db3";
        private const string _dbRepository = "Data";

        public static Database Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Database();
                }

                return _instance;
            }
        }

        private Database()
        {
            string databasePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName , _dbRepository, _dbName);
            Console.WriteLine(databasePath);

            db = new SQLiteAsyncConnection(databasePath);
        }

        public async void CreateTablePerson()
        {
            await db.CreateTableAsync<Contact>();

            Console.WriteLine("Table Contact created");
        }

        public async void CreatePerson(Contact person)
        {
            try {
                await db.InsertAsync(person);

                Console.WriteLine("Contact with id {0} created", person.Id);
            } catch 
            {
                Console.WriteLine("Nickname {0} already used", person.Nickname);
            }

        }

        public async void CreateTableMessage()
        {
            await db.CreateTableAsync<Message>();

            Console.WriteLine("Table Message created");
        }

        public async void CreateMessage(Message message)
        {
            await db.InsertAsync(message);

            Console.WriteLine("Contact with id {0} created", message.Id);

        }
    }


}
