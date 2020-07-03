using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TWIndex.Models;

namespace TWIndex.Services
{
    public interface IRestApi
    {
        [Post("/busca")]
        Task<Resultado> Request([Body] List<string> palavras);
    }
}
