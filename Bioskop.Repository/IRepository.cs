using Bioskop.Common;
using System.Collections.Generic;

namespace Bioskop.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> Pretrazi(TEntity entity, params FilterField[] filterFields);
        // void Dodaj(TEntity entity);
        void Azuriraj(TEntity entity, params FilterField[] filterField);
        void Obrisi(TEntity entity, params FilterField[] filterFields);
        TEntity Vrati(TEntity entity, params FilterField[] filterFields);
        List<TEntity> VratiSve(TEntity entity);

        string MakeWhereQuery(TEntity entity, params FilterField[] paramsName);
        void Dodaj(TEntity entity);

        List<TEntity> VratiSveJoin(TEntity entity, params TEntity[] entitiesJoin);
        List<TEntity> VratiJoin(TEntity entity, FilterField[] filterFields, params TEntity[] entitiesJoin);
    }
}
