using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookMessengerLib;
namespace FmAPI
{
    class FBAccess
    {
        static void Main(string[] args)
        {
            MessengerAPI obj = new MessengerAPI("EAAiZApOi1Kb4BAGlGVA93ccXecvz74t9iG3o98VfbJBC1MkbZAX8k3a41LKAjTKdZATP0e7SQZCmY7sAsT8sbB2wctMob41bJwPlq2TW4I0E53BzE1CE9eeCcg0wrGhlCuJlr6HPkNJ0h40G36GKZBH0gv5oD7mNWWzesshhd8QZDZD");
            obj.SendTextMessageAsync(660746514005471, "Hello");
        }


        static void SendMessage()
        {
            string facebookToken = "your facebook token here";
            var client = new FacebookClient(facebookToken);

            dynamic result = client.Get("me/inbox", null);

            foreach (dynamic item in result.inbox.data)
            {
                //item is a conversation
                //the latest updated conversations come first so
                //im just gona grab the first conversation with unreaded / unseen messages

                if (item.unread > 0 || item.unseen > 0)
                {
                    string conversationID = item.id;
                    string otherPerson = item.to.data[1].name;//the item.to.data[0] its myself

                    //you can access the messages of the conversation like
                    //by default it will return the last 25 messages, u can get more, by making a call too
                    //"https://graph.facebook.com/{0}/comments?limit={1}" like:
                    //dynamic result = client.Get(string.Format("{0}/comments?limit={1}",conversationID, 100), null);
                    foreach (dynamic message in item.comments.data)
                    {
                        //Do want you want with the messages
                        string id = message.id;
                        string fromName = message.from.name;
                        string fromID = message.from.id;
                        string text = message.message;
                        string createdDate = message.created_time;
                    }

                    //To send a message in this conversation, just
                    dynamic parameters = new ExpandoObject();
                    parameters.message = "A message from code!";
                    client.Post(string.Format("{0}/comments", conversationID), parameters);
                    //or
                    //client.Post(string.Format("{0}/comments", conversationID), new Dictionary<string, object> { { "message", "A message from code!" } });

                    //NOTE!! - The application must be on white list for you te be able to post a message 
                    // read - https://developers.facebook.com/docs/ApplicationSecurity/

                    break;
                }
            }
        }
    }
}
