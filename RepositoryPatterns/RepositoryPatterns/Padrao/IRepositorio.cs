using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatterns.Padrao
{
    public interface IRepositorio <T>
    {
        T GetById(int id);
        void Salvar(T entidade);
        void Deletar(T entidade);
    }
}
