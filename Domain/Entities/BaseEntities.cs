using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enteties
{
/// <summary>
/// базовый клас для всез сущностей, который будет наследоваться
/// </summary>
    public abstract class BaseEntities
    {
        public Guid Id { get; set; }

        /// <summary>
        /// to do
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
           
            if(obj is BaseEntities entity)
                return false;

            if(Id != entity.Id)
                return false;

            return true;
        }


        /// <summary>
        /// to do
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
