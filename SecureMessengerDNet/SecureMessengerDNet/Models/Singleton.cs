using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureMessengerDNet
{
    class Singleton
    {
        #region Attributes

        private static Singleton _instance { get; set; }
        private ObservableCollection<Message> _messages;

        #endregion

        #region Properties
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public ObservableCollection<Message> Messages
        {
            get => _messages;
            set => _messages = value;
        }

        private Singleton()
        {
            _messages = new ObservableCollection<Message>();
        }

        #endregion



    }
}
