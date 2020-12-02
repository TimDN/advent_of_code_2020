using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    interface IPasswordRule
    {
        bool PasswordFollowsRule(string password);
    }
}
