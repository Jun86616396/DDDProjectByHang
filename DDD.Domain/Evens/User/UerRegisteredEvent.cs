namespace DDD.Domain.Evens.User
{

    //用户注册后引发的事件
    public class UerRegisteredEvent:DomainEvent
    {
        // 构造函数初始化，整体事件是一个值对象
        public UerRegisteredEvent( string name ,string msg)
        {
            Name = name;
            Msg = msg;
        }

        public string Name { get; set; }

        public string Msg { get; set; }

    }
}