using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Interface for all repositories
/// </summary>
namespace sharry.blog.repository
{
    public interface IRepository<T> : IDisposable
    {
       T getElementById(int id);

       List<T> getAllElements();

       int insertElement(T t);

       int updateElement(T t);
    }
}
