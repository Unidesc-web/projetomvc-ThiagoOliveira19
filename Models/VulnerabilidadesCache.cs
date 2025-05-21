using System;
using System.Collections.Generic;

namespace VulnerabilidadesApp.Models
{
    public static class VulnerabilidadesCache
    {
        public static List<Vulnerabilidade> Lista { get; set; }

        static VulnerabilidadesCache()
        {
            Lista = new List<Vulnerabilidade>
            {
                new Vulnerabilidade 
                { 
                    Id = 1, 
                    Titulo = "SQL Injection", 
                    Descricao = "Inserção de comandos SQL maliciosos em campos de entrada.", 
                    Severidade = "Alta", 
                    DataDescoberta = new DateTime(2023, 1, 15) 
                },
                new Vulnerabilidade 
                { 
                    Id = 2, 
                    Titulo = "Cross-Site Scripting (XSS)", 
                    Descricao = "Injeção de scripts maliciosos em páginas web.", 
                    Severidade = "Média", 
                    DataDescoberta = new DateTime(2023, 2, 10) 
                },
                new Vulnerabilidade 
                { 
                    Id = 3, 
                    Titulo = "Buffer Overflow", 
                    Descricao = "Excesso de dados que ultrapassa o limite de memória alocado.", 
                    Severidade = "Alta", 
                    DataDescoberta = new DateTime(2022, 12, 5) 
                },
                new Vulnerabilidade 
                { 
                    Id = 4, 
                    Titulo = "Broken Authentication", 
                    Descricao = "Falhas no processo de autenticação do usuário.", 
                    Severidade = "Crítica", 
                    DataDescoberta = new DateTime(2023, 3, 22) 
                }
                // Pode adicionar mais itens aqui
            };
        }
    }
}
