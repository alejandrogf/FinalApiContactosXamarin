﻿using System;
using System.Data.Entity;
using System.Linq;
using ApiContactos.Adapters;
using ApiContactos.Models;
using ContactosModel.Model;
using RepositorioAdapter.Repositorio;

namespace ApiContactos.Repositorios
{
    public class UsuarioRepositorio:
        BaseRepositorioEntity<Usuario,UsuarioModel,UsuarioAdapter>
    {
        public UsuarioRepositorio(DbContext context) : base(context)
        {
        }

        public UsuarioModel Validar(String login, String password)
        {
            var data = Get(o => o.Login == login && 
                            o.Password == password);

            if (data.Any())
                return data.First();
            return null;
        }

        public override UsuarioModel Add(UsuarioModel model)
        {
            if(IsUnico(model.Login))
                return base.Add(model);
            return null;
        }

        public bool IsUnico(String login)
        {
            var data = Get(o => o.Login == login);

            return !data.Any();
        }
    }
}