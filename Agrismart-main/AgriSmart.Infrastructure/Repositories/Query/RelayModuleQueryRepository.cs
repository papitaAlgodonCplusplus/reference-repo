﻿using AgriSmart.Core.Configuration;
using AgriSmart.Infrastructure.Data;
using AgriSmart.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Data;
using AgriSmart.Core.Repositories.Queries;
using Microsoft.AspNetCore.Http;
using AgriSmart.Application.Agronomic.Resources;



namespace AgriSmart.Infrastructure.Repositories.Query
{
    public class RelayModuleQueryRepository : BaseQueryRepository<RelayModule>, IRelayModuleQueryRepository
    {
        protected readonly AgriSmartContext _context;
        public RelayModuleQueryRepository(AgriSmartContext context, IOptions<AgriSmartDbConfiguration> dbConfiguration, IHttpContextAccessor httpContextAccessor) : base(dbConfiguration, httpContextAccessor)
        {
            _context = context;
        }


        public async Task<IReadOnlyList<RelayModule>> GetAllAsync(bool includeInactives = false)
        {
            try
            {
                return await (from c in _context.RelayModule
                              where (
                                        (c.Id == GetSessionClientId() && GetSessionProfileId() == (int)Profiles.CompanyUser) ||
                                        (c.Id == GetSessionClientId() && GetSessionProfileId() == (int)Profiles.ClientAdmin) ||
                                        (GetSessionProfileId() == (int)Profiles.SuperUser)
                                    )
                                    && ((c.Active && !includeInactives) || includeInactives)
                              select c).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<RelayModule?> GetByIdAsync(int id)
        {
            try
            {
                return await (from c in _context.RelayModule
                              where (
                                        (c.Id == GetSessionClientId() && GetSessionProfileId() == (int)Profiles.CompanyUser) ||
                                        (c.Id == GetSessionClientId() && GetSessionProfileId() == (int)Profiles.ClientAdmin) ||
                                        (GetSessionProfileId() == (int)Profiles.SuperUser)
                                    )
                                     && (c.Id == id)
                              select c).FirstOrDefaultAsync();                                 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}