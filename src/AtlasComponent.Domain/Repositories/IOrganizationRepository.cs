﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDb.Atlas.Client.AtlasComponent.Domain.Models;

namespace MongoDb.Atlas.Client.AtlasComponent.Domain.Repositories
{
    public interface IOrganizationRepository
    {
        Task<List<OrganizationModel>> FindAllAsync();
    }
}
