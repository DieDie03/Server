using MakerHub.API.DTO;
using MakerHub.DAL;
using MakerHub.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolBox.AutoMapper.Mappers;

namespace MakerHub.API.Services
{
    public class MakerHubService
    {
        private readonly MakerHubDBContext dc;
        public MakerHubService(MakerHubDBContext dc)
        {
            this.dc = dc;
        }

        /// <summary>
        /// Ajouter un taux d'humidité a la DB
        /// </summary>
        /// <param name="DTO">Humidité</param>
        //public void Create(AggroDTO DTO)
        //{
        //    dc.Humidity.Add(DTO.MapTo<Aggrometre>());
        //    dc.SaveChanges();
        //}
        /// <summary>
        /// Récupération des taux d'humidité
        /// </summary>
        /// <param name="DTO">Humidité</param>
        /// <returns></returns>
        //public IEnumerable<AggroDTO> Read()
        //{
        //    return dc.Humidity
        //        .MapToList<AggroDTO>();
        //}
        
        public void Create(SoundDTO dto)
        {

            dc.Intensity.Add(dto.MapTo<Sound>());
            dc.SaveChanges();
        }
        
        public IEnumerable<SoundDTO> ReadSound()
        {
            return dc.Intensity
                .MapToList<SoundDTO>();
        }
    }
}
