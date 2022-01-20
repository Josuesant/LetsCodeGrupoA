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
                var vagaoAnterior = getUltimoVagao();
                vagaoAnterior.VagaoAnterior = novoVagao;
            }
        }

        public Vagao getUltimoVagao()
        {
            var tempVagao = Trem;
            while (tempVagao.VagaoAnterior != null)
            {
                tempVagao = tempVagao.VagaoAnterior;
            }
            return tempVagao;
        }

        public List<Vagao> getVagoes()
        {
            var _trem = new List<Vagao>();
            var tempVagao = Trem;
            while (tempVagao != null)
            {
                _trem.Add(tempVagao);
                tempVagao = tempVagao.VagaoAnterior;
            };
            return _trem;
        }

        public Vagao getVagaoById(int id)
        {
            var vagoes = getVagoes();
            return vagoes.FirstOrDefault(x => x.Id == id);
        }
    }
}