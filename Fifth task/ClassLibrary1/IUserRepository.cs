﻿namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IUserRepository : IBaseRepository<User>
    {
        User Choose_theme_and_rate(User user);
    }
}
