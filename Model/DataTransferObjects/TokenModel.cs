using System;
namespace Model.DataTransferObjects
{
    public class TokenModel
    {
        public string Token { get; set; }
        public string TokenType { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}