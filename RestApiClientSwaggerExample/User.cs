using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestApiClientSwaggerExample
{
    [Serializable]
    [DataContract]
    public class User
    {
        [DataMember(Name = "id")] public int id { get; set; }
        [DataMember(Name = "username")] public string username { get; set; }
        [DataMember(Name = "firstName")] public string firstName { get; set; }
        [DataMember(Name = "lastName")] public string lastName { get; set; }
        [DataMember(Name = "email")] public string email { get; set; }
        [DataMember(Name = "password")] public string password { get; set; }
        [DataMember(Name = "phone")] public string phone { get; set; }
        [DataMember(Name = "userStatus")] public int userStatus { get; set; }


        public User(int id, string username, string firstName, string lastName, string email, string password, string phone, int userStatus)
        {
            this.id = id;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.phone = phone;
            this.userStatus = userStatus;
        }

        public override bool Equals(object obj)
        {
            var item = obj as User;
            bool f = item.id.Equals(id)
                     && item.username.Equals(username)
                     && item.lastName.Equals(lastName)
                     && item.firstName.Equals(firstName)
                     && item.email.Equals(email)
                     && item.password.Equals(password)
                     && item.phone.Equals(phone)
                     && item.userStatus.Equals(userStatus);
            return f;
        }
    }
}