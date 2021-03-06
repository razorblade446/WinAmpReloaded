﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WinAmp2.BUSINESS.Services.Implementation;
using WinAmp2.BUSINESS.Services.Interface;
using WinAmp2.COMMON.DTOs.PlayListsProject;

namespace WinAmp2.API.Controllers
{
    public class GenreController : ApiController
    {
        IGenreService genre = new GenreService();
        // GET: api/Genre
        public IList<GenreDto> Get()
        {
            return genre.getAllGenres();
        }

        // GET: api/Genre/5
        public GenreDto Get(int id)
        {
            return genre.getGenreById(id);
        }

        // POST: api/Genre
        public GenreDto Post(GenreDto newGenre)
        {
            return genre.createOrUpdateGenre(newGenre);
        }

        // PUT: api/Genre/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Genre/5
        public GenreDto Delete(int id)
        {
            return genre.deleteGenreById(id);
        }
    }
}
