using System.Threading.Tasks;

namespace ProjectDemo.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}