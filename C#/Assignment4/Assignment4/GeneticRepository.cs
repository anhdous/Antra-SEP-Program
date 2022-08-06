using System.Data;

namespace Assignment4;

public class GeneticRepository<T>:IRepository<Entity>
{
    private List<Entity> lstEntity = new List<Entity>();
    public void Add(Entity item)
    {
        lstEntity.Add(item);
    }

    public void Remove(Entity item)
    {
        Entity e = GetById(item.Id);
        if (e != null)
        {
            lstEntity.Remove(e);
        }
    }
    
    public List<Entity> GetAll()
    {
        return lstEntity;
    }

    public Entity GetById(int id)
    {
        for (int i = 0; i < lstEntity.Count; i++)
        {
            if (lstEntity[i].Id == id)
            {
                return lstEntity[i];
            }
        }

        return null;
    }
}