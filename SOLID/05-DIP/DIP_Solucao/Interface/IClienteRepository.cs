﻿using System.ComponentModel;

namespace SOLID._05_DIP.DIP_Solucao.Interface;
public interface IClienteRepository
{
    Task AdicionarCliente(Cliente cliente);
}