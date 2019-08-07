using System;

namespace MvcPWx
{
    internal class ASPSMSX2
    {
        internal class ASPSMSX2SoapClient
        {
            private string v;

            public ASPSMSX2SoapClient(string v)
            {
                this.v = v;
            }

            internal void SendSimpleTextSMS(string v1, string v2, string destination, string v3, string body)
            {
                throw new NotImplementedException();
            }

            internal void Close()
            {
                throw new NotImplementedException();
            }
        }
    }
}