using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TS_BE.Models;


public class Playlist
{
    public int Id { get; set; }
    public string Seed { get; set; }
    public List<Track> Tracks { get; set; }
}