using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECI
{
    public class Lexer
    {
        //Some token
        public const int TOKEN_EOF = 0;//一行代码的结束
        public const int TOKEN_VAR_PREFIX = 1;//String
        public const int TOKEN_LEFT_PAREN = 2;//(
        public const int TOKEN_RIGHT_PAREN = 3;//)
        public const int TOKEN_ASSIGNMENT = 4;//=
        public const int TOKEN_QUOTE = 5;//"
        public const int TOKEN_DOUBLEQUOTE = 6;//""
        public const int TOKEN_NAME = 7;//变量名
        public const int TOKEN_PRINT=8;//print函数

    }
}
