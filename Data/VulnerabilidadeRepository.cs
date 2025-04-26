using VulnerabilidadesApp.Models;

namespace VulnerabilidadesApp.Data
{
    public class VulnerabilidadeRepository
    {
        private static List<Vulnerabilidade> _vulnerabilidades = new List<Vulnerabilidade>();
        private static int _proximoId = 1;

        public List<Vulnerabilidade> ObterTodas()
        {
            return _vulnerabilidades;
        }

        public Vulnerabilidade ObterPorId(int id)
        {
            return _vulnerabilidades.FirstOrDefault(v => v.Id == id);
        }

        public void Adicionar(Vulnerabilidade vulnerabilidade)
        {
            vulnerabilidade.Id = _proximoId++;
            _vulnerabilidades.Add(vulnerabilidade);
        }

        public void Atualizar(Vulnerabilidade vulnerabilidade)
        {
            var existente = ObterPorId(vulnerabilidade.Id);
            if (existente != null)
            {
                existente.Titulo = vulnerabilidade.Titulo;
                existente.Descricao = vulnerabilidade.Descricao;
                existente.Severidade = vulnerabilidade.Severidade;
                existente.DataDescoberta = vulnerabilidade.DataDescoberta;
            }
        }

        public void Remover(int id)
        {
            var vulnerabilidade = ObterPorId(id);
            if (vulnerabilidade != null)
            {
                _vulnerabilidades.Remove(vulnerabilidade);
            }
        }
    }
}
