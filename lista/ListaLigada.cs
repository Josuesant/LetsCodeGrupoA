using System.Collections.Generic;
using System.Linq;

namespace aula.lista
{
    public class ListaLigada
    {
        public Vagao Trem { get; set; }

        public void InserirVagao(Vagao novoVagao)
        {
            if (Trem == null) Trem = novoVagao;
            else
            {
                var vagaoAnterior = GetUltimoVagao();
                vagaoAnterior.VagaoAnterior = novoVagao;
            }
        }

        public Vagao GetUltimoVagao()
        {
            var tempVagao = Trem;
            while (tempVagao!= null && tempVagao.VagaoAnterior != null)
            {
                tempVagao = tempVagao.VagaoAnterior;
            }
            return tempVagao;
        }

        public List<Vagao> GetVagoes()
        {
            var _trem = new List<Vagao>();
            var tempVagao = Trem;
            while (tempVagao != null)
            {
                _trem.Add(tempVagao);
                tempVagao = tempVagao.VagaoAnterior;
            }
            return _trem;
        }

        public Vagao GetVagaoById(int id)
        {
            var vagoes = GetVagoes();
            return vagoes.FirstOrDefault(x => x.Id == id);
        }

        public List<Vagao> GetVagaoByName(string carga)
        {
           var vagoes = GetVagoes();
            return vagoes.Where(x => x.Carga == carga).ToList();
        }

        public List<Vagao> GetVagaoByPeso(int peso)
        {
           var vagoes = GetVagoes();
           return vagoes.Where(x => x.Peso == peso).ToList();
        }

        public void DeletarVagao(Vagao vagao)
        {
            var vagoes = GetVagoes();
            var proximoVagao = vagoes.FirstOrDefault(x => x.VagaoAnterior?.Id == vagao.Id);
            
            if(proximoVagao == null)
                Trem = vagao.VagaoAnterior;
            else            
                proximoVagao.VagaoAnterior = vagao.VagaoAnterior;
        }
    }
}