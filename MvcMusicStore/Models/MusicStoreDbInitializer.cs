using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer:System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist() { Name = "Al Di melda" });
            context.Genres.Add(new Genre() { Name = "Genre1", Description = "First" });
            context.Albums.Add(new Album
                                {
                                    Artist = new Artist() { Name = "Bob" },
                                    Genre = new Genre() { Name="Rock"},
                                    Price = 9.99m,
                                    Title = "Title1"
            });
            base.Seed(context);
        }
    }
}