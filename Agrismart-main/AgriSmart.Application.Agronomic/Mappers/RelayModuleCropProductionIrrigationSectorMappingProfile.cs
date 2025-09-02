﻿using AgriSmart.Application.Agronomic.Commands;
using AgriSmart.Application.Agronomic.Responses.Commands;
using AgriSmart.Core.Entities;
using AutoMapper;

namespace AgriSmart.Application.Agronomic.Mappers
{
    public class RelayModuleCropProductionIrrigationSectorMappingProfile : AutoMapper.Profile
    {
        public RelayModuleCropProductionIrrigationSectorMappingProfile() {

            CreateMap<RelayModuleCropProductionIrrigationSector, CreateRelayModuleCropProductionIrrigationSectorCommand>().ReverseMap();
            CreateMap<RelayModuleCropProductionIrrigationSector, CreateRelayModuleCropProductionIrrigationSectorResponse>().ReverseMap();
            CreateMap<RelayModuleCropProductionIrrigationSector, DeleteRelayModuleCropProductionIrrigationSectorCommand>().ReverseMap();
            CreateMap<RelayModuleCropProductionIrrigationSector, DeleteRelayModuleCropProductionIrrigationSectorResponse>().ReverseMap();
        }
    }
}