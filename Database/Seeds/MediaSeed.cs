
using Common;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Infrastructure.Database.Seeds
{
    public class MediaSeed
    {
        public static List<Media> Medias { get; } = new()
        {
            new Media
            {
                Id = 1,
                Title = "Star Wars: Return of the Jedi",
                ReleaseYear = "1983-05-25",
                Description = "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZZCMJ4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 2,
                Title = "Star Wars: A New Hope",
                ReleaseYear = "1977-05-17",
                Description = "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZXZDZ3/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 3,
                Title = "Lord Of The Rings: The Two Towers",
                ReleaseYear = "2002-12-18",
                Description = "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 4,
                Title = "The Hobbit: An Unexpected Journey",
                ReleaseYear = "2012-12-13",
                Description = "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 5,
                Title = "Brooklyn Nine-Nine",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 6,
                Title = "Lord Of The Rings: The Return Of The King",
                ReleaseYear = "2013-09-17",
                Description = "The former Fellowship members prepare for the final battle. While Frodo and Sam approach Mount Doom to destroy the One Ring, they follow Gollum, unaware of the path he is leading them to",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 7,
                Title = "The Hobbit: An Unexpected Journey",
                ReleaseYear = "2013-09-17",
                Description = "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 8,
                Title = "The Hobbit: The Desolation of Smaug",
                ReleaseYear = "2013-12-12",
                Description = "Bilbo Baggins, a hobbit, and his companions face great dangers on their journey to Laketown. Soon, they reach the Lonely Mountain, where Bilbo comes face-to-face with the fearsome dragon Smaug.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZJ5NLV/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 9,
                Title = "The Hobbit: The Battle of the Five Armies",
                ReleaseYear = "2014-12-11",
                Description = "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects the Lonely Mountain after a conflict arises.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZTH3PF/image?locale=en-nz&purposes=BoxArt&mode=scale&q=90&w=162",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 10,
                Title = "Rick and Morty",
                ReleaseYear = "2013-09-17",
                Description = "After having been missing for nearly 20 years, Rick Sanchez suddenly arrives at daughter Beth's doorstep to move in with her and her family.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN85RB/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 11,
                Title = "The Walking Dead",
                ReleaseYear = "2010-10-31",
                Description = "In the wake of a zombie apocalypse, various survivors struggle to stay alive. As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN90WK/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 12,
                Title = "Star Trek: Discovery",
                ReleaseYear = "2017-09-24",
                Description = "Michael Burnham and her companions in the USS Discovery travel into the far reaches of space to meet new lifeforms and discover new planets.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN8KT4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 13,
                Title = "Yellowstone",
                ReleaseYear = "2018-06-20",
                Description = "A sixth-generation homesteader and devoted father, John Dutton controls the largest contiguous ranch in the United States. He operates in a corrupt world where politicians are compromised by influential oil and lumber corporations and land grabs make developers billions.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN6RB1/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 14,
                Title = "The Flash",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 15,
                Title = "ELite",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 16,
                Title = "Vampire diaries",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 17,
                Title = "Lucifer",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 18,
                Title = "Marlon",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 19,
                Title = "Teen wolf",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 20,
                Title = "Invisible city",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 21,
                Title = "Locke is key",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 22,
                Title = "Fate",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 23,
                Title = "The Crew",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 24,
                Title = "Riverdale",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 25,
                Title = "The Ranch",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 26,
                Title = "Family guy",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 27,
                Title = "Cobra kai",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 28,
                Title = "Good Girls",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },


            new Media
            {
                Id = 29,
                Title = "The Witcher",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },
            new Media
            {
                Id = 30,
                Title = "Money heist",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 31,
                Title = "The Ranch",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 32,
                Title = "Just like heaven",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 33,
                Title = "Before I fall",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 34,
                Title = "The half of it",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 35,
                Title = "Endless love",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 36,
                Title = "Robin Hood",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 37,
                Title = "Aladdin",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 38,
                Title = "Gladiator",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 39,
                Title = "Defiance",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 40,
                Title = "POMS",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 41,
                Title = "Wonder",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 42,
                Title = "Transporter 3",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 43,
                Title = "Transporter 2",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 44,
                Title = "Transporter 1",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 45,
                Title = "Zoung adult",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 46,
                Title = "Shaft",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 47,
                Title = "Crash pad",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 48,
                Title = "Takers",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 49,
                Title = "Creed 3",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 50,
                Title = "Creed 2",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 51,
                Title = "Creed",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 52,
                Title = "Swiped",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 53,
                Title = "Hangover part 3",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 54,
                Title = "Hangover part 2",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 55,
                Title = "Hangover part 1",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 56,
                Title = "John Wick 3",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 57,
                Title = "John Wick 2",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 58,
                Title = "John Wick",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 59,
                Title = "The perfect date",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 60,
                Title = "Rudy",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 61,
                Title = "Just friends",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 62,
                Title = "Red 2",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 63,
                Title = "Pitch perfect",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 64,
                Title = "Work it",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 65,
                Title = "Kate",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 66,
                Title = "Grown ups 2",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 67,
                Title = "Grown ups",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 68,
                Title = "Blended",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 69,
                Title = "The Internship",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 70,
                Title = "Playing with fire",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 71,
                Title = "Monte Carlo",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 72,
                Title = "She is all that",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 73,
                Title = "47 ronin",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 74,
                Title = "Enola Holmes",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 75,
                Title = "Noah",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 76,
                Title = "In time",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 77,
                Title = "Midway",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 78,
                Title = "The Mask",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 79,
                Title = "Holidate",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 80,
                Title = "Warcraft",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 81,
                Title = "Tomb Raidler",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 82,
                Title = "Be somebody",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 83,
                Title = "Baywatch",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 84,
                Title = "Sweet girl",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 85,
                Title = "Good boys",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 86,
                Title = "Kong : skull island",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 87,
                Title = "Star trek",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },

            new Media
            {
                Id = 88,
                Title = "Journey 2",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },
            new Media
            {
                Id = 89,
                Title = "Constantine",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Movie,

            },


            new Media
            {
                Id = 90,
                Title = "Warrior nun",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 91,
                Title = "Merlin",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 92,
                Title = "The Walking Dead",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 93,
                Title = "Van Helsing",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 94,
                Title = "How I met your mother",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 95,
                Title = "Zero chill",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 96,
                Title = "Superman and Louise",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 97,
                Title = "Good witch",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 98,
                Title = "Shadow and Bone",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },

            new Media
            {
                Id = 99,
                Title = "Shadow hunters",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            },


            new Media
            {
                Id = 100,
                Title = "Dare me",
                ReleaseYear = "2013-09-17",
                Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                MediaType = MediaType.Series,

            }






        };
    }
}
