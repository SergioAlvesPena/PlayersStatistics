using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersStatistics.Core.Entities
{
    public abstract class Entity
    {
        #region Constructors
        protected Entity()
        {
        }

        protected Entity(DateTime createdOn, bool isDeleted, DateTime modfiedOn)
        {
            Id = Guid.NewGuid();
            IsDeleted = false;
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }

        #endregion

        #region Proprierties
        /// <summary>
        /// Entity Id
        /// </summary>
        public Guid Id { get; private set; }
        /// <summary>
        /// Entity creation date
        /// </summary>
        public DateTime CreatedOn { get; private set; }
        /// <summary>
        /// Entity deleted status
        /// </summary>
        public bool IsDeleted { get; private set; }
        /// <summary>
        /// Entity last update date
        /// </summary>
        public DateTime ModifiedOn { get; private set; }

        #endregion

        #region Methods
        public void SetIsDeleted(bool isDeleted)
        {
            IsDeleted = isDeleted;
            UpdateModifiedOn();
        }

        public void UpdateModifiedOn()
            => ModifiedOn = DateTime.Now;

        #endregion

    }
}
