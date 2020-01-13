using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface ISerializelogin 
        {
            void serialize(List<userLogin> userList);
        }
    

    

    public interface ISerializelpass
    {
        void serialize(List<userPassword> passwords);
            
    }

    public interface ISerializeCar
    {
        void serialize(List<cars> userList);
    }

    public interface ISerializeClient
    {
        void serialize(List<clients> clientsList);
    }

    public interface ISerializeRent
    {
        void serialize(List<rents> rentsList);
    }

}