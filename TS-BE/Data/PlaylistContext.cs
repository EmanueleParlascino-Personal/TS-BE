using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TS_BE.Models;

    public class PlaylistContext : DbContext
    {
        public PlaylistContext (DbContextOptions<PlaylistContext> options)
            : base(options)
        {
        }

        public DbSet<TS_BE.Models.Playlist> Playlist { get; set; } = default!;
    }
