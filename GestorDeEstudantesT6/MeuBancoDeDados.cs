﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstudantesT6
{
    internal class MeuBancoDeDados
    {
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sga_estudantes_bd_t6"); 
    }
}
