﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

    public DbSet<TEntity> GetSet<TEntity>() where TEntity : class, IKeyedModel =>
        Set<TEntity>();
}
