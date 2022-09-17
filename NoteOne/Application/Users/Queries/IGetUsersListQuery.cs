using NoteOne.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOne.Application.Queries
{
    public interface IGetUsersListQuery
    {
        List<User> Execute();
    }
}
