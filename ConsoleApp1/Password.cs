using System;
using System.Xml.Serialization;

namespace ConsoleApp1
{

    [Serializable]
    [XmlRoot("Login")]
    public class userPassword : IEquatable<userPassword>

    {
    public userPassword(string Password)
    {
        _password = Password;
    }

    public userPassword()
    {
    }

    private string _password;



    [XmlAttribute("Password")]
    public string Password
    {
        get => _password;
        set => _password = value;
    }

    public bool Equals(userPassword other)
    {
        if (this.Password == other.Password)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return $"Password: {_password}";
    }
    }
}