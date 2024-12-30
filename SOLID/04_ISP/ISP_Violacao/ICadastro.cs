﻿namespace SOLID._04_ISP.ISP_Violacao;

/// <summary>
/// Aqui estamos implementando a interfce ICadastro que vai ser herdada por outras classes. Só que aqui estamos forçando 
/// as classes que herdarem a implementar os métodos ValidarDados, SalvarBanco e EnviarEmail. O problema é que a classe
/// não tiver que enviar email, ela vai ter que implementar o método mesmo assim.
/// </summary>
public interface ICadastroCliente
{
    void ValidarDados();
    void SalvarBanco();
    void EnviarEmail();
}