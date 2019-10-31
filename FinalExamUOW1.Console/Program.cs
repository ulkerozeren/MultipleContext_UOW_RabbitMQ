using FinalExamUOW1.RabbitMQ;

namespace FinalExamUOW1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            new PublisherHelper("userLog", "");
            new ConsumerHelper("userLog");
        }
    }
}
