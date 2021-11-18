using LearnMediator2.Classes;
using System;

namespace LearnMediator2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create chatroom
            Chatroom chatroom = new Chatroom();

            // Create participants and register them
            Participant George = new Messenger("George");
            Participant Paul = new Messenger("Paul");
            Participant Ringo = new Messenger("Ringo");
            Participant John = new Messenger("John");
            Participant Yoko = new Zalo("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            // Chatting participants
            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "Hi Ringo ^^");
            Ringo.Send("George", "Long time no see. You still good?.");
            Paul.Send("John", "Washup bro");
            John.Send("Yoko", "Hello my senorita <3 ");

            John.Receive("Yoko", "(^ I ^)");
        }
    }
}
