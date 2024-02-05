using System.Collections.Generic;

namespace EconomiaDomestica.Models
{
    public interface IRegistroRepository
    {
        void Add(Registro registro);
        void Edit(Registro registro);
        void Delete(Registro registro);
        IEnumerable<Registro> GetAll();
        IEnumerable<Registro> GetByValue(string value);      
    }
}
