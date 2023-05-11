using System;
using ProblemasPersonalizados.Entities.Exceptions;

namespace ProblemasPersonalizados.Entities.Exceptions;

public class DomainException : ApplicationException
{
    public DomainException(string message) : base(message)
    {
        
    }
    
}