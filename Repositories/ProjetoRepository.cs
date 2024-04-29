using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespaceExo.WebApi.Repositories
{
    publicclassProjetoRepository
    {
privatereadonlyExoContext_context;
publicProjetoRepository(ExoContextcontext)
{
_context= context;
}
publicList<Projeto> Listar()
{
return_context.Projetos.ToList();
}
// Código novo que completa o CRUD.
publicvoidCadastrar(Projetoprojeto)
{
_context.Projetos.Add(projeto);
_context.SaveChanges();
}
publicProjetoBuscarporId(intid)
{
return_context.Projetos.Find(id);
}
publicvoidAtualizar(intid, Projetoprojeto)
{
ProjetoprojetoBuscado= _context.Projetos.Find(id);
if(projetoBuscado!= null)
{
projetoBuscado.NomeDoProjeto= projeto.NomeDoProjeto;
projetoBuscado.Area= projeto.Area;
projetoBuscado.Status= projeto.Status;
}
_context.Projetos.Update(projetoBuscado);
_context.SaveChanges();
}
publicvoidDeletar(intid)
{
ProjetoprojetoBuscado= _context.Projetos.Find(id);
_context.Projetos.Remove(projetoBuscado);
_context.SaveChanges();
}
}
}
