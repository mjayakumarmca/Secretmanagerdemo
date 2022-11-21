using Microsoft.Extensions.Options;

namespace Secretmanagerdemo
{
    public class MyService
    {
        private readonly MyApiCredentials _myApiCredentials;

        public MyService(IOptions<MyApiCredentials> options)
        {
            _myApiCredentials = options.Value;
        }
    }
}
