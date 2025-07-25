﻿using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using Microsoft.EntityFrameworkCore;

namespace GeradorDeTestes.Infraestrutura.ORM.Compartilhado;
public class GeradorDeTestesDbContext : DbContext
{
    public DbSet<Alternativa> Alternativas { get; set; }
    public DbSet<Disciplina> Disciplinas { get; set; }
    public DbSet<Materia> Materias { get; set; }
    public DbSet<Questao> Questoes { get; set; }
    public DbSet<Teste> Testes { get; set; }
    public DbSet<TesteMateriaQuantidade> QuantidadesPorMateria { get; set; }

    public GeradorDeTestesDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GeradorDeTestesDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
