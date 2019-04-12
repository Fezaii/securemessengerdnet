using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using Messages.NET.Utils;
using SecureMessengerDNet;

namespace SecureMessengerDNet
{
    class ViewModel : INotifyPropertyChanged
    {
        #region Attributes & events

        private static Contact connectedUserTest;
        private ObservableCollection<Contact> _persons;
        private String _messageText;
        private Contact _selectedContact;

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        public ObservableCollection<Contact> Persons
        {
            get => _persons;
            set
            {
                if (_persons != value)
                {
                    _persons = value;
                    this.NotifyPropertyChanged("Persons");
                }
            }
        }

        public ObservableCollection<Message> SelectedMessages
        {
            get {
                if (_selectedContact == null) return null;
                return connectedUserTest.Messages(_selectedContact);
            }
        }

        public ObservableCollection<Message> Messages
        {
            get => Singleton.Instance.Messages;
            set
            {
                if (Singleton.Instance.Messages != value)
                {
                    Singleton.Instance.Messages = value;
                    this.NotifyPropertyChanged("Messages");
                }
            }
        }
        
        public String MessageText
        {
            get => _messageText;
            set
            {

            if (_messageText != value)
                {
                    _messageText = value;
                    this.NotifyPropertyChanged("MessageText");
                }
            }
        }

        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (_selectedContact != value)
                {
                    _selectedContact = value;
                    this.NotifyPropertyChanged("SelectedContact");
                    this.NotifyPropertyChanged("SelectedMessages");
                }
            }
        }

        #endregion


        public ViewModel()
        {
            #region Objects initialization

            _persons = new ObservableCollection<Contact>();

            Contact p1 = new Contact("Bob", DateTime.Now);
            Contact p2 = new Contact("Alice", DateTime.Now);
            Contact p3 = new Contact("Tom", DateTime.Now);

            connectedUserTest = p1;

            _persons.Add(p1);
            _persons.Add(p2);
            _persons.Add(p3);
        

            Message m1 = new Message("bjr", p1, p2);

            Messages.Add(m1);
            Messages.Add(new Message("slt", p2, p1));
            Messages.Add(new Message("bonsoir", p1, p3));
            #endregion

            #region Commands initialization
            ConnexionCommand = new AppCommands(Connexion);
            SendMessageCommand = new AppCommands(SendMessage);
            DeleteContactCommand = new AppCommands(DeleteContact);
            OpenNewContactCommand = new AppCommands(OpenNewContact);

            #endregion


        }

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public bool NotifyPropertyChanged<T>(ref T variable, T valeur, string nomPropriete = null)
        {
            if (object.Equals(variable, valeur)) return false;

            variable = valeur;
            NotifyPropertyChanged(nomPropriete); 
            return true;
        }



        #region Commands
        public ICommand SendMessageCommand { get; set; }

        private void SendMessage()
        {
            Messages.Add(new Message(_messageText, connectedUserTest, _selectedContact));

            if (_selectedContact == null)
            {
                MessageBox.Show("You haven't selected a contact");
                return;
            }

            MessageText = "";
            this.NotifyPropertyChanged("SelectedMessages");
        }

        public ICommand DeleteContactCommand { get; set; }

        private void DeleteContact()
        {
            if (_selectedContact != null)
            {
                Persons.Remove(SelectedContact);
            }
        }

        public ICommand OpenNewContactCommand { get; set; }

        private void OpenNewContact()
        {
            NewContact newContact = new NewContact();
            newContact.Show();
        }
        public ICommand ConnexionCommand { get; set; }

        private void Connexion()
        {
            NewContact newContact = new NewContact();
            newContact.Show();
        }


        #endregion

    }
}
